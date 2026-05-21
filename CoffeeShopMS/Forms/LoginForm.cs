using CoffeeShopMS.Database;
using CoffeeShopMS.Models;
using System.Data.SQLite;

namespace CoffeeShopMS.Forms;

/// <summary>
/// LoginForm: Authenticates users using BCrypt password verification.
/// </summary>
public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    // ── Event Handlers ────────────────────────────────────────────────────────

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.",
                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        User? user = AuthenticateUser(username, password);

        if (user != null)
        {
            this.Hide();
            var dashboard = new DashboardForm(user);
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
        }
        else
        {
            MessageBox.Show("Invalid username or password. Please try again.",
                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
            txtPassword.Focus();
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtUsername.Clear();
        txtPassword.Clear();
        txtUsername.Focus();
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            btnLogin_Click(sender, e);
    }

    // ── Business Logic ────────────────────────────────────────────────────────

    private static User? AuthenticateUser(string username, string password)
    {
        try
        {
            using var conn = DBHelper.GetConnection();
            using var cmd  = conn.CreateCommand();

            cmd.CommandText = "SELECT Id, Username, Password, Role FROM Users WHERE Username = @u;";
            cmd.Parameters.AddWithValue("@u", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string storedHash = reader.GetString(2);

                // BCrypt verification — never compare plain text
                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                {
                    return new User
                    {
                        Id       = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = storedHash,
                        Role     = reader.GetString(3)
                    };
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Database error: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return null;
    }
}
