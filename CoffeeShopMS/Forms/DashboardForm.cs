using CoffeeShopMS.Models;

namespace CoffeeShopMS.Forms;

public partial class DashboardForm : Form
{
    private readonly User _currentUser;
    private Form? _activeChildForm;
    private Button? _activeNavBtn;

    public DashboardForm(User user)
    {
        _currentUser = user;
        InitializeComponent();
        ApplyUserInfo();
    }

    private void ApplyUserInfo()
    {
        lblWelcome.Text = $"Welcome, {_currentUser.Username}!";
        lblRole.Text = $"Role: {_currentUser.Role}";
    }

    // ── Navigation ────────────────────────────────────────────────────────────

    private void btnDashboard_Click(object sender, EventArgs e)
    {
        SetActiveButton(btnDashboard);
        ShowChildForm(null);
        pnlContent.Controls.Clear();
        ShowHomePanel();
    }

    private void btnProducts_Click(object sender, EventArgs e)
    {
        SetActiveButton(btnProducts);
        OpenChildForm(new ProductsForm());
    }

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
        SetActiveButton(btnNewOrder);
        OpenChildForm(new OrdersForm());
    }

    private void btnOrderHistory_Click(object sender, EventArgs e)
    {
        SetActiveButton(btnOrderHistory);
        OpenChildForm(new BillingForm());
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Are you sure you want to logout?",
            "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            new LoginForm().Show();
            this.Close();
        }
    }

    // ── Active Button Highlight ───────────────────────────────────────────────

    private void SetActiveButton(Button btn)
    {
        // Reset previous
        if (_activeNavBtn != null)
        {
            _activeNavBtn.BackColor = Color.Transparent;
            _activeNavBtn.ForeColor = Color.White;
        }

        // Highlight new
        btn.BackColor = Color.FromArgb(79, 55, 48);
        btn.ForeColor = Color.White;
        _activeNavBtn = btn;
    }

    // ── Child Form Management ─────────────────────────────────────────────────

    private void OpenChildForm(Form childForm)
    {
        _activeChildForm?.Close();
        _activeChildForm = childForm;

        pnlContent.Controls.Clear();

        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        pnlContent.Controls.Add(childForm);
        childForm.BringToFront();
        childForm.Show();
    }

    private void ShowChildForm(Form? form)
    {
        _activeChildForm?.Close();
        _activeChildForm = form;
    }

    // ── Home Panel ────────────────────────────────────────────────────────────

    private void ShowHomePanel()
    {
        var pnl = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(245, 240, 235) };

        // ── Welcome label ──
        var lblGreet = new Label
        {
            Text = $"☕  Good Day, {_currentUser.Username}!",
            Font = new Font("Segoe UI", 18F, FontStyle.Bold),
            ForeColor = Color.FromArgb(79, 55, 48),
            AutoSize = true,
            Location = new Point(40, 30)
        };

        var lblSub = new Label
        {
            Text = "Here's a quick overview of your Coffee Shop.",
            Font = new Font("Segoe UI", 10F),
            ForeColor = Color.Gray,
            AutoSize = true,
            Location = new Point(42, 68)
        };

        // ── Stats cards ──
        var cardPanel = new FlowLayoutPanel
        {
            Location = new Point(40, 110),
            Size = new Size(820, 160),
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            BackColor = Color.Transparent
        };

        cardPanel.Controls.Add(MakeCard("📦 Products", GetProductCount(), Color.FromArgb(79, 55, 48)));
        cardPanel.Controls.Add(MakeCard("🛒 Today's Orders", GetTodayOrders(), Color.FromArgb(120, 80, 60)));
        cardPanel.Controls.Add(MakeCard("💰 Total Revenue", GetTotalRevenue(), Color.FromArgb(160, 100, 70)));

        // ── Quick tip ──
        var lblTip = new Label
        {
            Text = "💡  Use the sidebar to manage Products, create New Orders, and view Order History.",
            Font = new Font("Segoe UI", 10F),
            ForeColor = Color.FromArgb(120, 100, 90),
            AutoSize = false,
            Size = new Size(820, 30),
            Location = new Point(40, 290),
            TextAlign = ContentAlignment.MiddleLeft
        };

        pnl.Controls.Add(lblGreet);
        pnl.Controls.Add(lblSub);
        pnl.Controls.Add(cardPanel);
        pnl.Controls.Add(lblTip);

        pnlContent.Controls.Add(pnl);
    }

    private static Panel MakeCard(string title, string value, Color color)
    {
        var card = new Panel
        {
            Size = new Size(200, 120),
            BackColor = color,
            Margin = new Padding(0, 0, 20, 0)
        };

        // Rounded feel via padding
        var lblTitle = new Label
        {
            Text = title,
            Font = new Font("Segoe UI", 10F),
            ForeColor = Color.FromArgb(220, 200, 180),
            AutoSize = false,
            Size = new Size(180, 30),
            Location = new Point(15, 18),
            TextAlign = ContentAlignment.MiddleLeft
        };

        var lblValue = new Label
        {
            Text = value,
            Font = new Font("Segoe UI", 22F, FontStyle.Bold),
            ForeColor = Color.White,
            AutoSize = false,
            Size = new Size(180, 50),
            Location = new Point(15, 55),
            TextAlign = ContentAlignment.MiddleLeft
        };

        card.Controls.Add(lblTitle);
        card.Controls.Add(lblValue);
        return card;
    }

    // ── Stats Helpers (Database se lena chahein to replace karo) ─────────────

    private static string GetProductCount()
    {
        try
        {
            using var conn = Database.DBHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Products;";
            return cmd.ExecuteScalar()?.ToString() ?? "0";
        }
        catch { return "—"; }
    }

    private static string GetTodayOrders()
    {
        try
        {
            using var conn = Database.DBHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Orders WHERE DATE(CreatedAt) = DATE('now');";
            return cmd.ExecuteScalar()?.ToString() ?? "0";
        }
        catch { return "—"; }
    }

    private static string GetTotalRevenue()
    {
        try
        {
            using var conn = Database.DBHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COALESCE(SUM(TotalAmount), 0) FROM Orders;";
            var val = cmd.ExecuteScalar();
            return $"Rs {Convert.ToDecimal(val):N0}";
        }
        catch { return "—"; }
    }

    private void DashboardForm_Load(object sender, EventArgs e)
    {
        SetActiveButton(btnDashboard);
        ShowHomePanel();
    }
}