using CoffeeShopMS.Database;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

/// <summary>
/// BillingForm: View all past orders, filter by date, view order details.
/// </summary>
public partial class BillingForm : Form
{
    public BillingForm()
    {
        InitializeComponent();
    }

    private void BillingForm_Load(object sender, EventArgs e)
    {
        dtpFrom.Value = DateTime.Today.AddDays(-30);
        dtpTo.Value = DateTime.Today;
        LoadOrders();
    }

    // ── Data Loading ──────────────────────────────────────────────────────────

    private void LoadOrders()
    {
        dgvOrders.Rows.Clear();
        dgvDetails.Rows.Clear();
        lblSummary.Text = "";
        lblDetailTitle.Text = "Select an order above to view details";

        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string toDate = dtpTo.Value.ToString("yyyy-MM-dd") + " 23:59:59";

            cmd.CommandText = @"
                SELECT Id, OrderDate, CustomerName, TotalAmount, Status
                FROM Orders
                WHERE OrderDate BETWEEN @f AND @t
                ORDER BY Id DESC;";
            cmd.Parameters.AddWithValue("@f", fromDate);
            cmd.Parameters.AddWithValue("@t", toDate);

            double grandTotal = 0;
            int orderCount = 0;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                double amount = reader.GetDouble(3);
                grandTotal += amount;
                orderCount++;

                dgvOrders.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    $"Rs. {amount:F0}",
                    reader.GetString(4)
                );
            }

            lblSummary.Text = $"Orders: {orderCount}   |   Total Revenue: Rs. {grandTotal:F0}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadOrderDetails(int orderId)
    {
        dgvDetails.Rows.Clear();

        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT p.Name, od.Quantity, od.UnitPrice, od.Subtotal
                FROM OrderDetails od
                JOIN Products p ON od.ProductId = p.Id
                WHERE od.OrderId = @oid;";
            cmd.Parameters.AddWithValue("@oid", orderId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgvDetails.Rows.Add(
                    reader.GetString(0),
                    reader.GetInt32(1),
                    $"Rs. {reader.GetDouble(2):F0}",
                    $"Rs. {reader.GetDouble(3):F0}"
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading order details: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ── Event Handlers ────────────────────────────────────────────────────────

    private void btnFilter_Click(object sender, EventArgs e)
    {
        if (dtpFrom.Value > dtpTo.Value)
        {
            MessageBox.Show("'From' date cannot be after 'To' date.", "Date Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        LoadOrders();
    }

    private void btnToday_Click(object sender, EventArgs e)
    {
        dtpFrom.Value = DateTime.Today;
        dtpTo.Value = DateTime.Today;
        LoadOrders();
    }

    private void btnThisMonth_Click(object sender, EventArgs e)
    {
        dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        dtpTo.Value = DateTime.Today;
        LoadOrders();
    }

    private void dgvOrders_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvOrders.SelectedRows.Count == 0) return;

        var row = dgvOrders.SelectedRows[0];

        int orderId = Convert.ToInt32(row.Cells["colOrderId"].Value);
        string customer = row.Cells["colOrderCustomer"].Value?.ToString() ?? "";
        string total = row.Cells["colOrderTotal"].Value?.ToString() ?? "";

        lblDetailTitle.Text = $"Order #{orderId}  |  {customer}  |  {total}";
        LoadOrderDetails(orderId);
    }

    private void btnPrintBill_Click(object sender, EventArgs e)
    {
        if (dgvOrders.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select an order to print.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var row = dgvOrders.SelectedRows[0];

        int orderId = Convert.ToInt32(row.Cells["colOrderId"].Value);
        string date = row.Cells["colOrderDate"].Value?.ToString() ?? "";
        string customer = row.Cells["colOrderCustomer"].Value?.ToString() ?? "";
        string total = row.Cells["colOrderTotal"].Value?.ToString() ?? "";

        string bill = "╔══════════════════════════════╗\n";
        bill += "║    ☕ COFFEE SHOP RECEIPT     ║\n";
        bill += "╠══════════════════════════════╣\n";
        bill += $"║  Order #: {orderId,-20}║\n";
        bill += $"║  Customer: {customer,-19}║\n";
        bill += $"║  Date: {date,-23}║\n";
        bill += "╠══════════════════════════════╣\n";
        bill += "║  Item               Qty   Amt║\n";
        bill += "╠══════════════════════════════╣\n";

        foreach (DataGridViewRow detailRow in dgvDetails.Rows)
        {
            if (detailRow.IsNewRow) continue;
            string name = detailRow.Cells["colDetailItem"].Value?.ToString() ?? "";
            string qty = detailRow.Cells["colDetailQty"].Value?.ToString() ?? "";
            string sub = detailRow.Cells["colDetailSubtotal"].Value?.ToString() ?? "";
            string line = $"  {name,-18} {qty,3}  {sub,5}";
            bill += $"║{line,-30}║\n";
        }

        bill += "╠══════════════════════════════╣\n";
        bill += $"║  TOTAL:          {total,12} ║\n";
        bill += "╚══════════════════════════════╝\n";
        bill += "\n    Thank you for your visit! ☕";

        MessageBox.Show(bill, $"Bill - Order #{orderId}",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}