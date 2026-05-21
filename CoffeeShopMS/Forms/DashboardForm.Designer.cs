namespace CoffeeShopMS.Forms;

partial class DashboardForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.pnlSidebar      = new Panel();
        this.pnlLogo         = new Panel();
        this.lblLogo         = new Label();
        this.lblWelcome      = new Label();
        this.lblRole         = new Label();
        this.pnlNav          = new Panel();
        this.btnDashboard    = new Button();
        this.btnProducts     = new Button();
        this.btnNewOrder     = new Button();
        this.btnOrderHistory = new Button();
        this.btnLogout       = new Button();
        this.pnlTopBar       = new Panel();
        this.lblPageTitle    = new Label();
        this.pnlContent      = new Panel();

        this.pnlSidebar.SuspendLayout();
        this.pnlLogo.SuspendLayout();
        this.pnlNav.SuspendLayout();
        this.pnlTopBar.SuspendLayout();
        this.SuspendLayout();

        // pnlSidebar
        this.pnlSidebar.BackColor = Color.FromArgb(40, 28, 24);
        this.pnlSidebar.Controls.Add(this.pnlNav);
        this.pnlSidebar.Controls.Add(this.pnlLogo);
        this.pnlSidebar.Controls.Add(this.btnLogout);
        this.pnlSidebar.Dock  = DockStyle.Left;
        this.pnlSidebar.Width = 220;

        // pnlLogo
        this.pnlLogo.BackColor = Color.FromArgb(55, 38, 32);
        this.pnlLogo.Controls.Add(this.lblRole);
        this.pnlLogo.Controls.Add(this.lblWelcome);
        this.pnlLogo.Controls.Add(this.lblLogo);
        this.pnlLogo.Dock    = DockStyle.Top;
        this.pnlLogo.Height  = 130;
        this.pnlLogo.Padding = new Padding(10);

        // lblLogo
        this.lblLogo.Text      = "☕ CoffeeShop";
        this.lblLogo.ForeColor = Color.White;
        this.lblLogo.Font      = new Font("Segoe UI", 15F, FontStyle.Bold);
        this.lblLogo.Dock      = DockStyle.Top;
        this.lblLogo.Height    = 50;
        this.lblLogo.TextAlign = ContentAlignment.MiddleCenter;

        // lblWelcome
        this.lblWelcome.ForeColor = Color.FromArgb(210, 180, 140);
        this.lblWelcome.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.lblWelcome.Dock      = DockStyle.Top;
        this.lblWelcome.Height    = 22;
        this.lblWelcome.TextAlign = ContentAlignment.MiddleCenter;

        // lblRole
        this.lblRole.ForeColor = Color.Gray;
        this.lblRole.Font      = new Font("Segoe UI", 8F);
        this.lblRole.Dock      = DockStyle.Top;
        this.lblRole.Height    = 20;
        this.lblRole.TextAlign = ContentAlignment.MiddleCenter;

        // pnlNav
        this.pnlNav.Dock      = DockStyle.Fill;
        this.pnlNav.BackColor = Color.FromArgb(40, 28, 24);
        this.pnlNav.Padding   = new Padding(0, 10, 0, 0);
        this.pnlNav.Controls.Add(this.btnOrderHistory);
        this.pnlNav.Controls.Add(this.btnNewOrder);
        this.pnlNav.Controls.Add(this.btnProducts);
        this.pnlNav.Controls.Add(this.btnDashboard);

        // btnDashboard
        this.btnDashboard.Text      = "🏠  Dashboard";
        this.btnDashboard.Font      = new Font("Segoe UI", 10F);
        this.btnDashboard.ForeColor = Color.White;
        this.btnDashboard.BackColor = Color.Transparent;
        this.btnDashboard.FlatStyle = FlatStyle.Flat;
        this.btnDashboard.FlatAppearance.BorderSize         = 0;
        this.btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(79, 55, 48);
        this.btnDashboard.Dock      = DockStyle.Top;
        this.btnDashboard.Height    = 50;
        this.btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
        this.btnDashboard.Padding   = new Padding(20, 0, 0, 0);
        this.btnDashboard.Cursor    = Cursors.Hand;
        this.btnDashboard.Click    += new EventHandler(this.btnDashboard_Click);

        // btnProducts
        this.btnProducts.Text      = "📦  Products";
        this.btnProducts.Font      = new Font("Segoe UI", 10F);
        this.btnProducts.ForeColor = Color.White;
        this.btnProducts.BackColor = Color.Transparent;
        this.btnProducts.FlatStyle = FlatStyle.Flat;
        this.btnProducts.FlatAppearance.BorderSize         = 0;
        this.btnProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(79, 55, 48);
        this.btnProducts.Dock      = DockStyle.Top;
        this.btnProducts.Height    = 50;
        this.btnProducts.TextAlign = ContentAlignment.MiddleLeft;
        this.btnProducts.Padding   = new Padding(20, 0, 0, 0);
        this.btnProducts.Cursor    = Cursors.Hand;
        this.btnProducts.Click    += new EventHandler(this.btnProducts_Click);

        // btnNewOrder
        this.btnNewOrder.Text      = "🛒  New Order";
        this.btnNewOrder.Font      = new Font("Segoe UI", 10F);
        this.btnNewOrder.ForeColor = Color.White;
        this.btnNewOrder.BackColor = Color.Transparent;
        this.btnNewOrder.FlatStyle = FlatStyle.Flat;
        this.btnNewOrder.FlatAppearance.BorderSize         = 0;
        this.btnNewOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(79, 55, 48);
        this.btnNewOrder.Dock      = DockStyle.Top;
        this.btnNewOrder.Height    = 50;
        this.btnNewOrder.TextAlign = ContentAlignment.MiddleLeft;
        this.btnNewOrder.Padding   = new Padding(20, 0, 0, 0);
        this.btnNewOrder.Cursor    = Cursors.Hand;
        this.btnNewOrder.Click    += new EventHandler(this.btnNewOrder_Click);

        // btnOrderHistory
        this.btnOrderHistory.Text      = "📋  Order History";
        this.btnOrderHistory.Font      = new Font("Segoe UI", 10F);
        this.btnOrderHistory.ForeColor = Color.White;
        this.btnOrderHistory.BackColor = Color.Transparent;
        this.btnOrderHistory.FlatStyle = FlatStyle.Flat;
        this.btnOrderHistory.FlatAppearance.BorderSize         = 0;
        this.btnOrderHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(79, 55, 48);
        this.btnOrderHistory.Dock      = DockStyle.Top;
        this.btnOrderHistory.Height    = 50;
        this.btnOrderHistory.TextAlign = ContentAlignment.MiddleLeft;
        this.btnOrderHistory.Padding   = new Padding(20, 0, 0, 0);
        this.btnOrderHistory.Cursor    = Cursors.Hand;
        this.btnOrderHistory.Click    += new EventHandler(this.btnOrderHistory_Click);

        // btnLogout
        this.btnLogout.Text      = "🚪  Logout";
        this.btnLogout.Font      = new Font("Segoe UI", 10F);
        this.btnLogout.ForeColor = Color.FromArgb(255, 120, 100);
        this.btnLogout.BackColor = Color.Transparent;
        this.btnLogout.FlatStyle = FlatStyle.Flat;
        this.btnLogout.FlatAppearance.BorderSize = 0;
        this.btnLogout.Dock      = DockStyle.Bottom;
        this.btnLogout.Height    = 50;
        this.btnLogout.TextAlign = ContentAlignment.MiddleLeft;
        this.btnLogout.Padding   = new Padding(20, 0, 0, 0);
        this.btnLogout.Cursor    = Cursors.Hand;
        this.btnLogout.Click    += new EventHandler(this.btnLogout_Click);

        // pnlTopBar
        this.pnlTopBar.BackColor = Color.FromArgb(79, 55, 48);
        this.pnlTopBar.Controls.Add(this.lblPageTitle);
        this.pnlTopBar.Dock   = DockStyle.Top;
        this.pnlTopBar.Height = 50;

        // lblPageTitle
        this.lblPageTitle.Text      = "Coffee Shop Management System";
        this.lblPageTitle.ForeColor = Color.White;
        this.lblPageTitle.Font      = new Font("Segoe UI", 13F, FontStyle.Bold);
        this.lblPageTitle.Dock      = DockStyle.Fill;
        this.lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
        this.lblPageTitle.Padding   = new Padding(15, 0, 0, 0);

        // pnlContent
        this.pnlContent.Dock      = DockStyle.Fill;
        this.pnlContent.BackColor = Color.FromArgb(245, 240, 235);

        // DashboardForm
        this.ClientSize    = new Size(1100, 680);
        this.Text          = "Coffee Shop Management System";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.MinimumSize   = new Size(900, 600);
        this.Controls.Add(this.pnlContent);
        this.Controls.Add(this.pnlTopBar);
        this.Controls.Add(this.pnlSidebar);
        this.Load += new EventHandler(this.DashboardForm_Load);

        this.pnlSidebar.ResumeLayout(false);
        this.pnlLogo.ResumeLayout(false);
        this.pnlNav.ResumeLayout(false);
        this.pnlTopBar.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel  pnlSidebar;
    private Panel  pnlLogo;
    private Label  lblLogo;
    private Label  lblWelcome;
    private Label  lblRole;
    private Panel  pnlNav;
    private Button btnDashboard;
    private Button btnProducts;
    private Button btnNewOrder;
    private Button btnOrderHistory;
    private Button btnLogout;
    private Panel  pnlTopBar;
    private Label  lblPageTitle;
    private Panel  pnlContent;
}
