namespace CoffeeShopMS.Forms;

partial class BillingForm
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        pnlTop = new Panel();
        lblHeader = new Label();
        pnlFilter = new Panel();
        lblSummary = new Label();
        btnThisMonth = new Button();
        btnToday = new Button();
        btnFilter = new Button();
        dtpTo = new DateTimePicker();
        lblTo = new Label();
        dtpFrom = new DateTimePicker();
        lblFrom = new Label();
        pnlOrders = new Panel();
        dgvOrders = new DataGridView();
        colOrderId = new DataGridViewTextBoxColumn();
        colOrderDate = new DataGridViewTextBoxColumn();
        colOrderCustomer = new DataGridViewTextBoxColumn();
        colOrderTotal = new DataGridViewTextBoxColumn();
        colOrderStatus = new DataGridViewTextBoxColumn();
        pnlDetailsArea = new Panel();
        dgvDetails = new DataGridView();
        colDetailItem = new DataGridViewTextBoxColumn();
        colDetailQty = new DataGridViewTextBoxColumn();
        colDetailUnitPrice = new DataGridViewTextBoxColumn();
        colDetailSubtotal = new DataGridViewTextBoxColumn();
        btnPrintBill = new Button();
        lblDetailTitle = new Label();
        pnlTop.SuspendLayout();
        pnlFilter.SuspendLayout();
        pnlOrders.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
        pnlDetailsArea.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.FromArgb(79, 55, 48);
        pnlTop.Controls.Add(lblHeader);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(284, 55);
        pnlTop.TabIndex = 3;
        // 
        // lblHeader
        // 
        lblHeader.Dock = DockStyle.Fill;
        lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblHeader.ForeColor = Color.White;
        lblHeader.Location = new Point(0, 0);
        lblHeader.Name = "lblHeader";
        lblHeader.Padding = new Padding(15, 0, 0, 0);
        lblHeader.Size = new Size(284, 55);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "📋  Order History & Billing";
        lblHeader.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlFilter
        // 
        pnlFilter.BackColor = Color.White;
        pnlFilter.Controls.Add(lblSummary);
        pnlFilter.Controls.Add(btnThisMonth);
        pnlFilter.Controls.Add(btnToday);
        pnlFilter.Controls.Add(btnFilter);
        pnlFilter.Controls.Add(dtpTo);
        pnlFilter.Controls.Add(lblTo);
        pnlFilter.Controls.Add(dtpFrom);
        pnlFilter.Controls.Add(lblFrom);
        pnlFilter.Dock = DockStyle.Top;
        pnlFilter.Location = new Point(0, 55);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Padding = new Padding(10, 10, 10, 5);
        pnlFilter.Size = new Size(284, 65);
        pnlFilter.TabIndex = 2;
        // 
        // lblSummary
        // 
        lblSummary.AutoSize = true;
        lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblSummary.ForeColor = Color.FromArgb(34, 139, 34);
        lblSummary.Location = new Point(680, 18);
        lblSummary.Name = "lblSummary";
        lblSummary.Size = new Size(0, 19);
        lblSummary.TabIndex = 0;
        // 
        // btnThisMonth
        // 
        btnThisMonth.BackColor = Color.FromArgb(130, 100, 60);
        btnThisMonth.Cursor = Cursors.Hand;
        btnThisMonth.FlatAppearance.BorderSize = 0;
        btnThisMonth.FlatStyle = FlatStyle.Flat;
        btnThisMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnThisMonth.ForeColor = Color.White;
        btnThisMonth.Location = new Point(580, 12);
        btnThisMonth.Name = "btnThisMonth";
        btnThisMonth.Size = new Size(90, 30);
        btnThisMonth.TabIndex = 1;
        btnThisMonth.Text = "This Month";
        btnThisMonth.UseVisualStyleBackColor = false;
        btnThisMonth.Click += btnThisMonth_Click;
        // 
        // btnToday
        // 
        btnToday.BackColor = Color.FromArgb(30, 100, 200);
        btnToday.Cursor = Cursors.Hand;
        btnToday.FlatAppearance.BorderSize = 0;
        btnToday.FlatStyle = FlatStyle.Flat;
        btnToday.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnToday.ForeColor = Color.White;
        btnToday.Location = new Point(480, 12);
        btnToday.Name = "btnToday";
        btnToday.Size = new Size(90, 30);
        btnToday.TabIndex = 2;
        btnToday.Text = "Today";
        btnToday.UseVisualStyleBackColor = false;
        btnToday.Click += btnToday_Click;
        // 
        // btnFilter
        // 
        btnFilter.BackColor = Color.FromArgb(79, 55, 48);
        btnFilter.Cursor = Cursors.Hand;
        btnFilter.FlatAppearance.BorderSize = 0;
        btnFilter.FlatStyle = FlatStyle.Flat;
        btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnFilter.ForeColor = Color.White;
        btnFilter.Location = new Point(380, 12);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(90, 30);
        btnFilter.TabIndex = 3;
        btnFilter.Text = "Filter";
        btnFilter.UseVisualStyleBackColor = false;
        btnFilter.Click += btnFilter_Click;
        // 
        // dtpTo
        // 
        dtpTo.Font = new Font("Segoe UI", 9F);
        dtpTo.Format = DateTimePickerFormat.Short;
        dtpTo.Location = new Point(230, 14);
        dtpTo.Name = "dtpTo";
        dtpTo.Size = new Size(140, 23);
        dtpTo.TabIndex = 4;
        // 
        // lblTo
        // 
        lblTo.AutoSize = true;
        lblTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTo.ForeColor = Color.FromArgb(79, 55, 48);
        lblTo.Location = new Point(205, 18);
        lblTo.Name = "lblTo";
        lblTo.Size = new Size(23, 15);
        lblTo.TabIndex = 5;
        lblTo.Text = "To:";
        // 
        // dtpFrom
        // 
        dtpFrom.Font = new Font("Segoe UI", 9F);
        dtpFrom.Format = DateTimePickerFormat.Short;
        dtpFrom.Location = new Point(55, 14);
        dtpFrom.Name = "dtpFrom";
        dtpFrom.Size = new Size(140, 23);
        dtpFrom.TabIndex = 6;
        // 
        // lblFrom
        // 
        lblFrom.AutoSize = true;
        lblFrom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblFrom.ForeColor = Color.FromArgb(79, 55, 48);
        lblFrom.Location = new Point(10, 18);
        lblFrom.Name = "lblFrom";
        lblFrom.Size = new Size(39, 15);
        lblFrom.TabIndex = 7;
        lblFrom.Text = "From:";
        // 
        // pnlOrders
        // 
        pnlOrders.BackColor = Color.FromArgb(245, 240, 235);
        pnlOrders.Controls.Add(dgvOrders);
        pnlOrders.Dock = DockStyle.Top;
        pnlOrders.Location = new Point(0, 120);
        pnlOrders.Name = "pnlOrders";
        pnlOrders.Size = new Size(284, 280);
        pnlOrders.TabIndex = 1;
        // 
        // dgvOrders
        // 
        dgvOrders.AllowUserToAddRows = false;
        dgvOrders.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 245, 242);
        dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOrders.BackgroundColor = Color.FromArgb(245, 240, 235);
        dgvOrders.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(79, 55, 48);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvOrders.ColumnHeadersHeight = 40;
        dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colOrderDate, colOrderCustomer, colOrderTotal, colOrderStatus });
        dgvOrders.Dock = DockStyle.Fill;
        dgvOrders.EnableHeadersVisualStyles = false;
        dgvOrders.Font = new Font("Segoe UI", 10F);
        dgvOrders.Location = new Point(0, 0);
        dgvOrders.Name = "dgvOrders";
        dgvOrders.ReadOnly = true;
        dgvOrders.RowHeadersVisible = false;
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOrders.Size = new Size(284, 280);
        dgvOrders.TabIndex = 0;
        dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
        // 
        // colOrderId
        // 
        colOrderId.HeaderText = "ID";
        colOrderId.Name = "colOrderId";
        colOrderId.ReadOnly = true;
        colOrderId.Visible = false;
        // 
        // colOrderDate
        // 
        colOrderDate.HeaderText = "Date";
        colOrderDate.Name = "colOrderDate";
        colOrderDate.ReadOnly = true;
        // 
        // colOrderCustomer
        // 
        colOrderCustomer.HeaderText = "Customer";
        colOrderCustomer.Name = "colOrderCustomer";
        colOrderCustomer.ReadOnly = true;
        // 
        // colOrderTotal
        // 
        colOrderTotal.HeaderText = "Total";
        colOrderTotal.Name = "colOrderTotal";
        colOrderTotal.ReadOnly = true;
        // 
        // colOrderStatus
        // 
        colOrderStatus.HeaderText = "Status";
        colOrderStatus.Name = "colOrderStatus";
        colOrderStatus.ReadOnly = true;
        // 
        // pnlDetailsArea
        // 
        pnlDetailsArea.BackColor = Color.FromArgb(245, 240, 235);
        pnlDetailsArea.Controls.Add(dgvDetails);
        pnlDetailsArea.Controls.Add(btnPrintBill);
        pnlDetailsArea.Controls.Add(lblDetailTitle);
        pnlDetailsArea.Dock = DockStyle.Fill;
        pnlDetailsArea.Location = new Point(0, 400);
        pnlDetailsArea.Name = "pnlDetailsArea";
        pnlDetailsArea.Size = new Size(284, 0);
        pnlDetailsArea.TabIndex = 0;
        // 
        // dgvDetails
        // 
        dgvDetails.AllowUserToAddRows = false;
        dgvDetails.AllowUserToDeleteRows = false;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 245, 242);
        dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
        dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDetails.BackgroundColor = Color.FromArgb(245, 240, 235);
        dgvDetails.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(130, 100, 60);
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle4.ForeColor = Color.White;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvDetails.ColumnHeadersHeight = 35;
        dgvDetails.Columns.AddRange(new DataGridViewColumn[] { colDetailItem, colDetailQty, colDetailUnitPrice, colDetailSubtotal });
        dgvDetails.Dock = DockStyle.Fill;
        dgvDetails.EnableHeadersVisualStyles = false;
        dgvDetails.Font = new Font("Segoe UI", 10F);
        dgvDetails.Location = new Point(0, 35);
        dgvDetails.Name = "dgvDetails";
        dgvDetails.ReadOnly = true;
        dgvDetails.RowHeadersVisible = false;
        dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDetails.Size = new Size(284, 0);
        dgvDetails.TabIndex = 0;
        // 
        // colDetailItem
        // 
        colDetailItem.HeaderText = "Item";
        colDetailItem.Name = "colDetailItem";
        colDetailItem.ReadOnly = true;
        // 
        // colDetailQty
        // 
        colDetailQty.HeaderText = "Qty";
        colDetailQty.Name = "colDetailQty";
        colDetailQty.ReadOnly = true;
        // 
        // colDetailUnitPrice
        // 
        colDetailUnitPrice.HeaderText = "Unit Price";
        colDetailUnitPrice.Name = "colDetailUnitPrice";
        colDetailUnitPrice.ReadOnly = true;
        // 
        // colDetailSubtotal
        // 
        colDetailSubtotal.HeaderText = "Subtotal";
        colDetailSubtotal.Name = "colDetailSubtotal";
        colDetailSubtotal.ReadOnly = true;
        // 
        // btnPrintBill
        // 
        btnPrintBill.BackColor = Color.FromArgb(79, 55, 48);
        btnPrintBill.Cursor = Cursors.Hand;
        btnPrintBill.Dock = DockStyle.Bottom;
        btnPrintBill.FlatAppearance.BorderSize = 0;
        btnPrintBill.FlatStyle = FlatStyle.Flat;
        btnPrintBill.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnPrintBill.ForeColor = Color.White;
        btnPrintBill.Location = new Point(0, -45);
        btnPrintBill.Name = "btnPrintBill";
        btnPrintBill.Size = new Size(284, 45);
        btnPrintBill.TabIndex = 1;
        btnPrintBill.Text = "🖨  Print / View Bill";
        btnPrintBill.UseVisualStyleBackColor = false;
        btnPrintBill.Click += btnPrintBill_Click;
        // 
        // lblDetailTitle
        // 
        lblDetailTitle.Dock = DockStyle.Top;
        lblDetailTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblDetailTitle.ForeColor = Color.FromArgb(79, 55, 48);
        lblDetailTitle.Location = new Point(0, 0);
        lblDetailTitle.Name = "lblDetailTitle";
        lblDetailTitle.Padding = new Padding(10, 0, 0, 0);
        lblDetailTitle.Size = new Size(284, 35);
        lblDetailTitle.TabIndex = 2;
        lblDetailTitle.Text = "Select an order above to view details";
        lblDetailTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // BillingForm
        // 
        BackColor = Color.FromArgb(245, 240, 235);
        ClientSize = new Size(284, 261);
        Controls.Add(pnlDetailsArea);
        Controls.Add(pnlOrders);
        Controls.Add(pnlFilter);
        Controls.Add(pnlTop);
        Name = "BillingForm";
        Load += BillingForm_Load;
        pnlTop.ResumeLayout(false);
        pnlFilter.ResumeLayout(false);
        pnlFilter.PerformLayout();
        pnlOrders.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
        pnlDetailsArea.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlTop;
    private Label lblHeader;
    private Panel pnlFilter;
    private Label lblFrom;
    private DateTimePicker dtpFrom;
    private Label lblTo;
    private DateTimePicker dtpTo;
    private Button btnFilter;
    private Button btnToday;
    private Button btnThisMonth;
    private Label lblSummary;
    private Panel pnlOrders;
    private DataGridView dgvOrders;
    private Panel pnlDetailsArea;
    private Label lblDetailTitle;
    private DataGridView dgvDetails;
    private Button btnPrintBill;

    // dgvOrders columns
    private DataGridViewTextBoxColumn colOrderId;
    private DataGridViewTextBoxColumn colOrderDate;
    private DataGridViewTextBoxColumn colOrderCustomer;
    private DataGridViewTextBoxColumn colOrderTotal;
    private DataGridViewTextBoxColumn colOrderStatus;

    // dgvDetails columns
    private DataGridViewTextBoxColumn colDetailItem;
    private DataGridViewTextBoxColumn colDetailQty;
    private DataGridViewTextBoxColumn colDetailUnitPrice;
    private DataGridViewTextBoxColumn colDetailSubtotal;
}