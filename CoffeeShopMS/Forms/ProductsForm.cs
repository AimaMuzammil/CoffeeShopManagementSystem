using CoffeeShopMS.Database;
using CoffeeShopMS.Models;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

/// <summary>
/// ProductsForm: Add, Update, Delete coffee shop menu items.
/// </summary>
public partial class ProductsForm : Form
{
    public ProductsForm()
    {
        InitializeComponent();
    }

    private void ProductsForm_Load(object sender, EventArgs e)
    {
        LoadProducts();
        cmbCategory.Items.Clear();
        cmbCategory.Items.AddRange(new[] { "Coffee", "Tea", "Food", "Beverage", "Other" });
        cmbCategory.SelectedIndex = 0;
    }

    // ── Data Loading ──────────────────────────────────────────────────────────

    private void LoadProducts(string filter = "")
    {
        dgvProducts.Rows.Clear();

        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd  = conn.CreateCommand();

            cmd.CommandText = string.IsNullOrEmpty(filter)
                ? "SELECT Id, Name, Category, Price, Stock FROM Products ORDER BY Category, Name;"
                : "SELECT Id, Name, Category, Price, Stock FROM Products WHERE Name LIKE @f OR Category LIKE @f ORDER BY Category, Name;";

            if (!string.IsNullOrEmpty(filter))
                cmd.Parameters.AddWithValue("@f", $"%{filter}%");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgvProducts.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    $"Rs. {reader.GetDouble(3):F0}",
                    reader.GetInt32(4)
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ── CRUD Operations ───────────────────────────────────────────────────────

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd  = conn.CreateCommand();

            cmd.CommandText = @"
                INSERT INTO Products (Name, Category, Price, Stock)
                VALUES (@n, @c, @p, @s);";
            cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@c", cmbCategory.SelectedItem!.ToString());
            cmd.Parameters.AddWithValue("@p", double.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@s", int.Parse(txtStock.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Product added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding product: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a product to update.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidateInputs()) return;

        int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["colId"].Value);

        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd  = conn.CreateCommand();

            cmd.CommandText = @"
                UPDATE Products SET Name=@n, Category=@c, Price=@p, Stock=@s
                WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@n",  txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@c",  cmbCategory.SelectedItem!.ToString());
            cmd.Parameters.AddWithValue("@p",  double.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@s",  int.Parse(txtStock.Text));
            cmd.Parameters.AddWithValue("@id", productId);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Product updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating product: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a product to delete.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string productName = dgvProducts.SelectedRows[0].Cells["colName"].Value.ToString()!;
        int    productId   = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["colId"].Value);

        var confirm = MessageBox.Show($"Delete '{productName}'? This cannot be undone.",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm != DialogResult.Yes) return;

        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd  = conn.CreateCommand();

            cmd.CommandText = "DELETE FROM Products WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@id", productId);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Product deleted.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting product: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClear_Click(object sender, EventArgs e) => ClearForm();

    private void btnSearch_Click(object sender, EventArgs e)
    {
        LoadProducts(txtSearch.Text.Trim());
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        LoadProducts(txtSearch.Text.Trim());
    }

    // ── Row Selection → Fill Form ─────────────────────────────────────────────

    private void dgvProducts_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvProducts.SelectedRows.Count == 0) return;

        var row = dgvProducts.SelectedRows[0];
        txtName.Text  = row.Cells["colName"].Value.ToString();
        cmbCategory.SelectedItem = row.Cells["colCategory"].Value.ToString();

        // Price cell shows "Rs. 250" — strip prefix
        string priceRaw = row.Cells["colPrice"].Value.ToString()!.Replace("Rs. ", "");
        txtPrice.Text = priceRaw;
        txtStock.Text = row.Cells["colStock"].Value.ToString();
    }

    // ── Helpers ───────────────────────────────────────────────────────────────

    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Product name is required.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
        {
            MessageBox.Show("Enter a valid price (e.g. 250).", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
        {
            MessageBox.Show("Enter a valid stock quantity (0 or more).", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void ClearForm()
    {
        txtName.Clear();
        txtPrice.Clear();
        txtStock.Clear();
        cmbCategory.SelectedIndex = 0;
        dgvProducts.ClearSelection();
    }
}
