namespace GUI
{
    partial class frmCustomer
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
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label numberPhoneLabel;
            System.Windows.Forms.Label pointLabel;
            System.Windows.Forms.Label statusItemLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new GUI.HRJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new GUI.HRJButton();
            this.txtCustomerPhone1 = new GUI.HRJTextBox();
            this.btnSearch = new GUI.HRJButton();
            this.txtCustomerName1 = new GUI.HRJTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnFemale1 = new GUI.HRJRadioButton();
            this.rbtnMale1 = new GUI.HRJRadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerPoint = new GUI.HRJTextBox();
            this.txtCustomerPhone = new GUI.HRJTextBox();
            this.txtCustomerName = new GUI.HRJTextBox();
            this.txtCustomerID = new GUI.HRJTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnFalse = new GUI.HRJRadioButton();
            this.rbtnTrue = new GUI.HRJRadioButton();
            this.tableLayoutPanelGender = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnFemale = new GUI.HRJRadioButton();
            this.rbtnMale = new GUI.HRJRadioButton();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new GUI.HRJButton();
            this.btnAdd = new GUI.HRJButton();
            customerIdLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            numberPhoneLabel = new System.Windows.Forms.Label();
            pointLabel = new System.Windows.Forms.Label();
            statusItemLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIdLabel.Location = new System.Drawing.Point(13, 15);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(142, 25);
            customerIdLabel.TabIndex = 2;
            customerIdLabel.Text = "Mã khách hàng";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerNameLabel.Location = new System.Drawing.Point(13, 62);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(92, 25);
            customerNameLabel.TabIndex = 4;
            customerNameLabel.Text = "Họ và tên";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(13, 112);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(84, 25);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Giới tính";
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numberPhoneLabel.Location = new System.Drawing.Point(13, 166);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new System.Drawing.Size(123, 25);
            numberPhoneLabel.TabIndex = 8;
            numberPhoneLabel.Text = "Số điện thoại";
            // 
            // pointLabel
            // 
            pointLabel.AutoSize = true;
            pointLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pointLabel.Location = new System.Drawing.Point(13, 215);
            pointLabel.Name = "pointLabel";
            pointLabel.Size = new System.Drawing.Size(56, 25);
            pointLabel.TabIndex = 12;
            pointLabel.Text = "Điểm";
            // 
            // statusItemLabel
            // 
            statusItemLabel.AutoSize = true;
            statusItemLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusItemLabel.Location = new System.Drawing.Point(13, 271);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1334, 118);
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
            this.btnExit.Location = new System.Drawing.Point(1253, 5);
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
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(510, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(324, 37);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quản Lý Khách Hàng";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(506, 27);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.txtCustomerPhone1);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtCustomerName1);
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.lblSex);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1334, 66);
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
            this.btnClear.Location = new System.Drawing.Point(1026, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 39);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Tải lại";
            this.btnClear.TextColor = System.Drawing.Color.Black;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCustomerPhone1
            // 
            this.txtCustomerPhone1.BackColor = System.Drawing.Color.White;
            this.txtCustomerPhone1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtCustomerPhone1.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtCustomerPhone1.BorderRadius = 0;
            this.txtCustomerPhone1.BorderSize = 2;
            this.txtCustomerPhone1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone1.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustomerPhone1.Location = new System.Drawing.Point(724, 17);
            this.txtCustomerPhone1.Multiline = false;
            this.txtCustomerPhone1.Name = "txtCustomerPhone1";
            this.txtCustomerPhone1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerPhone1.PasswordChar = false;
            this.txtCustomerPhone1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerPhone1.PlaceholderText = "Số điện thoại";
            this.txtCustomerPhone1.Size = new System.Drawing.Size(205, 32);
            this.txtCustomerPhone1.TabIndex = 33;
            this.txtCustomerPhone1.UnderlineStyle = false;
            this.txtCustomerPhone1._TextChanged += new System.EventHandler(this.txtCustomerPhone1__TextChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(935, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 39);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustomerName1
            // 
            this.txtCustomerName1.BackColor = System.Drawing.Color.White;
            this.txtCustomerName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtCustomerName1.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtCustomerName1.BorderRadius = 0;
            this.txtCustomerName1.BorderSize = 2;
            this.txtCustomerName1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName1.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustomerName1.Location = new System.Drawing.Point(513, 17);
            this.txtCustomerName1.Multiline = false;
            this.txtCustomerName1.Name = "txtCustomerName1";
            this.txtCustomerName1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerName1.PasswordChar = false;
            this.txtCustomerName1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName1.PlaceholderText = "Tên";
            this.txtCustomerName1.Size = new System.Drawing.Size(205, 32);
            this.txtCustomerName1.TabIndex = 32;
            this.txtCustomerName1.UnderlineStyle = false;
            this.txtCustomerName1._TextChanged += new System.EventHandler(this.txtCustomerName1__TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rbtnFemale1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtnMale1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(371, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(129, 32);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // rbtnFemale1
            // 
            this.rbtnFemale1.AutoSize = true;
            this.rbtnFemale1.CheckedColor = System.Drawing.Color.OrangeRed;
            this.rbtnFemale1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFemale1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale1.Location = new System.Drawing.Point(67, 3);
            this.rbtnFemale1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnFemale1.Name = "rbtnFemale1";
            this.rbtnFemale1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnFemale1.Size = new System.Drawing.Size(54, 21);
            this.rbtnFemale1.TabIndex = 1;
            this.rbtnFemale1.Text = "Nữ";
            this.rbtnFemale1.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.rbtnFemale1.UseVisualStyleBackColor = true;
            this.rbtnFemale1.CheckedChanged += new System.EventHandler(this.rbtnFemale1_CheckedChanged);
            this.rbtnFemale1.Click += new System.EventHandler(this.rbtnFemale1_Click);
            // 
            // rbtnMale1
            // 
            this.rbtnMale1.AutoSize = true;
            this.rbtnMale1.CheckedColor = System.Drawing.Color.OrangeRed;
            this.rbtnMale1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMale1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale1.Location = new System.Drawing.Point(3, 3);
            this.rbtnMale1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnMale1.Name = "rbtnMale1";
            this.rbtnMale1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnMale1.Size = new System.Drawing.Size(58, 21);
            this.rbtnMale1.TabIndex = 0;
            this.rbtnMale1.Text = "Nam";
            this.rbtnMale1.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.rbtnMale1.UseVisualStyleBackColor = true;
            this.rbtnMale1.CheckedChanged += new System.EventHandler(this.rbtnMale1_CheckedChanged);
            this.rbtnMale1.Click += new System.EventHandler(this.rbtnMale1_Click);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(292, 21);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(75, 20);
            this.lblSex.TabIndex = 22;
            this.lblSex.Text = "Giới tính :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.txtCustomerPoint);
            this.panel2.Controls.Add(this.txtCustomerPhone);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.txtCustomerID);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.tableLayoutPanelGender);
            this.panel2.Controls.Add(customerIdLabel);
            this.panel2.Controls.Add(customerNameLabel);
            this.panel2.Controls.Add(genderLabel);
            this.panel2.Controls.Add(numberPhoneLabel);
            this.panel2.Controls.Add(pointLabel);
            this.panel2.Controls.Add(statusItemLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 593);
            this.panel2.TabIndex = 20;
            // 
            // txtCustomerPoint
            // 
            this.txtCustomerPoint.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCustomerPoint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtCustomerPoint.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtCustomerPoint.BorderRadius = 0;
            this.txtCustomerPoint.BorderSize = 2;
            this.txtCustomerPoint.Enabled = false;
            this.txtCustomerPoint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPoint.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerPoint.Location = new System.Drawing.Point(175, 215);
            this.txtCustomerPoint.Multiline = false;
            this.txtCustomerPoint.Name = "txtCustomerPoint";
            this.txtCustomerPoint.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerPoint.PasswordChar = false;
            this.txtCustomerPoint.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerPoint.PlaceholderText = "";
            this.txtCustomerPoint.Size = new System.Drawing.Size(256, 32);
            this.txtCustomerPoint.TabIndex = 41;
            this.txtCustomerPoint.UnderlineStyle = false;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.White;
            this.txtCustomerPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtCustomerPhone.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtCustomerPhone.BorderRadius = 0;
            this.txtCustomerPhone.BorderSize = 2;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerPhone.Location = new System.Drawing.Point(175, 166);
            this.txtCustomerPhone.Multiline = false;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerPhone.PasswordChar = false;
            this.txtCustomerPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerPhone.PlaceholderText = "";
            this.txtCustomerPhone.Size = new System.Drawing.Size(256, 32);
            this.txtCustomerPhone.TabIndex = 40;
            this.txtCustomerPhone.UnderlineStyle = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtCustomerName.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtCustomerName.BorderRadius = 0;
            this.txtCustomerName.BorderSize = 2;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Location = new System.Drawing.Point(175, 62);
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerName.PasswordChar = false;
            this.txtCustomerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(256, 32);
            this.txtCustomerName.TabIndex = 39;
            this.txtCustomerName.UnderlineStyle = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCustomerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.txtCustomerID.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtCustomerID.BorderRadius = 0;
            this.txtCustomerID.BorderSize = 2;
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerID.Location = new System.Drawing.Point(175, 15);
            this.txtCustomerID.Multiline = false;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerID.PasswordChar = false;
            this.txtCustomerID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(256, 32);
            this.txtCustomerID.TabIndex = 38;
            this.txtCustomerID.UnderlineStyle = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            this.tableLayoutPanel3.Controls.Add(this.rbtnFalse, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbtnTrue, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(175, 271);
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
            // tableLayoutPanelGender
            // 
            this.tableLayoutPanelGender.ColumnCount = 2;
            this.tableLayoutPanelGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGender.Controls.Add(this.rbtnFemale, 0, 0);
            this.tableLayoutPanelGender.Controls.Add(this.rbtnMale, 0, 0);
            this.tableLayoutPanelGender.Location = new System.Drawing.Point(175, 112);
            this.tableLayoutPanelGender.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelGender.Name = "tableLayoutPanelGender";
            this.tableLayoutPanelGender.RowCount = 1;
            this.tableLayoutPanelGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGender.Size = new System.Drawing.Size(256, 31);
            this.tableLayoutPanelGender.TabIndex = 26;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.CheckedColor = System.Drawing.Color.OrangeRed;
            this.rbtnFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFemale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(131, 3);
            this.rbtnFemale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnFemale.Size = new System.Drawing.Size(54, 21);
            this.rbtnFemale.TabIndex = 2;
            this.rbtnFemale.Text = "Nữ";
            this.rbtnFemale.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.CheckedColor = System.Drawing.Color.OrangeRed;
            this.rbtnMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(3, 3);
            this.rbtnMale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnMale.Size = new System.Drawing.Size(64, 21);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.Text = "Nam";
            this.rbtnMale.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AllowUserToResizeColumns = false;
            this.dataGridViewCustomer.AllowUserToResizeRows = false;
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomer.ColumnHeadersHeight = 35;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Sex,
            this.Phone,
            this.Point,
            this.StatusItem});
            this.dataGridViewCustomer.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomer.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(462, 118);
            this.dataGridViewCustomer.MultiSelect = false;
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersVisible = false;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCustomer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(790, 560);
            this.dataGridViewCustomer.TabIndex = 0;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CustomerID.DataPropertyName = "CustomerId";
            this.CustomerID.HeaderText = "Mã khách hàng";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.FillWeight = 141.7324F;
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Gender";
            this.Sex.FillWeight = 91.65359F;
            this.Sex.HeaderText = "Giới tính";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "NumberPhone";
            this.Phone.FillWeight = 91.65359F;
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Point.DefaultCellStyle = dataGridViewCellStyle2;
            this.Point.FillWeight = 91.65359F;
            this.Point.HeaderText = "Điểm";
            this.Point.MinimumWidth = 6;
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            // 
            // StatusItem
            // 
            this.StatusItem.DataPropertyName = "StatusItem";
            this.StatusItem.HeaderText = "Trạng thái";
            this.StatusItem.Name = "StatusItem";
            this.StatusItem.ReadOnly = true;
            this.StatusItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1253, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 593);
            this.panel1.TabIndex = 23;
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
            this.btnUpdate.Location = new System.Drawing.Point(25, 519);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 41);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(25, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveChip Mart";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelGender.ResumeLayout(false);
            this.tableLayoutPanelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGender;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Panel panel1;
        private HRJButton btnExit;
        private HRJRadioButton rbtnMale1;
        private HRJRadioButton rbtnFemale1;
        private HRJTextBox txtCustomerPhone1;
        private HRJTextBox txtCustomerName1;
        private HRJButton btnClear;
        private HRJButton btnSearch;
        private HRJTextBox txtCustomerID;
        private HRJTextBox txtCustomerName;
        private HRJTextBox txtCustomerPoint;
        private HRJTextBox txtCustomerPhone;
        private HRJRadioButton rbtnFemale;
        private HRJRadioButton rbtnMale;
        private HRJRadioButton rbtnFalse;
        private HRJRadioButton rbtnTrue;
        private HRJButton btnAdd;
        private HRJButton btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusItem;
    }
}