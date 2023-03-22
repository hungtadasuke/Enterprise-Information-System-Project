namespace GUI
{
    partial class frmBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnExit = new GUI.HRJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new GUI.HRJButton();
            this.btnSearch = new GUI.HRJButton();
            this.txtPriceTo = new GUI.HRJTextBox();
            this.txtPriceFrom = new GUI.HRJTextBox();
            this.txtBillID = new GUI.HRJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblConnect = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBillDetail = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinglePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new GUI.HRJButton();
            this.btnPrint = new GUI.HRJButton();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.panel3.Controls.Add(this.txtStaffID);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1334, 119);
            this.panel3.TabIndex = 5;
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.ForeColor = System.Drawing.Color.White;
            this.txtStaffID.Location = new System.Drawing.Point(33, 9);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(137, 19);
            this.txtStaffID.TabIndex = 26;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::GUI.Properties.Resources.icons8_home_page_32;
            this.btnExit.Location = new System.Drawing.Point(1262, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 41);
            this.btnExit.TabIndex = 25;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(547, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(378, 54);
            this.label9.TabIndex = 3;
            this.label9.Text = "Danh Sách Hóa Đơn";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(674, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 19);
            this.linkLabel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtPriceTo);
            this.panel4.Controls.Add(this.txtPriceFrom);
            this.panel4.Controls.Add(this.txtBillID);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.DateFrom);
            this.panel4.Controls.Add(this.DateTo);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtDate);
            this.panel4.Controls.Add(this.lblLine1);
            this.panel4.Controls.Add(this.lblConnect);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1334, 62);
            this.panel4.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnClear.BorderColor = System.Drawing.Color.Black;
            this.btnClear.BorderRadius = 8;
            this.btnClear.BorderSize = 1;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1096, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 39);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Tải lại";
            this.btnClear.TextColor = System.Drawing.Color.Black;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1005, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 39);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPriceTo
            // 
            this.txtPriceTo.BackColor = System.Drawing.Color.White;
            this.txtPriceTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtPriceTo.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtPriceTo.BorderRadius = 0;
            this.txtPriceTo.BorderSize = 2;
            this.txtPriceTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceTo.ForeColor = System.Drawing.Color.DimGray;
            this.txtPriceTo.Location = new System.Drawing.Point(550, 16);
            this.txtPriceTo.Multiline = false;
            this.txtPriceTo.Name = "txtPriceTo";
            this.txtPriceTo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPriceTo.PasswordChar = false;
            this.txtPriceTo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceTo.PlaceholderText = "Đến";
            this.txtPriceTo.Size = new System.Drawing.Size(126, 38);
            this.txtPriceTo.TabIndex = 33;
            this.txtPriceTo.UnderlineStyle = false;
            this.txtPriceTo._TextChanged += new System.EventHandler(this.txtPriceTo__TextChanged);
            // 
            // txtPriceFrom
            // 
            this.txtPriceFrom.BackColor = System.Drawing.Color.White;
            this.txtPriceFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtPriceFrom.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtPriceFrom.BorderRadius = 0;
            this.txtPriceFrom.BorderSize = 2;
            this.txtPriceFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceFrom.ForeColor = System.Drawing.Color.DimGray;
            this.txtPriceFrom.Location = new System.Drawing.Point(388, 16);
            this.txtPriceFrom.Multiline = false;
            this.txtPriceFrom.Name = "txtPriceFrom";
            this.txtPriceFrom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPriceFrom.PasswordChar = false;
            this.txtPriceFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceFrom.PlaceholderText = "Từ";
            this.txtPriceFrom.Size = new System.Drawing.Size(126, 38);
            this.txtPriceFrom.TabIndex = 32;
            this.txtPriceFrom.UnderlineStyle = false;
            this.txtPriceFrom._TextChanged += new System.EventHandler(this.txtPriceForm__TextChanged);
            // 
            // txtBillID
            // 
            this.txtBillID.BackColor = System.Drawing.Color.White;
            this.txtBillID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtBillID.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtBillID.BorderRadius = 0;
            this.txtBillID.BorderSize = 2;
            this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillID.ForeColor = System.Drawing.Color.DimGray;
            this.txtBillID.Location = new System.Drawing.Point(183, 16);
            this.txtBillID.Multiline = false;
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBillID.PasswordChar = false;
            this.txtBillID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBillID.PlaceholderText = "Mã hóa đơn";
            this.txtBillID.Size = new System.Drawing.Size(134, 38);
            this.txtBillID.TabIndex = 31;
            this.txtBillID.UnderlineStyle = false;
            this.txtBillID._TextChanged += new System.EventHandler(this.txtBillID__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(323, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 50);
            this.label2.TabIndex = 30;
            this.label2.Text = "|";
            // 
            // DateFrom
            // 
            this.DateFrom.CustomFormat = "dd/MM/yyyy";
            this.DateFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFrom.Location = new System.Drawing.Point(760, 20);
            this.DateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.DateFrom.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(106, 26);
            this.DateFrom.TabIndex = 26;
            this.DateFrom.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // DateTo
            // 
            this.DateTo.CustomFormat = "dd/MM/yyyy";
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTo.Location = new System.Drawing.Point(900, 20);
            this.DateTo.Margin = new System.Windows.Forms.Padding(2);
            this.DateTo.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(100, 26);
            this.DateTo.TabIndex = 28;
            this.DateTo.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(871, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "__";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(691, 17);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(82, 32);
            this.txtDate.TabIndex = 12;
            this.txtDate.Text = "Ngày :";
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine1.ForeColor = System.Drawing.Color.Gray;
            this.lblLine1.Location = new System.Drawing.Point(673, 6);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(31, 50);
            this.lblLine1.TabIndex = 12;
            this.lblLine1.Text = "|";
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnect.ForeColor = System.Drawing.Color.Gray;
            this.lblConnect.Location = new System.Drawing.Point(520, 12);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(31, 30);
            this.lblConnect.TabIndex = 25;
            this.lblConnect.Text = "__";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.dollar_sign;
            this.pictureBox1.Location = new System.Drawing.Point(353, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.AllowUserToResizeColumns = false;
            this.dataGridViewBill.AllowUserToResizeRows = false;
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBill.ColumnHeadersHeight = 35;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.CustomerName,
            this.StaffID,
            this.Date,
            this.Discount,
            this.BillTotal});
            this.dataGridViewBill.EnableHeadersVisualStyles = false;
            this.dataGridViewBill.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewBill.Location = new System.Drawing.Point(33, 119);
            this.dataGridViewBill.MultiSelect = false;
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.ReadOnly = true;
            this.dataGridViewBill.RowHeadersVisible = false;
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewBill.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBill.Size = new System.Drawing.Size(684, 555);
            this.dataGridViewBill.TabIndex = 25;
            this.dataGridViewBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellClick);
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillId";
            this.BillID.FillWeight = 91.37056F;
            this.BillID.HeaderText = "Mã hóa đơn";
            this.BillID.MinimumWidth = 6;
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.FillWeight = 115.1555F;
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.FillWeight = 93.35802F;
            this.StaffID.HeaderText = "Mã nhân viên";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "BillDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.FillWeight = 117.053F;
            this.Date.HeaderText = "Ngày thanh toán";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.FillWeight = 77.71184F;
            this.Discount.HeaderText = "Giảm giá";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // BillTotal
            // 
            this.BillTotal.DataPropertyName = "Total";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.BillTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillTotal.FillWeight = 105.3512F;
            this.BillTotal.HeaderText = "Tổng hóa đơn";
            this.BillTotal.MinimumWidth = 6;
            this.BillTotal.Name = "BillTotal";
            this.BillTotal.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewBillDetail);
            this.groupBox1.Location = new System.Drawing.Point(724, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 556);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // dataGridViewBillDetail
            // 
            this.dataGridViewBillDetail.AllowUserToAddRows = false;
            this.dataGridViewBillDetail.AllowUserToDeleteRows = false;
            this.dataGridViewBillDetail.AllowUserToResizeColumns = false;
            this.dataGridViewBillDetail.AllowUserToResizeRows = false;
            this.dataGridViewBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBillDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBillDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBillDetail.ColumnHeadersHeight = 35;
            this.dataGridViewBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.SinglePrice,
            this.Total});
            this.dataGridViewBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBillDetail.EnableHeadersVisualStyles = false;
            this.dataGridViewBillDetail.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewBillDetail.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewBillDetail.MultiSelect = false;
            this.dataGridViewBillDetail.Name = "dataGridViewBillDetail";
            this.dataGridViewBillDetail.ReadOnly = true;
            this.dataGridViewBillDetail.RowHeadersVisible = false;
            this.dataGridViewBillDetail.RowHeadersWidth = 51;
            this.dataGridViewBillDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewBillDetail.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewBillDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBillDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewBillDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBillDetail.Size = new System.Drawing.Size(534, 531);
            this.dataGridViewBillDetail.TabIndex = 1;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.FillWeight = 96.44672F;
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 138.3906F;
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.Quantity.FillWeight = 80.006F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // SinglePrice
            // 
            this.SinglePrice.DataPropertyName = "PriceToSell";
            dataGridViewCellStyle7.Format = "N0";
            this.SinglePrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.SinglePrice.FillWeight = 92.57841F;
            this.SinglePrice.HeaderText = "Đơn giá";
            this.SinglePrice.MinimumWidth = 6;
            this.SinglePrice.Name = "SinglePrice";
            this.SinglePrice.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle8.Format = "N0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle8;
            this.Total.FillWeight = 92.57841F;
            this.Total.HeaderText = "Tổng";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1267, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 592);
            this.panel1.TabIndex = 27;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GUI.Properties.Resources.recycle_bin;
            this.btnDelete.Location = new System.Drawing.Point(16, 514);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPrint.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.BorderRadius = 20;
            this.btnPrint.BorderSize = 1;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::GUI.Properties.Resources.printer__2_;
            this.btnPrint.Location = new System.Drawing.Point(16, 446);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(40, 41);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveChip Mart";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewBillDetail;
        private System.Windows.Forms.Panel panel1;
        private HRJTextBox txtPriceFrom;
        private HRJTextBox txtBillID;
        private HRJTextBox txtPriceTo;
        private HRJButton btnSearch;
        private HRJButton btnClear;
        private HRJButton btnPrint;
        private HRJButton btnDelete;
        private HRJButton btnExit;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinglePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTotal;
    }
}