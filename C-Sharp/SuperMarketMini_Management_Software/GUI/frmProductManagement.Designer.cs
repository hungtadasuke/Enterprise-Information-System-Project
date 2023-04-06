namespace GUI
{
    partial class frmProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnHeading = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new GUI.HRJButton();
            this.txtPriceToSearch = new GUI.HRJTextBox();
            this.txtPriceFromSearch = new GUI.HRJTextBox();
            this.cBCategorySearch = new GUI.HRJComboBox();
            this.txtProductNameSearch = new GUI.HRJTextBox();
            this.picDollar = new System.Windows.Forms.PictureBox();
            this.cbUnitSearch = new GUI.HRJComboBox();
            this.lblConnect = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.pnBodyLeft = new System.Windows.Forms.Panel();
            this.txtQuantity = new GUI.HRJTextBox();
            this.btnSubQuantity = new GUI.HRJButton();
            this.btnAddQuantity = new GUI.HRJButton();
            this.hrjTextBox1 = new GUI.HRJTextBox();
            this.txtPriceToSell = new GUI.HRJTextBox();
            this.cBProductUnit = new GUI.HRJComboBox();
            this.txtImportPrice = new GUI.HRJTextBox();
            this.txtProductName = new GUI.HRJTextBox();
            this.txtProductId = new GUI.HRJTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cBCategory = new GUI.HRJComboBox();
            this.lblProductImg = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblPriceToSell = new System.Windows.Forms.Label();
            this.lblImportPrice = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tableLayoutStatus = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnTrue = new GUI.HRJRadioButton();
            this.rbtnFalse = new GUI.HRJRadioButton();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.pnBodyCenter = new System.Windows.Forms.Panel();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceToSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.productStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBodyRight = new System.Windows.Forms.Panel();
            this.btnAddProduct = new GUI.HRJButton();
            this.btnEditProduct = new GUI.HRJButton();
            this.btnReset = new GUI.HRJButton();
            this.pnHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDollar)).BeginInit();
            this.pnBodyLeft.SuspendLayout();
            this.tableLayoutStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.pnBodyCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.pnBodyRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeading
            // 
            this.pnHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.pnHeading.Controls.Add(this.picHome);
            this.pnHeading.Controls.Add(this.lblHeading);
            this.pnHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeading.Location = new System.Drawing.Point(0, 0);
            this.pnHeading.Name = "pnHeading";
            this.pnHeading.Size = new System.Drawing.Size(1334, 50);
            this.pnHeading.TabIndex = 2;
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(1278, 7);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 37);
            this.picHome.TabIndex = 7;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.picHome.MouseEnter += new System.EventHandler(this.picHome_MouseEnter);
            this.picHome.MouseLeave += new System.EventHandler(this.picHome_MouseLeave);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(558, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(219, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Quản Lý Sản Phẩm";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txtPriceToSearch);
            this.pnSearch.Controls.Add(this.txtPriceFromSearch);
            this.pnSearch.Controls.Add(this.cBCategorySearch);
            this.pnSearch.Controls.Add(this.txtProductNameSearch);
            this.pnSearch.Controls.Add(this.picDollar);
            this.pnSearch.Controls.Add(this.cbUnitSearch);
            this.pnSearch.Controls.Add(this.lblConnect);
            this.pnSearch.Controls.Add(this.lblLine2);
            this.pnSearch.Controls.Add(this.lblLine1);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 50);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1334, 50);
            this.pnSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.BorderSize = 2;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GUI.Properties.Resources.search_interface_symbol;
            this.btnSearch.Location = new System.Drawing.Point(1061, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 31);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // txtPriceToSearch
            // 
            this.txtPriceToSearch.BackColor = System.Drawing.Color.White;
            this.txtPriceToSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtPriceToSearch.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtPriceToSearch.BorderRadius = 0;
            this.txtPriceToSearch.BorderSize = 1;
            this.txtPriceToSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceToSearch.ForeColor = System.Drawing.Color.Black;
            this.txtPriceToSearch.Location = new System.Drawing.Point(908, 16);
            this.txtPriceToSearch.Multiline = false;
            this.txtPriceToSearch.Name = "txtPriceToSearch";
            this.txtPriceToSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPriceToSearch.PasswordChar = false;
            this.txtPriceToSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceToSearch.PlaceholderText = "Giá Bán Đến";
            this.txtPriceToSearch.Size = new System.Drawing.Size(104, 32);
            this.txtPriceToSearch.TabIndex = 19;
            this.txtPriceToSearch.UnderlineStyle = false;
            // 
            // txtPriceFromSearch
            // 
            this.txtPriceFromSearch.BackColor = System.Drawing.Color.White;
            this.txtPriceFromSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtPriceFromSearch.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtPriceFromSearch.BorderRadius = 0;
            this.txtPriceFromSearch.BorderSize = 1;
            this.txtPriceFromSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceFromSearch.ForeColor = System.Drawing.Color.Black;
            this.txtPriceFromSearch.Location = new System.Drawing.Point(768, 16);
            this.txtPriceFromSearch.Multiline = false;
            this.txtPriceFromSearch.Name = "txtPriceFromSearch";
            this.txtPriceFromSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPriceFromSearch.PasswordChar = false;
            this.txtPriceFromSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceFromSearch.PlaceholderText = "Giá Bán Từ";
            this.txtPriceFromSearch.Size = new System.Drawing.Size(104, 32);
            this.txtPriceFromSearch.TabIndex = 18;
            this.txtPriceFromSearch.UnderlineStyle = false;
            // 
            // cBCategorySearch
            // 
            this.cBCategorySearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cBCategorySearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.cBCategorySearch.BorderSize = 1;
            this.cBCategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cBCategorySearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCategorySearch.ForeColor = System.Drawing.Color.Black;
            this.cBCategorySearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.cBCategorySearch.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBCategorySearch.ListTextColor = System.Drawing.Color.Black;
            this.cBCategorySearch.Location = new System.Drawing.Point(155, 16);
            this.cBCategorySearch.MinimumSize = new System.Drawing.Size(100, 20);
            this.cBCategorySearch.Name = "cBCategorySearch";
            this.cBCategorySearch.Padding = new System.Windows.Forms.Padding(1);
            this.cBCategorySearch.Size = new System.Drawing.Size(170, 31);
            this.cBCategorySearch.TabIndex = 1;
            this.cBCategorySearch.Texts = "Nhóm Hàng";
            // 
            // txtProductNameSearch
            // 
            this.txtProductNameSearch.BackColor = System.Drawing.Color.White;
            this.txtProductNameSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtProductNameSearch.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtProductNameSearch.BorderRadius = 0;
            this.txtProductNameSearch.BorderSize = 1;
            this.txtProductNameSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNameSearch.ForeColor = System.Drawing.Color.Black;
            this.txtProductNameSearch.Location = new System.Drawing.Point(484, 16);
            this.txtProductNameSearch.Multiline = false;
            this.txtProductNameSearch.Name = "txtProductNameSearch";
            this.txtProductNameSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProductNameSearch.PasswordChar = false;
            this.txtProductNameSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProductNameSearch.PlaceholderText = "Tên Sản Phẩm (Từ Khóa)";
            this.txtProductNameSearch.Size = new System.Drawing.Size(200, 32);
            this.txtProductNameSearch.TabIndex = 16;
            this.txtProductNameSearch.UnderlineStyle = false;
            // 
            // picDollar
            // 
            this.picDollar.Image = global::GUI.Properties.Resources.dollar_sign;
            this.picDollar.Location = new System.Drawing.Point(729, 22);
            this.picDollar.Name = "picDollar";
            this.picDollar.Size = new System.Drawing.Size(20, 22);
            this.picDollar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDollar.TabIndex = 0;
            this.picDollar.TabStop = false;
            // 
            // cbUnitSearch
            // 
            this.cbUnitSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUnitSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.cbUnitSearch.BorderSize = 1;
            this.cbUnitSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbUnitSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnitSearch.ForeColor = System.Drawing.Color.Black;
            this.cbUnitSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.cbUnitSearch.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbUnitSearch.ListTextColor = System.Drawing.Color.Black;
            this.cbUnitSearch.Location = new System.Drawing.Point(351, 16);
            this.cbUnitSearch.MinimumSize = new System.Drawing.Size(100, 20);
            this.cbUnitSearch.Name = "cbUnitSearch";
            this.cbUnitSearch.Padding = new System.Windows.Forms.Padding(1);
            this.cbUnitSearch.Size = new System.Drawing.Size(108, 31);
            this.cbUnitSearch.TabIndex = 15;
            this.cbUnitSearch.Texts = "Đơn Vị";
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.lblConnect.Location = new System.Drawing.Point(878, 16);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(24, 23);
            this.lblConnect.TabIndex = 11;
            this.lblConnect.Text = "__";
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.lblLine2.Location = new System.Drawing.Point(1022, 7);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(24, 40);
            this.lblLine2.TabIndex = 10;
            this.lblLine2.Text = "|";
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.lblLine1.Location = new System.Drawing.Point(699, 7);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(24, 40);
            this.lblLine1.TabIndex = 9;
            this.lblLine1.Text = "|";
            // 
            // pnBodyLeft
            // 
            this.pnBodyLeft.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnBodyLeft.Controls.Add(this.txtQuantity);
            this.pnBodyLeft.Controls.Add(this.btnSubQuantity);
            this.pnBodyLeft.Controls.Add(this.btnAddQuantity);
            this.pnBodyLeft.Controls.Add(this.hrjTextBox1);
            this.pnBodyLeft.Controls.Add(this.txtPriceToSell);
            this.pnBodyLeft.Controls.Add(this.cBProductUnit);
            this.pnBodyLeft.Controls.Add(this.txtImportPrice);
            this.pnBodyLeft.Controls.Add(this.txtProductName);
            this.pnBodyLeft.Controls.Add(this.txtProductId);
            this.pnBodyLeft.Controls.Add(this.lblStatus);
            this.pnBodyLeft.Controls.Add(this.cBCategory);
            this.pnBodyLeft.Controls.Add(this.lblProductImg);
            this.pnBodyLeft.Controls.Add(this.lblQuantity);
            this.pnBodyLeft.Controls.Add(this.lblBarcode);
            this.pnBodyLeft.Controls.Add(this.lblPriceToSell);
            this.pnBodyLeft.Controls.Add(this.lblImportPrice);
            this.pnBodyLeft.Controls.Add(this.lblUnit);
            this.pnBodyLeft.Controls.Add(this.lblProductName);
            this.pnBodyLeft.Controls.Add(this.lblProductId);
            this.pnBodyLeft.Controls.Add(this.lblCategory);
            this.pnBodyLeft.Controls.Add(this.tableLayoutStatus);
            this.pnBodyLeft.Controls.Add(this.picProduct);
            this.pnBodyLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBodyLeft.Location = new System.Drawing.Point(0, 100);
            this.pnBodyLeft.Name = "pnBodyLeft";
            this.pnBodyLeft.Size = new System.Drawing.Size(370, 611);
            this.pnBodyLeft.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtQuantity.BorderRadius = 0;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(212, 381);
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.Size = new System.Drawing.Size(58, 32);
            this.txtQuantity.TabIndex = 21;
            this.txtQuantity.UnderlineStyle = false;
            this.txtQuantity._TextChanged += new System.EventHandler(this.txtQuantity__TextChanged);
            // 
            // btnSubQuantity
            // 
            this.btnSubQuantity.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSubQuantity.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnSubQuantity.BorderColor = System.Drawing.Color.White;
            this.btnSubQuantity.BorderRadius = 9;
            this.btnSubQuantity.BorderSize = 2;
            this.btnSubQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubQuantity.Enabled = false;
            this.btnSubQuantity.FlatAppearance.BorderSize = 0;
            this.btnSubQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubQuantity.ForeColor = System.Drawing.Color.White;
            this.btnSubQuantity.Image = global::GUI.Properties.Resources.minus1;
            this.btnSubQuantity.Location = new System.Drawing.Point(141, 381);
            this.btnSubQuantity.Name = "btnSubQuantity";
            this.btnSubQuantity.Size = new System.Drawing.Size(50, 30);
            this.btnSubQuantity.TabIndex = 20;
            this.btnSubQuantity.TextColor = System.Drawing.Color.White;
            this.btnSubQuantity.UseVisualStyleBackColor = false;
            this.btnSubQuantity.Visible = false;
            this.btnSubQuantity.Click += new System.EventHandler(this.btnSubQuantity_Click);
            this.btnSubQuantity.MouseEnter += new System.EventHandler(this.btnSubQuantity_MouseEnter);
            this.btnSubQuantity.MouseLeave += new System.EventHandler(this.btnSubQuantity_MouseLeave);
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddQuantity.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnAddQuantity.BorderColor = System.Drawing.Color.White;
            this.btnAddQuantity.BorderRadius = 9;
            this.btnAddQuantity.BorderSize = 2;
            this.btnAddQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuantity.FlatAppearance.BorderSize = 0;
            this.btnAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuantity.ForeColor = System.Drawing.Color.White;
            this.btnAddQuantity.Image = global::GUI.Properties.Resources.plus;
            this.btnAddQuantity.Location = new System.Drawing.Point(288, 381);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(50, 30);
            this.btnAddQuantity.TabIndex = 4;
            this.btnAddQuantity.TextColor = System.Drawing.Color.White;
            this.btnAddQuantity.UseVisualStyleBackColor = false;
            this.btnAddQuantity.Visible = false;
            this.btnAddQuantity.Click += new System.EventHandler(this.btnAddQuantity_Click);
            this.btnAddQuantity.MouseEnter += new System.EventHandler(this.btnAddQuantity_MouseEnter);
            this.btnAddQuantity.MouseLeave += new System.EventHandler(this.btnAddQuantity_MouseLeave);
            // 
            // hrjTextBox1
            // 
            this.hrjTextBox1.BackColor = System.Drawing.Color.White;
            this.hrjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.hrjTextBox1.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.hrjTextBox1.BorderRadius = 0;
            this.hrjTextBox1.BorderSize = 1;
            this.hrjTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrjTextBox1.ForeColor = System.Drawing.Color.Black;
            this.hrjTextBox1.Location = new System.Drawing.Point(141, 335);
            this.hrjTextBox1.Multiline = false;
            this.hrjTextBox1.Name = "hrjTextBox1";
            this.hrjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.hrjTextBox1.PasswordChar = false;
            this.hrjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.hrjTextBox1.PlaceholderText = "";
            this.hrjTextBox1.Size = new System.Drawing.Size(197, 32);
            this.hrjTextBox1.TabIndex = 2;
            this.hrjTextBox1.UnderlineStyle = false;
            this.hrjTextBox1._TextChanged += new System.EventHandler(this.txtPriceToSell__TextChanged);
            // 
            // txtPriceToSell
            // 
            this.txtPriceToSell.BackColor = System.Drawing.Color.White;
            this.txtPriceToSell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtPriceToSell.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtPriceToSell.BorderRadius = 0;
            this.txtPriceToSell.BorderSize = 1;
            this.txtPriceToSell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceToSell.ForeColor = System.Drawing.Color.Black;
            this.txtPriceToSell.Location = new System.Drawing.Point(141, 285);
            this.txtPriceToSell.Multiline = false;
            this.txtPriceToSell.Name = "txtPriceToSell";
            this.txtPriceToSell.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPriceToSell.PasswordChar = false;
            this.txtPriceToSell.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceToSell.PlaceholderText = "";
            this.txtPriceToSell.Size = new System.Drawing.Size(197, 32);
            this.txtPriceToSell.TabIndex = 2;
            this.txtPriceToSell.UnderlineStyle = false;
            this.txtPriceToSell._TextChanged += new System.EventHandler(this.txtPriceToSell__TextChanged);
            // 
            // cBProductUnit
            // 
            this.cBProductUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cBProductUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.cBProductUnit.BorderSize = 1;
            this.cBProductUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cBProductUnit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBProductUnit.ForeColor = System.Drawing.Color.Black;
            this.cBProductUnit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.cBProductUnit.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBProductUnit.ListTextColor = System.Drawing.Color.Black;
            this.cBProductUnit.Location = new System.Drawing.Point(141, 182);
            this.cBProductUnit.MinimumSize = new System.Drawing.Size(100, 20);
            this.cBProductUnit.Name = "cBProductUnit";
            this.cBProductUnit.Padding = new System.Windows.Forms.Padding(1);
            this.cBProductUnit.Size = new System.Drawing.Size(197, 28);
            this.cBProductUnit.TabIndex = 2;
            this.cBProductUnit.Texts = "";
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.BackColor = System.Drawing.Color.White;
            this.txtImportPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtImportPrice.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtImportPrice.BorderRadius = 0;
            this.txtImportPrice.BorderSize = 1;
            this.txtImportPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportPrice.ForeColor = System.Drawing.Color.Black;
            this.txtImportPrice.Location = new System.Drawing.Point(141, 232);
            this.txtImportPrice.Multiline = false;
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtImportPrice.PasswordChar = false;
            this.txtImportPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtImportPrice.PlaceholderText = "";
            this.txtImportPrice.Size = new System.Drawing.Size(197, 32);
            this.txtImportPrice.TabIndex = 1;
            this.txtImportPrice.UnderlineStyle = false;
            this.txtImportPrice._TextChanged += new System.EventHandler(this.txtImportPrice__TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtProductName.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtProductName.BorderRadius = 0;
            this.txtProductName.BorderSize = 1;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(141, 111);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProductName.PasswordChar = false;
            this.txtProductName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.Size = new System.Drawing.Size(197, 50);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.UnderlineStyle = false;
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProductId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtProductId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtProductId.BorderRadius = 0;
            this.txtProductId.BorderSize = 1;
            this.txtProductId.Enabled = false;
            this.txtProductId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.ForeColor = System.Drawing.Color.Black;
            this.txtProductId.Location = new System.Drawing.Point(141, 61);
            this.txtProductId.Multiline = false;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProductId.PasswordChar = false;
            this.txtProductId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProductId.PlaceholderText = "";
            this.txtProductId.Size = new System.Drawing.Size(197, 32);
            this.txtProductId.TabIndex = 3;
            this.txtProductId.UnderlineStyle = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(24, 545);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 20);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Trạng Thái:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cBCategory
            // 
            this.cBCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cBCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.cBCategory.BorderSize = 1;
            this.cBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cBCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCategory.ForeColor = System.Drawing.Color.Black;
            this.cBCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.cBCategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cBCategory.ListTextColor = System.Drawing.Color.Black;
            this.cBCategory.Location = new System.Drawing.Point(141, 14);
            this.cBCategory.MinimumSize = new System.Drawing.Size(100, 20);
            this.cBCategory.Name = "cBCategory";
            this.cBCategory.Padding = new System.Windows.Forms.Padding(1);
            this.cBCategory.Size = new System.Drawing.Size(197, 28);
            this.cBCategory.TabIndex = 1;
            this.cBCategory.Texts = "";
            // 
            // lblProductImg
            // 
            this.lblProductImg.AutoSize = true;
            this.lblProductImg.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductImg.Location = new System.Drawing.Point(24, 452);
            this.lblProductImg.Name = "lblProductImg";
            this.lblProductImg.Size = new System.Drawing.Size(78, 20);
            this.lblProductImg.TabIndex = 17;
            this.lblProductImg.Text = "Hình Ảnh:";
            this.lblProductImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(24, 386);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(108, 20);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Số Lượng Còn:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(24, 342);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(71, 20);
            this.lblBarcode.TabIndex = 15;
            this.lblBarcode.Text = "Mã vạch:";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriceToSell
            // 
            this.lblPriceToSell.AutoSize = true;
            this.lblPriceToSell.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceToSell.Location = new System.Drawing.Point(24, 290);
            this.lblPriceToSell.Name = "lblPriceToSell";
            this.lblPriceToSell.Size = new System.Drawing.Size(86, 20);
            this.lblPriceToSell.TabIndex = 15;
            this.lblPriceToSell.Text = "Giá Bán Ra:";
            this.lblPriceToSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImportPrice
            // 
            this.lblImportPrice.AutoSize = true;
            this.lblImportPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportPrice.Location = new System.Drawing.Point(24, 236);
            this.lblImportPrice.Name = "lblImportPrice";
            this.lblImportPrice.Size = new System.Drawing.Size(107, 20);
            this.lblImportPrice.TabIndex = 14;
            this.lblImportPrice.Text = "Giá Nhập Vào:";
            this.lblImportPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(24, 184);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(94, 20);
            this.lblUnit.TabIndex = 13;
            this.lblUnit.Text = "Đơn Vị Tính:";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(24, 125);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(109, 20);
            this.lblProductName.TabIndex = 12;
            this.lblProductName.Text = "Tên Sản Phẩm:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(24, 65);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(107, 20);
            this.lblProductId.TabIndex = 11;
            this.lblProductId.Text = "Mã Sản Phẩm:";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(24, 17);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(97, 20);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Nhóm Hàng:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutStatus
            // 
            this.tableLayoutStatus.ColumnCount = 2;
            this.tableLayoutStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutStatus.Controls.Add(this.rbtnTrue, 0, 0);
            this.tableLayoutStatus.Controls.Add(this.rbtnFalse, 1, 0);
            this.tableLayoutStatus.Location = new System.Drawing.Point(141, 540);
            this.tableLayoutStatus.Name = "tableLayoutStatus";
            this.tableLayoutStatus.RowCount = 1;
            this.tableLayoutStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutStatus.Size = new System.Drawing.Size(223, 35);
            this.tableLayoutStatus.TabIndex = 9;
            // 
            // rbtnTrue
            // 
            this.rbtnTrue.AutoSize = true;
            this.rbtnTrue.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.rbtnTrue.Location = new System.Drawing.Point(3, 3);
            this.rbtnTrue.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnTrue.Name = "rbtnTrue";
            this.rbtnTrue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnTrue.Size = new System.Drawing.Size(57, 21);
            this.rbtnTrue.TabIndex = 0;
            this.rbtnTrue.TabStop = true;
            this.rbtnTrue.Text = "Bán";
            this.rbtnTrue.UnCheckedColor = System.Drawing.Color.DimGray;
            this.rbtnTrue.UseVisualStyleBackColor = true;
            // 
            // rbtnFalse
            // 
            this.rbtnFalse.AutoSize = true;
            this.rbtnFalse.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.rbtnFalse.Location = new System.Drawing.Point(103, 3);
            this.rbtnFalse.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnFalse.Name = "rbtnFalse";
            this.rbtnFalse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnFalse.Size = new System.Drawing.Size(102, 21);
            this.rbtnFalse.TabIndex = 1;
            this.rbtnFalse.TabStop = true;
            this.rbtnFalse.Text = "Ngừng Bán";
            this.rbtnFalse.UnCheckedColor = System.Drawing.Color.DimGray;
            this.rbtnFalse.UseVisualStyleBackColor = true;
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProduct.Image = global::GUI.Properties.Resources.ef3_placeholder_image;
            this.picProduct.Location = new System.Drawing.Point(166, 430);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(147, 99);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 8;
            this.picProduct.TabStop = false;
            this.picProduct.Click += new System.EventHandler(this.picProduct_Click);
            // 
            // pnBodyCenter
            // 
            this.pnBodyCenter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnBodyCenter.Controls.Add(this.dataGridViewProduct);
            this.pnBodyCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBodyCenter.Location = new System.Drawing.Point(370, 100);
            this.pnBodyCenter.Name = "pnBodyCenter";
            this.pnBodyCenter.Size = new System.Drawing.Size(864, 611);
            this.pnBodyCenter.TabIndex = 5;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToResizeColumns = false;
            this.dataGridViewProduct.AllowUserToResizeRows = false;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProduct.ColumnHeadersHeight = 35;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand,
            this.ProductId,
            this.productName,
            this.productUnit,
            this.productImportPrice,
            this.productPriceToSell,
            this.productQuantity,
            this.productImg,
            this.productStatus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProduct.EnableHeadersVisualStyles = false;
            this.dataGridViewProduct.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewProduct.MultiSelect = false;
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProduct.RowTemplate.Height = 40;
            this.dataGridViewProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(864, 549);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            // 
            // brand
            // 
            this.brand.DataPropertyName = "CategoryName";
            this.brand.HeaderText = "Nhóm hàng";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 125;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Mã";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 70;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "ProductName";
            this.productName.HeaderText = "Tên Sản Phẩm";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 220;
            // 
            // productUnit
            // 
            this.productUnit.DataPropertyName = "Unit";
            this.productUnit.HeaderText = "Đơn Vị";
            this.productUnit.MinimumWidth = 6;
            this.productUnit.Name = "productUnit";
            this.productUnit.ReadOnly = true;
            this.productUnit.Width = 70;
            // 
            // productImportPrice
            // 
            this.productImportPrice.DataPropertyName = "ImportPrice";
            this.productImportPrice.HeaderText = "Giá Nhập";
            this.productImportPrice.MinimumWidth = 6;
            this.productImportPrice.Name = "productImportPrice";
            this.productImportPrice.ReadOnly = true;
            this.productImportPrice.Width = 80;
            // 
            // productPriceToSell
            // 
            this.productPriceToSell.DataPropertyName = "PriceToSell";
            this.productPriceToSell.HeaderText = "Giá Bán";
            this.productPriceToSell.MinimumWidth = 6;
            this.productPriceToSell.Name = "productPriceToSell";
            this.productPriceToSell.ReadOnly = true;
            this.productPriceToSell.Width = 80;
            // 
            // productQuantity
            // 
            this.productQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.productQuantity.HeaderText = "Số lượng";
            this.productQuantity.MinimumWidth = 6;
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            this.productQuantity.Width = 70;
            // 
            // productImg
            // 
            this.productImg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productImg.DataPropertyName = "ProductImg";
            this.productImg.FillWeight = 60F;
            this.productImg.HeaderText = "Hình";
            this.productImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.productImg.MinimumWidth = 6;
            this.productImg.Name = "productImg";
            this.productImg.ReadOnly = true;
            this.productImg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productImg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // productStatus
            // 
            this.productStatus.DataPropertyName = "StatusItem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.productStatus.HeaderText = "Trạng Thái";
            this.productStatus.MinimumWidth = 6;
            this.productStatus.Name = "productStatus";
            this.productStatus.ReadOnly = true;
            this.productStatus.Width = 80;
            // 
            // pnBodyRight
            // 
            this.pnBodyRight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnBodyRight.Controls.Add(this.btnAddProduct);
            this.pnBodyRight.Controls.Add(this.btnEditProduct);
            this.pnBodyRight.Controls.Add(this.btnReset);
            this.pnBodyRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBodyRight.Location = new System.Drawing.Point(1234, 100);
            this.pnBodyRight.Name = "pnBodyRight";
            this.pnBodyRight.Size = new System.Drawing.Size(100, 611);
            this.pnBodyRight.TabIndex = 6;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddProduct.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnAddProduct.BorderColor = System.Drawing.Color.White;
            this.btnAddProduct.BorderRadius = 12;
            this.btnAddProduct.BorderSize = 2;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::GUI.Properties.Resources.add__1_;
            this.btnAddProduct.Location = new System.Drawing.Point(16, 249);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(60, 48);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.TextColor = System.Drawing.Color.White;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            this.btnAddProduct.MouseEnter += new System.EventHandler(this.btnAddProduct_MouseEnter);
            this.btnAddProduct.MouseLeave += new System.EventHandler(this.btnAddProduct_MouseLeave);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditProduct.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnEditProduct.BorderColor = System.Drawing.Color.White;
            this.btnEditProduct.BorderRadius = 12;
            this.btnEditProduct.BorderSize = 2;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Image = global::GUI.Properties.Resources.draw;
            this.btnEditProduct.Location = new System.Drawing.Point(16, 334);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(60, 48);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.TextColor = System.Drawing.Color.White;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            this.btnEditProduct.MouseEnter += new System.EventHandler(this.btnEditProduct_MouseEnter);
            this.btnEditProduct.MouseLeave += new System.EventHandler(this.btnEditProduct_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReset.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnReset.BorderColor = System.Drawing.Color.White;
            this.btnReset.BorderRadius = 12;
            this.btnReset.BorderSize = 2;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::GUI.Properties.Resources.refreshing;
            this.btnReset.Location = new System.Drawing.Point(16, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 48);
            this.btnReset.TabIndex = 1;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.pnBodyRight);
            this.Controls.Add(this.pnBodyCenter);
            this.Controls.Add(this.pnBodyLeft);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.pnHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveChip Mart";
            this.Load += new System.EventHandler(this.frmProductManagementt_Load);
            this.pnHeading.ResumeLayout(false);
            this.pnHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDollar)).EndInit();
            this.pnBodyLeft.ResumeLayout(false);
            this.pnBodyLeft.PerformLayout();
            this.tableLayoutStatus.ResumeLayout(false);
            this.tableLayoutStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.pnBodyCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.pnBodyRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeading;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.PictureBox picDollar;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Panel pnBodyLeft;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProductImg;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPriceToSell;
        private System.Windows.Forms.Label lblImportPrice;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutStatus;
        private System.Windows.Forms.Panel pnBodyCenter;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Panel pnBodyRight;
        private HRJTextBox txtPriceFromSearch;
        private HRJTextBox txtProductNameSearch;
        private HRJComboBox cbUnitSearch;
        private HRJComboBox cBCategorySearch;
        private HRJTextBox txtPriceToSearch;
        private HRJButton btnSearch;
        private HRJButton btnReset;
        private HRJButton btnAddProduct;
        private HRJButton btnEditProduct;
        private System.Windows.Forms.PictureBox picProduct;
        private HRJComboBox cBProductUnit;
        private HRJComboBox cBCategory;
        private HRJTextBox txtProductId;
        private HRJTextBox txtProductName;
        private HRJTextBox txtPriceToSell;
        private HRJTextBox txtImportPrice;
        private HRJTextBox txtQuantity;
        private HRJButton btnSubQuantity;
        private HRJButton btnAddQuantity;
        private HRJRadioButton rbtnTrue;
        private HRJRadioButton rbtnFalse;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceToSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewImageColumn productImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatus;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblBarcode;
        private HRJTextBox hrjTextBox1;
    }
}