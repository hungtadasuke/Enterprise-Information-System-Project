namespace GUI
{
    partial class frmSupplier
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
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label numberPhoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label statusItemLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new GUI.HRJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new GUI.HRJButton();
            this.txtSupplierPhone1 = new GUI.HRJTextBox();
            this.btnSearch = new GUI.HRJButton();
            this.txtSupplierName1 = new GUI.HRJTextBox();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new GUI.HRJButton();
            this.btnUpdate = new GUI.HRJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSupplierAddress = new GUI.HRJTextBox();
            this.txtSupplierPhone = new GUI.HRJTextBox();
            this.txtSupplierName = new GUI.HRJTextBox();
            this.txtSupplierID = new GUI.HRJTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnFalse = new GUI.HRJRadioButton();
            this.rbtnTrue = new GUI.HRJRadioButton();
            customerIdLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            numberPhoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            statusItemLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIdLabel.Location = new System.Drawing.Point(13, 15);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(158, 25);
            customerIdLabel.TabIndex = 2;
            customerIdLabel.Text = "Mã nhà cung cấp";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerNameLabel.Location = new System.Drawing.Point(13, 62);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(160, 25);
            customerNameLabel.TabIndex = 4;
            customerNameLabel.Text = "Tên nhà cung cấp";
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numberPhoneLabel.Location = new System.Drawing.Point(13, 111);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new System.Drawing.Size(123, 25);
            numberPhoneLabel.TabIndex = 8;
            numberPhoneLabel.Text = "Số điện thoại";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(13, 162);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(70, 25);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Địa chỉ";
            // 
            // statusItemLabel
            // 
            statusItemLabel.AutoSize = true;
            statusItemLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusItemLabel.Location = new System.Drawing.Point(13, 217);
            statusItemLabel.Name = "statusItemLabel";
            statusItemLabel.Size = new System.Drawing.Size(96, 25);
            statusItemLabel.TabIndex = 14;
            statusItemLabel.Text = "Trạng thái";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1334, 119);
            this.panel3.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 0;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::GUI.Properties.Resources.icons8_home_page_32;
            this.btnExit.Location = new System.Drawing.Point(1262, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 41);
            this.btnExit.TabIndex = 26;
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
            this.label9.Location = new System.Drawing.Point(540, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 45);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(674, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.txtSupplierPhone1);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtSupplierName1);
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
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(913, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 39);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Tải lại";
            this.btnClear.TextColor = System.Drawing.Color.Black;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSupplierPhone1
            // 
            this.txtSupplierPhone1.BackColor = System.Drawing.Color.White;
            this.txtSupplierPhone1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtSupplierPhone1.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtSupplierPhone1.BorderRadius = 0;
            this.txtSupplierPhone1.BorderSize = 2;
            this.txtSupplierPhone1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierPhone1.ForeColor = System.Drawing.Color.DimGray;
            this.txtSupplierPhone1.Location = new System.Drawing.Point(611, 14);
            this.txtSupplierPhone1.Multiline = false;
            this.txtSupplierPhone1.Name = "txtSupplierPhone1";
            this.txtSupplierPhone1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierPhone1.PasswordChar = false;
            this.txtSupplierPhone1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSupplierPhone1.PlaceholderText = "Số điện thoại";
            this.txtSupplierPhone1.Size = new System.Drawing.Size(205, 32);
            this.txtSupplierPhone1.TabIndex = 39;
            this.txtSupplierPhone1.UnderlineStyle = false;
            this.txtSupplierPhone1._TextChanged += new System.EventHandler(this.txtSupplierPhone1__TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(822, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 39);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSupplierName1
            // 
            this.txtSupplierName1.BackColor = System.Drawing.Color.White;
            this.txtSupplierName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtSupplierName1.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtSupplierName1.BorderRadius = 0;
            this.txtSupplierName1.BorderSize = 2;
            this.txtSupplierName1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName1.ForeColor = System.Drawing.Color.DimGray;
            this.txtSupplierName1.Location = new System.Drawing.Point(400, 14);
            this.txtSupplierName1.Multiline = false;
            this.txtSupplierName1.Name = "txtSupplierName1";
            this.txtSupplierName1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierName1.PasswordChar = false;
            this.txtSupplierName1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSupplierName1.PlaceholderText = "Tên";
            this.txtSupplierName1.Size = new System.Drawing.Size(205, 32);
            this.txtSupplierName1.TabIndex = 38;
            this.txtSupplierName1.UnderlineStyle = false;
            this.txtSupplierName1._TextChanged += new System.EventHandler(this.txtSupplierName1__TextChanged);
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.AllowUserToAddRows = false;
            this.dataGridViewSupplier.AllowUserToDeleteRows = false;
            this.dataGridViewSupplier.AllowUserToResizeColumns = false;
            this.dataGridViewSupplier.AllowUserToResizeRows = false;
            this.dataGridViewSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSupplier.ColumnHeadersHeight = 35;
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupplierName,
            this.SupplierAddress,
            this.NumberPhone,
            this.StatusItem});
            this.dataGridViewSupplier.EnableHeadersVisualStyles = false;
            this.dataGridViewSupplier.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(460, 119);
            this.dataGridViewSupplier.MultiSelect = false;
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.ReadOnly = true;
            this.dataGridViewSupplier.RowHeadersVisible = false;
            this.dataGridViewSupplier.RowHeadersWidth = 51;
            this.dataGridViewSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewSupplier.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSupplier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(802, 562);
            this.dataGridViewSupplier.TabIndex = 44;
            this.dataGridViewSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellClick);
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.FillWeight = 88.8325F;
            this.SupplierId.HeaderText = "Mã nhà cung cấp";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.FillWeight = 139.8254F;
            this.SupplierName.HeaderText = "Tên Nhà cung cấp";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.DataPropertyName = "SupplierAddress";
            this.SupplierAddress.FillWeight = 141.0014F;
            this.SupplierAddress.HeaderText = "Địa chỉ";
            this.SupplierAddress.Name = "SupplierAddress";
            this.SupplierAddress.ReadOnly = true;
            // 
            // NumberPhone
            // 
            this.NumberPhone.DataPropertyName = "NumberPhone";
            this.NumberPhone.FillWeight = 72.42933F;
            this.NumberPhone.HeaderText = "Số điện thoại";
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.ReadOnly = true;
            // 
            // StatusItem
            // 
            this.StatusItem.DataPropertyName = "StatusItem";
            this.StatusItem.FillWeight = 57.91142F;
            this.StatusItem.HeaderText = "Trạng thái";
            this.StatusItem.Name = "StatusItem";
            this.StatusItem.ReadOnly = true;
            this.StatusItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1262, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 592);
            this.panel1.TabIndex = 45;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::GUI.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(17, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 41);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::GUI.Properties.Resources.draw;
            this.btnUpdate.Location = new System.Drawing.Point(17, 521);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.txtSupplierAddress);
            this.panel2.Controls.Add(this.txtSupplierPhone);
            this.panel2.Controls.Add(this.txtSupplierName);
            this.panel2.Controls.Add(this.txtSupplierID);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(customerIdLabel);
            this.panel2.Controls.Add(customerNameLabel);
            this.panel2.Controls.Add(numberPhoneLabel);
            this.panel2.Controls.Add(addressLabel);
            this.panel2.Controls.Add(statusItemLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 592);
            this.panel2.TabIndex = 46;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.BackColor = System.Drawing.Color.White;
            this.txtSupplierAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtSupplierAddress.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtSupplierAddress.BorderRadius = 0;
            this.txtSupplierAddress.BorderSize = 2;
            this.txtSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierAddress.Location = new System.Drawing.Point(175, 162);
            this.txtSupplierAddress.Multiline = false;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierAddress.PasswordChar = false;
            this.txtSupplierAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSupplierAddress.PlaceholderText = "";
            this.txtSupplierAddress.Size = new System.Drawing.Size(256, 32);
            this.txtSupplierAddress.TabIndex = 41;
            this.txtSupplierAddress.UnderlineStyle = false;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.BackColor = System.Drawing.Color.White;
            this.txtSupplierPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtSupplierPhone.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtSupplierPhone.BorderRadius = 0;
            this.txtSupplierPhone.BorderSize = 2;
            this.txtSupplierPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierPhone.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierPhone.Location = new System.Drawing.Point(175, 111);
            this.txtSupplierPhone.Multiline = false;
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierPhone.PasswordChar = false;
            this.txtSupplierPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSupplierPhone.PlaceholderText = "";
            this.txtSupplierPhone.Size = new System.Drawing.Size(256, 32);
            this.txtSupplierPhone.TabIndex = 40;
            this.txtSupplierPhone.UnderlineStyle = false;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.Color.White;
            this.txtSupplierName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtSupplierName.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtSupplierName.BorderRadius = 0;
            this.txtSupplierName.BorderSize = 2;
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.Location = new System.Drawing.Point(175, 62);
            this.txtSupplierName.Multiline = false;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierName.PasswordChar = false;
            this.txtSupplierName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSupplierName.PlaceholderText = "";
            this.txtSupplierName.Size = new System.Drawing.Size(256, 32);
            this.txtSupplierName.TabIndex = 39;
            this.txtSupplierName.UnderlineStyle = false;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSupplierID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtSupplierID.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtSupplierID.BorderRadius = 0;
            this.txtSupplierID.BorderSize = 2;
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierID.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierID.Location = new System.Drawing.Point(175, 15);
            this.txtSupplierID.Multiline = false;
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSupplierID.PasswordChar = false;
            this.txtSupplierID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSupplierID.PlaceholderText = "";
            this.txtSupplierID.Size = new System.Drawing.Size(256, 32);
            this.txtSupplierID.TabIndex = 38;
            this.txtSupplierID.UnderlineStyle = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            this.tableLayoutPanel3.Controls.Add(this.rbtnFalse, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbtnTrue, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(175, 217);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(256, 31);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // rbtnFalse
            // 
            this.rbtnFalse.AutoSize = true;
            this.rbtnFalse.CheckedColor = System.Drawing.Color.OrangeRed;
            this.rbtnFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFalse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFalse.Location = new System.Drawing.Point(110, 3);
            this.rbtnFalse.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnFalse.Name = "rbtnFalse";
            this.rbtnFalse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnFalse.Size = new System.Drawing.Size(141, 21);
            this.rbtnFalse.TabIndex = 3;
            this.rbtnFalse.Text = "Không Hoạt động";
            this.rbtnFalse.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.rbtnFalse.UseVisualStyleBackColor = true;
            // 
            // rbtnTrue
            // 
            this.rbtnTrue.AutoSize = true;
            this.rbtnTrue.CheckedColor = System.Drawing.Color.OrangeRed;
            this.rbtnTrue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTrue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTrue.Location = new System.Drawing.Point(3, 3);
            this.rbtnTrue.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnTrue.Name = "rbtnTrue";
            this.rbtnTrue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnTrue.Size = new System.Drawing.Size(99, 21);
            this.rbtnTrue.TabIndex = 2;
            this.rbtnTrue.Text = "Hoạt động";
            this.rbtnTrue.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.rbtnTrue.UseVisualStyleBackColor = true;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveChip Mart";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.Panel panel1;
        private HRJButton btnExit;
        private HRJButton btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private HRJTextBox txtSupplierAddress;
        private HRJTextBox txtSupplierName;
        private HRJTextBox txtSupplierID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private HRJRadioButton rbtnFalse;
        private HRJRadioButton rbtnTrue;
        private HRJTextBox txtSupplierPhone;
        private HRJButton btnAdd;
        private HRJButton btnClear;
        private HRJTextBox txtSupplierPhone1;
        private HRJButton btnSearch;
        private HRJTextBox txtSupplierName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusItem;
    }
}