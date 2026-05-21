namespace CoffeeShopMS.Forms;

partial class OrdersForm
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
        this.pnlTop         = new Panel();
        this.lblHeader      = new Label();
        this.lblDate        = new Label();
        this.pnlLeft        = new Panel();
        this.lblOrderInfo   = new Label();
        this.lblCustomerLbl = new Label();
        this.txtCustomer    = new TextBox();
        this.lblProductLbl  = new Label();
        this.cmbProduct     = new ComboBox();
        this.lblUnitPrice   = new Label();
        this.lblQtyLbl      = new Label();
        this.txtQty         = new TextBox();
        this.btnAddToCart   = new Button();
        this.pnlRight       = new Panel();
        this.lblCartTitle   = new Label();
        this.dgvCart        = new DataGridView();
        this.pnlBottom      = new Panel();
        this.lblTotal       = new Label();
        this.btnRemoveItem  = new Button();
        this.btnClearCart   = new Button();
        this.btnPlaceOrder  = new Button();

        this.pnlTop.SuspendLayout();
        this.pnlLeft.SuspendLayout();
        this.pnlRight.SuspendLayout();
        this.pnlBottom.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.dgvCart).BeginInit();
        this.SuspendLayout();

        // ── pnlTop ───────────────────────────────────────────────────────────
        this.pnlTop.BackColor = Color.FromArgb(79, 55, 48);
        this.pnlTop.Controls.Add(this.lblDate);
        this.pnlTop.Controls.Add(this.lblHeader);
        this.pnlTop.Dock   = DockStyle.Top;
        this.pnlTop.Height = 55;

        this.lblHeader.Text      = "🛒  New Order";
        this.lblHeader.ForeColor = Color.White;
        this.lblHeader.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblHeader.Location  = new Point(15, 0);
        this.lblHeader.Size      = new Size(300, 55);
        this.lblHeader.TextAlign = ContentAlignment.MiddleLeft;

        this.lblDate.ForeColor = Color.FromArgb(210, 180, 140);
        this.lblDate.Font      = new Font("Segoe UI", 9F);
        this.lblDate.Dock      = DockStyle.Right;
        this.lblDate.Width     = 250;
        this.lblDate.TextAlign = ContentAlignment.MiddleRight;
        this.lblDate.Padding   = new Padding(0, 0, 15, 0);

        // ── pnlLeft ──────────────────────────────────────────────────────────
        this.pnlLeft.BackColor = Color.White;
        this.pnlLeft.Dock      = DockStyle.Left;
        this.pnlLeft.Width     = 280;
        this.pnlLeft.Controls.Add(this.btnAddToCart);
        this.pnlLeft.Controls.Add(this.txtQty);
        this.pnlLeft.Controls.Add(this.lblQtyLbl);
        this.pnlLeft.Controls.Add(this.lblUnitPrice);
        this.pnlLeft.Controls.Add(this.cmbProduct);
        this.pnlLeft.Controls.Add(this.lblProductLbl);
        this.pnlLeft.Controls.Add(this.txtCustomer);
        this.pnlLeft.Controls.Add(this.lblCustomerLbl);
        this.pnlLeft.Controls.Add(this.lblOrderInfo);

        this.lblOrderInfo.Text      = "Order Details";
        this.lblOrderInfo.Font      = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.lblOrderInfo.ForeColor = Color.FromArgb(79, 55, 48);
        this.lblOrderInfo.Location  = new Point(15, 15);
        this.lblOrderInfo.AutoSize  = true;

        this.lblCustomerLbl.Text     = "Customer Name";
        this.lblCustomerLbl.Font     = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.lblCustomerLbl.ForeColor= Color.FromArgb(80, 80, 80);
        this.lblCustomerLbl.Location = new Point(15, 50);
        this.lblCustomerLbl.AutoSize = true;

        this.txtCustomer.Font        = new Font("Segoe UI", 10F);
        this.txtCustomer.Location    = new Point(15, 70);
        this.txtCustomer.Size        = new Size(245, 28);
        this.txtCustomer.BorderStyle = BorderStyle.FixedSingle;

        this.lblProductLbl.Text     = "Select Product";
        this.lblProductLbl.Font     = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.lblProductLbl.ForeColor= Color.FromArgb(80, 80, 80);
        this.lblProductLbl.Location = new Point(15, 115);
        this.lblProductLbl.AutoSize = true;

        this.cmbProduct.Font          = new Font("Segoe UI", 10F);
        this.cmbProduct.Location      = new Point(15, 135);
        this.cmbProduct.Size          = new Size(245, 28);
        this.cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbProduct.SelectedIndexChanged += new EventHandler(this.cmbProduct_SelectedIndexChanged);

        this.lblUnitPrice.Text     = "Price: -";
        this.lblUnitPrice.Font     = new Font("Segoe UI", 9F, FontStyle.Italic);
        this.lblUnitPrice.ForeColor= Color.FromArgb(100, 100, 100);
        this.lblUnitPrice.Location = new Point(15, 168);
        this.lblUnitPrice.AutoSize = true;

        this.lblQtyLbl.Text     = "Quantity";
        this.lblQtyLbl.Font     = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.lblQtyLbl.ForeColor= Color.FromArgb(80, 80, 80);
        this.lblQtyLbl.Location = new Point(15, 195);
        this.lblQtyLbl.AutoSize = true;

        this.txtQty.Font        = new Font("Segoe UI", 10F);
        this.txtQty.Text        = "1";
        this.txtQty.Location    = new Point(15, 215);
        this.txtQty.Size        = new Size(245, 28);
        this.txtQty.BorderStyle = BorderStyle.FixedSingle;

        this.btnAddToCart.Text      = "➕  Add to Cart";
        this.btnAddToCart.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnAddToCart.BackColor = Color.FromArgb(79, 55, 48);
        this.btnAddToCart.ForeColor = Color.White;
        this.btnAddToCart.FlatStyle = FlatStyle.Flat;
        this.btnAddToCart.FlatAppearance.BorderSize = 0;
        this.btnAddToCart.Location  = new Point(15, 265);
        this.btnAddToCart.Size      = new Size(245, 45);
        this.btnAddToCart.Cursor    = Cursors.Hand;
        this.btnAddToCart.Click    += new EventHandler(this.btnAddToCart_Click);

        // ── pnlRight ─────────────────────────────────────────────────────────
        this.pnlRight.BackColor = Color.FromArgb(245, 240, 235);
        this.pnlRight.Dock      = DockStyle.Fill;
        this.pnlRight.Controls.Add(this.dgvCart);
        this.pnlRight.Controls.Add(this.pnlBottom);
        this.pnlRight.Controls.Add(this.lblCartTitle);

        this.lblCartTitle.Text      = "🛒  Order Cart";
        this.lblCartTitle.Font      = new Font("Segoe UI", 11F, FontStyle.Bold);
        this.lblCartTitle.ForeColor = Color.FromArgb(79, 55, 48);
        this.lblCartTitle.Dock      = DockStyle.Top;
        this.lblCartTitle.Height    = 40;
        this.lblCartTitle.TextAlign = ContentAlignment.MiddleLeft;
        this.lblCartTitle.Padding   = new Padding(10, 0, 0, 0);

        // ── dgvCart ───────────────────────────────────────────────────────────
        this.dgvCart.Dock                  = DockStyle.Fill;
        this.dgvCart.BackgroundColor       = Color.FromArgb(245, 240, 235);
        this.dgvCart.BorderStyle           = BorderStyle.None;
        this.dgvCart.RowHeadersVisible     = false;
        this.dgvCart.AllowUserToAddRows    = false;
        this.dgvCart.AllowUserToDeleteRows = false;
        this.dgvCart.ReadOnly              = true;
        this.dgvCart.SelectionMode         = DataGridViewSelectionMode.FullRowSelect;
        this.dgvCart.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvCart.Font                  = new Font("Segoe UI", 10F);
        this.dgvCart.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 55, 48);
        this.dgvCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        this.dgvCart.EnableHeadersVisualStyles = false;
        this.dgvCart.ColumnHeadersHeight   = 40;
        this.dgvCart.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 245, 242);

        this.dgvCart.Columns.Add(new DataGridViewTextBoxColumn { Name = "cartProductId",   HeaderText = "ID",           Visible = false });
        this.dgvCart.Columns.Add(new DataGridViewTextBoxColumn { Name = "cartProductName", HeaderText = "Product" });
        this.dgvCart.Columns.Add(new DataGridViewTextBoxColumn { Name = "cartQty",         HeaderText = "Qty" });
        this.dgvCart.Columns.Add(new DataGridViewTextBoxColumn { Name = "cartUnitPrice",   HeaderText = "Unit Price" });
        this.dgvCart.Columns.Add(new DataGridViewTextBoxColumn { Name = "cartSubtotal",    HeaderText = "Subtotal" });

        // ── pnlBottom ────────────────────────────────────────────────────────
        this.pnlBottom.BackColor = Color.White;
        this.pnlBottom.Dock      = DockStyle.Bottom;
        this.pnlBottom.Height    = 70;
        this.pnlBottom.Padding   = new Padding(10, 10, 10, 10);
        this.pnlBottom.Controls.Add(this.btnPlaceOrder);
        this.pnlBottom.Controls.Add(this.btnClearCart);
        this.pnlBottom.Controls.Add(this.btnRemoveItem);
        this.pnlBottom.Controls.Add(this.lblTotal);

        this.lblTotal.Text      = "Total:  Rs. 0";
        this.lblTotal.Font      = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblTotal.ForeColor = Color.FromArgb(79, 55, 48);
        this.lblTotal.Location  = new Point(10, 18);
        this.lblTotal.AutoSize  = true;

        this.btnRemoveItem.Text      = "Remove";
        this.btnRemoveItem.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.btnRemoveItem.BackColor = Color.FromArgb(200, 50, 50);
        this.btnRemoveItem.ForeColor = Color.White;
        this.btnRemoveItem.FlatStyle = FlatStyle.Flat;
        this.btnRemoveItem.FlatAppearance.BorderSize = 0;
        this.btnRemoveItem.Dock     = DockStyle.Right;
        this.btnRemoveItem.Width    = 100;
        this.btnRemoveItem.Cursor   = Cursors.Hand;
        this.btnRemoveItem.Click   += new EventHandler(this.btnRemoveItem_Click);

        this.btnClearCart.Text      = "Clear All";
        this.btnClearCart.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.btnClearCart.BackColor = Color.FromArgb(130, 130, 130);
        this.btnClearCart.ForeColor = Color.White;
        this.btnClearCart.FlatStyle = FlatStyle.Flat;
        this.btnClearCart.FlatAppearance.BorderSize = 0;
        this.btnClearCart.Dock     = DockStyle.Right;
        this.btnClearCart.Width    = 100;
        this.btnClearCart.Cursor   = Cursors.Hand;
        this.btnClearCart.Click   += new EventHandler(this.btnClearCart_Click);

        this.btnPlaceOrder.Text      = "✔  Place Order & Print Bill";
        this.btnPlaceOrder.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
        this.btnPlaceOrder.BackColor = Color.FromArgb(34, 139, 34);
        this.btnPlaceOrder.ForeColor = Color.White;
        this.btnPlaceOrder.FlatStyle = FlatStyle.Flat;
        this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
        this.btnPlaceOrder.Dock     = DockStyle.Right;
        this.btnPlaceOrder.Width    = 220;
        this.btnPlaceOrder.Cursor   = Cursors.Hand;
        this.btnPlaceOrder.Enabled  = false;
        this.btnPlaceOrder.Click   += new EventHandler(this.btnPlaceOrder_Click);

        // ── OrdersForm ────────────────────────────────────────────────────────
        this.BackColor = Color.FromArgb(245, 240, 235);
        this.Controls.Add(this.pnlRight);
        this.Controls.Add(this.pnlLeft);
        this.Controls.Add(this.pnlTop);
        this.Load += new EventHandler(this.OrdersForm_Load);

        this.pnlTop.ResumeLayout(false);
        this.pnlLeft.ResumeLayout(false);
        this.pnlRight.ResumeLayout(false);
        this.pnlBottom.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.dgvCart).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel          pnlTop;
    private Label          lblHeader;
    private Label          lblDate;
    private Panel          pnlLeft;
    private Label          lblOrderInfo;
    private Label          lblCustomerLbl;
    private TextBox        txtCustomer;
    private Label          lblProductLbl;
    private ComboBox       cmbProduct;
    private Label          lblUnitPrice;
    private Label          lblQtyLbl;
    private TextBox        txtQty;
    private Button         btnAddToCart;
    private Panel          pnlRight;
    private Label          lblCartTitle;
    private DataGridView   dgvCart;
    private Panel          pnlBottom;
    private Label          lblTotal;
    private Button         btnRemoveItem;
    private Button         btnClearCart;
    private Button         btnPlaceOrder;
}
