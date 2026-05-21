namespace CoffeeShopMS.Forms;

partial class LoginForm
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
        this.pnlMain        = new Panel();
        this.pnlHeader      = new Panel();
        this.lblTitle       = new Label();
        this.lblSubtitle    = new Label();
        this.pnlForm        = new Panel();
        this.lblUsername    = new Label();
        this.txtUsername    = new TextBox();
        this.lblPassword    = new Label();
        this.txtPassword    = new TextBox();
        this.btnLogin       = new Button();
        this.btnClear       = new Button();
        this.lblCopyright   = new Label();
        this.pnlHeader.SuspendLayout();
        this.pnlForm.SuspendLayout();
        this.pnlMain.SuspendLayout();
        this.SuspendLayout();

        // ── pnlMain ──────────────────────────────────────────────────────────
        this.pnlMain.BackColor = Color.FromArgb(245, 240, 235);
        this.pnlMain.Controls.Add(this.pnlForm);
        this.pnlMain.Controls.Add(this.pnlHeader);
        this.pnlMain.Controls.Add(this.lblCopyright);
        this.pnlMain.Dock = DockStyle.Fill;

        // ── pnlHeader ────────────────────────────────────────────────────────
        this.pnlHeader.BackColor = Color.FromArgb(79, 55, 48);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Controls.Add(this.lblSubtitle);
        this.pnlHeader.Dock = DockStyle.Top;
        this.pnlHeader.Height = 120;

        // lblTitle
        this.lblTitle.Text      = "☕ Coffee Shop ";
        this.lblTitle.ForeColor = Color.White;
        this.lblTitle.Font      = new Font("Segoe UI", 22F, FontStyle.Bold);
        this.lblTitle.AutoSize  = false;
        this.lblTitle.TextAlign = ContentAlignment.BottomCenter;
        this.lblTitle.Dock      = DockStyle.None;
        this.lblTitle.SetBounds(0, 20, 400, 50);
        this.lblTitle.Width     = 400;

        // lblSubtitle
        this.lblSubtitle.Text      = "Management System";
        this.lblSubtitle.ForeColor = Color.FromArgb(210, 180, 140);
        this.lblSubtitle.Font      = new Font("Segoe UI", 11F);
        this.lblSubtitle.AutoSize  = false;
        this.lblSubtitle.TextAlign = ContentAlignment.TopCenter;
        this.lblSubtitle.SetBounds(0, 72, 400, 30);
        this.lblSubtitle.Width     = 400;

        // ── pnlForm ──────────────────────────────────────────────────────────
        this.pnlForm.BackColor  = Color.White;
        this.pnlForm.Controls.Add(this.lblUsername);
        this.pnlForm.Controls.Add(this.txtUsername);
        this.pnlForm.Controls.Add(this.lblPassword);
        this.pnlForm.Controls.Add(this.txtPassword);
        this.pnlForm.Controls.Add(this.btnLogin);
        this.pnlForm.Controls.Add(this.btnClear);
        this.pnlForm.Size      = new Size(320, 280);
        this.pnlForm.Location  = new Point(40, 150);

        // lblUsername
        this.lblUsername.Text     = "Username";
        this.lblUsername.Font     = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.lblUsername.ForeColor= Color.FromArgb(79, 55, 48);
        this.lblUsername.Location = new Point(20, 30);
        this.lblUsername.AutoSize = true;

        // txtUsername
        this.txtUsername.Font     = new Font("Segoe UI", 11F);
        this.txtUsername.Location = new Point(20, 55);
        this.txtUsername.Size     = new Size(280, 32);
        this.txtUsername.BorderStyle = BorderStyle.FixedSingle;

        // lblPassword
        this.lblPassword.Text     = "Password";
        this.lblPassword.Font     = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.lblPassword.ForeColor= Color.FromArgb(79, 55, 48);
        this.lblPassword.Location = new Point(20, 105);
        this.lblPassword.AutoSize = true;

        // txtPassword
        this.txtPassword.Font         = new Font("Segoe UI", 11F);
        this.txtPassword.Location     = new Point(20, 130);
        this.txtPassword.Size         = new Size(280, 32);
        this.txtPassword.PasswordChar = '●';
        this.txtPassword.BorderStyle  = BorderStyle.FixedSingle;
        this.txtPassword.KeyDown     += new KeyEventHandler(this.txtPassword_KeyDown);

        // btnLogin
        this.btnLogin.Text      = "LOGIN";
        this.btnLogin.Font      = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnLogin.BackColor = Color.FromArgb(79, 55, 48);
        this.btnLogin.ForeColor = Color.White;
        this.btnLogin.FlatStyle = FlatStyle.Flat;
        this.btnLogin.FlatAppearance.BorderSize = 0;
        this.btnLogin.Location  = new Point(20, 195);
        this.btnLogin.Size      = new Size(135, 45);
        this.btnLogin.Cursor    = Cursors.Hand;
        this.btnLogin.Click    += new EventHandler(this.btnLogin_Click);

        // btnClear
        this.btnClear.Text      = "CLEAR";
        this.btnClear.Font      = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.btnClear.BackColor = Color.FromArgb(210, 180, 140);
        this.btnClear.ForeColor = Color.FromArgb(79, 55, 48);
        this.btnClear.FlatStyle = FlatStyle.Flat;
        this.btnClear.FlatAppearance.BorderSize = 0;
        this.btnClear.Location  = new Point(165, 195);
        this.btnClear.Size      = new Size(135, 45);
        this.btnClear.Cursor    = Cursors.Hand;
        this.btnClear.Click    += new EventHandler(this.btnClear_Click);

        // lblCopyright
        this.lblCopyright.Text      = "© 2024 Coffee Shop Management System";
        this.lblCopyright.ForeColor = Color.Gray;
        this.lblCopyright.Font      = new Font("Segoe UI", 9F);
        this.lblCopyright.AutoSize  = false;
        this.lblCopyright.TextAlign = ContentAlignment.MiddleCenter;
        this.lblCopyright.Dock      = DockStyle.Bottom;
        this.lblCopyright.Height    = 30;

        // ── LoginForm ────────────────────────────────────────────────────────
        this.ClientSize          = new Size(400, 500);
        this.Text                = "Coffee Shop MS - Login";
        this.StartPosition       = FormStartPosition.CenterScreen;
        this.FormBorderStyle     = FormBorderStyle.FixedSingle;
        this.MaximizeBox         = false;
        this.BackColor           = Color.FromArgb(245, 240, 235);
        this.Controls.Add(this.pnlMain);

        this.pnlHeader.ResumeLayout(false);
        this.pnlForm.ResumeLayout(false);
        this.pnlMain.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel   pnlMain;
    private Panel   pnlHeader;
    private Label   lblTitle;
    private Label   lblSubtitle;
    private Panel   pnlForm;
    private Label   lblUsername;
    private TextBox txtUsername;
    private Label   lblPassword;
    private TextBox txtPassword;
    private Button  btnLogin;
    private Button  btnClear;
    private Label   lblCopyright;
}
