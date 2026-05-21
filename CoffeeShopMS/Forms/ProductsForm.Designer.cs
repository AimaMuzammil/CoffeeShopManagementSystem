namespace CoffeeShopMS.Forms;

partial class ProductsForm
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
        this.pnlTop       = new Panel();
        this.lblHeader    = new Label();
        this.pnlSearch    = new Panel();
        this.txtSearch    = new TextBox();
        this.btnSearch    = new Button();
        this.pnlLeft      = new Panel();
        this.lblFormTitle = new Label();
        this.lblName      = new Label();
        this.txtName      = new TextBox();
        this.lblCategory  = new Label();
        this.cmbCategory  = new ComboBox();
        this.lblPrice     = new Label();
        this.txtPrice     = new TextBox();
        this.lblStock     = new Label();
        this.txtStock     = new TextBox();
        this.pnlButtons   = new Panel();
        this.btnAdd       = new Button();
        this.btnUpdate    = new Button();
        this.btnDelete    = new Button();
        this.btnClear     = new Button();
        this.dgvProducts  = new DataGridView();

        this.pnlTop.SuspendLayout();
        this.pnlSearch.SuspendLayout();
        this.pnlLeft.SuspendLayout();
        this.pnlButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.dgvProducts).BeginInit();
        this.SuspendLayout();

        // pnlTop
        this.pnlTop.BackColor = Color.FromArgb(79, 55, 48);
        this.pnlTop.Controls.Add(this.lblHeader);
        this.pnlTop.Dock   = DockStyle.Top;
        this.pnlTop.Height = 55;

        // lblHeader
        this.lblHeader.Text      = "📦  Products Management";
        this.lblHeader.ForeColor = Color.White;
        this.lblHeader.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblHeader.Dock      = DockStyle.Fill;
        this.lblHeader.TextAlign = ContentAlignment.MiddleLeft;
        this.lblHeader.Padding   = new Padding(15, 0, 0, 0);

        // pnlLeft
        this.pnlLeft.BackColor = Color.White;
        this.pnlLeft.Dock      = DockStyle.Left;
        this.pnlLeft.Width     = 280;
        this.pnlLeft.Padding   = new Padding(15);
        this.pnlLeft.Controls.Add(this.pnlButtons);
        this.pnlLeft.Controls.Add(this.txtStock);
        this.pnlLeft.Controls.Add(this.lblStock);
        this.pnlLeft.Controls.Add(this.txtPrice);
        this.pnlLeft.Controls.Add(this.lblPrice);
        this.pnlLeft.Controls.Add(this.cmbCategory);
        this.pnlLeft.Controls.Add(this.lblCategory);
        this.pnlLeft.Controls.Add(this.txtName);
        this.pnlLeft.Controls.Add(this.lblName);
        this.pnlLeft.Controls.Add(this.lblFormTitle);

        // lblFormTitle
        this.lblFormTitle.Text      = "Product Details";
        this.lblFormTitle.Font      = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.lblFormTitle.ForeColor = Color.FromArgb(79, 55, 48);
        this.lblFormTitle.Location  = new Point(15, 15);
        this.lblFormTitle.AutoSize  = true;

        // lblName
        this.lblName.Text      = "Product Name *";
        this.lblName.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.lblName.ForeColor = Color.FromArgb(80, 80, 80);
        this.lblName.Location  = new Point(15, 50);
        this.lblName.AutoSize  = true;

        // txtName
        this.txtName.Font        = new Font("Segoe UI", 10F);
        this.txtName.Location    = new Point(15, 70);
        this.txtName.Size        = new Size(240, 28);
        this.txtName.BorderStyle = BorderStyle.FixedSingle;

        // lblCategory
        this.lblCategory.Text      = "Category *";
        this.lblCategory.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.lblCategory.ForeColor = Color.FromArgb(80, 80, 80);
        this.lblCategory.Location  = new Point(15, 110);
        this.lblCategory.AutoSize  = true;

        // cmbCategory
        this.cmbCategory.Font          = new Font("Segoe UI", 10F);
        this.cmbCategory.Location      = new Point(15, 130);
        this.cmbCategory.Size          = new Size(240, 28);
        this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbCategory.FlatStyle     = FlatStyle.Flat;

        // lblPrice
        this.lblPrice.Text      = "Price (Rs.) *";
        this.lblPrice.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.lblPrice.ForeColor = Color.FromArgb(80, 80, 80);
        this.lblPrice.Location  = new Point(15, 172);
        this.lblPrice.AutoSize  = true;

        // txtPrice
        this.txtPrice.Font        = new Font("Segoe UI", 10F);
        this.txtPrice.Location    = new Point(15, 192);
        this.txtPrice.Size        = new Size(240, 28);
        this.txtPrice.BorderStyle = BorderStyle.FixedSingle;

        // lblStock
        this.lblStock.Text      = "Stock Quantity *";
        this.lblStock.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.lblStock.ForeColor = Color.FromArgb(80, 80, 80);
        this.lblStock.Location  = new Point(15, 232);
        this.lblStock.AutoSize  = true;

        // txtStock
        this.txtStock.Font        = new Font("Segoe UI", 10F);
        this.txtStock.Location    = new Point(15, 252);
        this.txtStock.Size        = new Size(240, 28);
        this.txtStock.BorderStyle = BorderStyle.FixedSingle;

        // pnlButtons
        this.pnlButtons.Location = new Point(15, 300);
        this.pnlButtons.Size     = new Size(245, 120);
        this.pnlButtons.Controls.Add(this.btnAdd);
        this.pnlButtons.Controls.Add(this.btnUpdate);
        this.pnlButtons.Controls.Add(this.btnDelete);
        this.pnlButtons.Controls.Add(this.btnClear);

        // btnAdd
        this.btnAdd.Text      = "Add";
        this.btnAdd.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.btnAdd.BackColor = Color.FromArgb(34, 139, 34);
        this.btnAdd.ForeColor = Color.White;
        this.btnAdd.FlatStyle = FlatStyle.Flat;
        this.btnAdd.FlatAppearance.BorderSize = 0;
        this.btnAdd.Location  = new Point(0, 0);
        this.btnAdd.Size      = new Size(110, 40);
        this.btnAdd.Cursor    = Cursors.Hand;
        this.btnAdd.Click    += new EventHandler(this.btnAdd_Click);

        // btnUpdate
        this.btnUpdate.Text      = "Update";
        this.btnUpdate.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.btnUpdate.BackColor = Color.FromArgb(30, 100, 200);
        this.btnUpdate.ForeColor = Color.White;
        this.btnUpdate.FlatStyle = FlatStyle.Flat;
        this.btnUpdate.FlatAppearance.BorderSize = 0;
        this.btnUpdate.Location  = new Point(125, 0);
        this.btnUpdate.Size      = new Size(110, 40);
        this.btnUpdate.Cursor    = Cursors.Hand;
        this.btnUpdate.Click    += new EventHandler(this.btnUpdate_Click);

        // btnDelete
        this.btnDelete.Text      = "Delete";
        this.btnDelete.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.btnDelete.BackColor = Color.FromArgb(200, 50, 50);
        this.btnDelete.ForeColor = Color.White;
        this.btnDelete.FlatStyle = FlatStyle.Flat;
        this.btnDelete.FlatAppearance.BorderSize = 0;
        this.btnDelete.Location  = new Point(0, 55);
        this.btnDelete.Size      = new Size(110, 40);
        this.btnDelete.Cursor    = Cursors.Hand;
        this.btnDelete.Click    += new EventHandler(this.btnDelete_Click);

        // btnClear
        this.btnClear.Text      = "Clear";
        this.btnClear.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.btnClear.BackColor = Color.FromArgb(130, 130, 130);
        this.btnClear.ForeColor = Color.White;
        this.btnClear.FlatStyle = FlatStyle.Flat;
        this.btnClear.FlatAppearance.BorderSize = 0;
        this.btnClear.Location  = new Point(125, 55);
        this.btnClear.Size      = new Size(110, 40);
        this.btnClear.Cursor    = Cursors.Hand;
        this.btnClear.Click    += new EventHandler(this.btnClear_Click);

        // pnlSearch
        this.pnlSearch.BackColor = Color.FromArgb(245, 240, 235);
        this.pnlSearch.Dock      = DockStyle.Top;
        this.pnlSearch.Height    = 50;
        this.pnlSearch.Padding   = new Padding(10, 8, 10, 0);
        this.pnlSearch.Controls.Add(this.btnSearch);
        this.pnlSearch.Controls.Add(this.txtSearch);

        // txtSearch
        this.txtSearch.Font            = new Font("Segoe UI", 10F);
        this.txtSearch.Location        = new Point(10, 10);
        this.txtSearch.Size            = new Size(300, 28);
        this.txtSearch.BorderStyle     = BorderStyle.FixedSingle;
        this.txtSearch.PlaceholderText = "Search by name or category...";
        this.txtSearch.TextChanged    += new EventHandler(this.txtSearch_TextChanged);

        // btnSearch
        this.btnSearch.Text      = "Search";
        this.btnSearch.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.btnSearch.BackColor = Color.FromArgb(79, 55, 48);
        this.btnSearch.ForeColor = Color.White;
        this.btnSearch.FlatStyle = FlatStyle.Flat;
        this.btnSearch.FlatAppearance.BorderSize = 0;
        this.btnSearch.Location  = new Point(318, 10);
        this.btnSearch.Size      = new Size(80, 28);
        this.btnSearch.Cursor    = Cursors.Hand;
        this.btnSearch.Click    += new EventHandler(this.btnSearch_Click);

        // dgvProducts
        this.dgvProducts.Dock                  = DockStyle.Fill;
        this.dgvProducts.BackgroundColor       = Color.FromArgb(245, 240, 235);
        this.dgvProducts.BorderStyle           = BorderStyle.None;
        this.dgvProducts.RowHeadersVisible     = false;
        this.dgvProducts.AllowUserToAddRows    = false;
        this.dgvProducts.AllowUserToDeleteRows = false;
        this.dgvProducts.ReadOnly              = true;
        this.dgvProducts.SelectionMode         = DataGridViewSelectionMode.FullRowSelect;
        this.dgvProducts.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvProducts.Font                  = new Font("Segoe UI", 10F);
        this.dgvProducts.ColumnHeadersHeight   = 40;
        this.dgvProducts.EnableHeadersVisualStyles = false;
        this.dgvProducts.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 55, 48);
        this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        this.dgvProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(79, 55, 48);
        this.dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 245, 242);
        this.dgvProducts.SelectionChanged += new EventHandler(this.dgvProducts_SelectionChanged);

        this.dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId",       HeaderText = "ID",           Visible = false });
        this.dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName",     HeaderText = "Product Name" });
        this.dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCategory", HeaderText = "Category" });
        this.dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPrice",    HeaderText = "Price" });
        this.dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStock",    HeaderText = "Stock" });

        // ProductsForm
        this.BackColor = Color.FromArgb(245, 240, 235);
        this.Controls.Add(this.dgvProducts);
        this.Controls.Add(this.pnlSearch);
        this.Controls.Add(this.pnlLeft);
        this.Controls.Add(this.pnlTop);
        this.Load += new EventHandler(this.ProductsForm_Load);

        this.pnlTop.ResumeLayout(false);
        this.pnlSearch.ResumeLayout(false);
        this.pnlLeft.ResumeLayout(false);
        this.pnlButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.dgvProducts).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel              pnlTop;
    private Label              lblHeader;
    private Panel              pnlSearch;
    private TextBox            txtSearch;
    private Button             btnSearch;
    private Panel              pnlLeft;
    private Label              lblFormTitle;
    private Label              lblName;
    private TextBox            txtName;
    private Label              lblCategory;
    private ComboBox           cmbCategory;
    private Label              lblPrice;
    private TextBox            txtPrice;
    private Label              lblStock;
    private TextBox            txtStock;
    private Panel              pnlButtons;
    private Button             btnAdd;
    private Button             btnUpdate;
    private Button             btnDelete;
    private Button             btnClear;
    private DataGridView       dgvProducts;
}
