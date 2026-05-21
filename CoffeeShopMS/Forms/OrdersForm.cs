using CoffeeShopMS.Database;
using CoffeeShopMS.Models;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

/// <summary>
/// OrdersForm: Create new customer orders, add/remove items, calculate totals.
/// </summary>
public partial class OrdersForm : Form
{
    // Current cart items for the active order
    private readonly List<OrderDetail> _cart = new();
    private List<Product>              _products = new();

    public OrdersForm()
    {
        InitializeComponent();
    }

    private void OrdersForm_Load(object sender, EventArgs e)
    {
        LoadProducts();
        RefreshCart();
        txtCustomer.Text = "Walk-in";
        lblDate.Text     = $"Date: {DateTime.Now:dd-MMM-yyyy  hh:mm tt}";
    }

    // ── Product Loading ───────────────────────────────────────────────────────

    private void LoadProducts()
    {
        _products.Clear();
        cmbProduct.Items.Clear();

        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd  = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, Category, Price, Stock FROM Products WHERE Stock > 0 ORDER BY Category, Name;";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var p = new Product
                {
                    Id       = reader.GetInt32(0),
                    Name     = reader.GetString(1),
                    Category = reader.GetString(2),
                    Price    = reader.GetDouble(3),
                    Stock    = reader.GetInt32(4)
                };
                _products.Add(p);
                cmbProduct.Items.Add(p);
            }

            if (cmbProduct.Items.Count > 0)
                cmbProduct.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ── Cart Operations ───────────────────────────────────────────────────────

    private void btnAddToCart_Click(object sender, EventArgs e)
    {
        if (cmbProduct.SelectedItem is not Product selectedProduct)
        {
            MessageBox.Show("Please select a product.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
        {
            MessageBox.Show("Enter a valid quantity (1 or more).", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (qty > selectedProduct.Stock)
        {
            MessageBox.Show($"Only {selectedProduct.Stock} units available in stock.",
                "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Check if already in cart → increase quantity
        var existing = _cart.FirstOrDefault(c => c.ProductId == selectedProduct.Id);
        if (existing != null)
        {
            int newQty = existing.Quantity + qty;
            if (newQty > selectedProduct.Stock)
            {
                MessageBox.Show($"Cannot add more. Only {selectedProduct.Stock} in stock.", "Stock Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            existing.Quantity = newQty;
        }
        else
        {
            _cart.Add(new OrderDetail
            {
                ProductId   = selectedProduct.Id,
                ProductName = selectedProduct.Name,
                Quantity    = qty,
                UnitPrice   = selectedProduct.Price
            });
        }

        RefreshCart();
        txtQty.Text = "1";
    }

    private void btnRemoveItem_Click(object sender, EventArgs e)
    {
        if (dgvCart.SelectedRows.Count == 0)
        {
            MessageBox.Show("Select an item to remove.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int productId = Convert.ToInt32(dgvCart.SelectedRows[0].Cells["cartProductId"].Value);
        var item      = _cart.FirstOrDefault(c => c.ProductId == productId);
        if (item != null) _cart.Remove(item);

        RefreshCart();
    }

    private void btnClearCart_Click(object sender, EventArgs e)
    {
        if (_cart.Count == 0) return;

        var confirm = MessageBox.Show("Clear all items from cart?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm == DialogResult.Yes)
        {
            _cart.Clear();
            RefreshCart();
        }
    }

    private void RefreshCart()
    {
        dgvCart.Rows.Clear();

        foreach (var item in _cart)
        {
            dgvCart.Rows.Add(
                item.ProductId,
                item.ProductName,
                item.Quantity,
                $"Rs. {item.UnitPrice:F0}",
                $"Rs. {item.Subtotal:F0}"
            );
        }

        double total = _cart.Sum(c => c.Subtotal);
        lblTotal.Text = $"Total:  Rs. {total:F0}";
        btnPlaceOrder.Enabled = _cart.Count > 0;
    }

    // ── Place Order ───────────────────────────────────────────────────────────

    private void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        if (_cart.Count == 0)
        {
            MessageBox.Show("Cart is empty. Add products first.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string customerName = string.IsNullOrWhiteSpace(txtCustomer.Text)
            ? "Walk-in" : txtCustomer.Text.Trim();

        double totalAmount = _cart.Sum(c => c.Subtotal);

        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd  = conn.CreateCommand();

            // 1. Insert Order header
            cmd.CommandText = @"
                INSERT INTO Orders (OrderDate, CustomerName, TotalAmount, Status)
                VALUES (@d, @c, @t, 'Completed');
                SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@d", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@c", customerName);
            cmd.Parameters.AddWithValue("@t", totalAmount);
            long orderId = (long)(cmd.ExecuteScalar() ?? 0L);

            // 2. Insert each OrderDetail and update stock
            foreach (var item in _cart)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = @"
                    INSERT INTO OrderDetails (OrderId, ProductId, Quantity, UnitPrice, Subtotal)
                    VALUES (@oid, @pid, @qty, @up, @sub);";
                cmd.Parameters.AddWithValue("@oid", orderId);
                cmd.Parameters.AddWithValue("@pid", item.ProductId);
                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                cmd.Parameters.AddWithValue("@up",  item.UnitPrice);
                cmd.Parameters.AddWithValue("@sub", item.Subtotal);
                cmd.ExecuteNonQuery();

                // Reduce stock
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE Products SET Stock = Stock - @qty WHERE Id = @pid;";
                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                cmd.Parameters.AddWithValue("@pid", item.ProductId);
                cmd.ExecuteNonQuery();
            }

            // 3. Show Bill receipt
            ShowBillReceipt(orderId, customerName, totalAmount);

            // 4. Reset
            _cart.Clear();
            RefreshCart();
            txtCustomer.Text = "Walk-in";
            LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error placing order: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ShowBillReceipt(long orderId, string customer, double total)
    {
        string receipt = "╔══════════════════════════════╗\n";
        receipt       += "║    ☕ COFFEE SHOP RECEIPT     ║\n";
        receipt       += "╠══════════════════════════════╣\n";
        receipt       += $"║  Order #: {orderId,-20}║\n";
        receipt       += $"║  Customer: {customer,-19}║\n";
        receipt       += $"║  Date: {DateTime.Now:dd-MMM-yyyy HH:mm,-18}║\n";
        receipt       += "╠══════════════════════════════╣\n";
        receipt       += "║  Item               Qty  Amt ║\n";
        receipt       += "╠══════════════════════════════╣\n";

        foreach (var item in _cart)
        {
            string line = $"  {item.ProductName,-18} {item.Quantity,2}  {item.Subtotal,5:F0}";
            receipt += $"║{line,-30}║\n";
        }

        receipt += "╠══════════════════════════════╣\n";
        receipt += $"║  TOTAL:          Rs. {total,8:F0} ║\n";
        receipt += "╚══════════════════════════════╝\n";
        receipt += "\n    Thank you for your visit! ☕";

        MessageBox.Show(receipt, $"Bill - Order #{orderId}",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ── Product selection → show price ────────────────────────────────────────
    private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbProduct.SelectedItem is Product p)
            lblUnitPrice.Text = $"Price: Rs. {p.Price:F0}  |  Stock: {p.Stock}";
    }
}
