namespace GUI
{
    partial class frmStaffSta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffSta));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new GUI.RJControls.RJTextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.rjCircularPictureBox1 = new GUI.RJControls.RJCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.pnQuatity = new GUI.Khoa.KhoaPanel();
            this.txtTo = new GUI.RJControls.RJTextBox();
            this.txtLessThan = new GUI.RJControls.RJTextBox();
            this.txtFrom = new GUI.RJControls.RJTextBox();
            this.txtMoreThan = new GUI.RJControls.RJTextBox();
            this.rbtbFromTo = new System.Windows.Forms.RadioButton();
            this.rbtnLessThan = new System.Windows.Forms.RadioButton();
            this.rbtnMoreThan = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDateFilter = new GUI.Khoa.KhoaPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnDatePicker = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.pnContent = new System.Windows.Forms.Panel();
            this.tbStaff = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceToSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.pnFilter.SuspendLayout();
            this.pnQuatity.SuspendLayout();
            this.pnDateFilter.SuspendLayout();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStaff)).BeginInit();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnHeader.Controls.Add(this.btnRefresh);
            this.pnHeader.Controls.Add(this.txtSearch);
            this.pnHeader.Controls.Add(this.btnExport);
            this.pnHeader.Controls.Add(this.rjCircularPictureBox1);
            this.pnHeader.Controls.Add(this.panel2);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1334, 176);
            this.pnHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::GUI.Properties.Resources.refreshing;
            this.btnRefresh.Location = new System.Drawing.Point(1162, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 45);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(278, 130);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(7, 7, 7, 5);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Tên / Mã nhân viên";
            this.txtSearch.Size = new System.Drawing.Size(271, 33);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(102)))));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::GUI.Properties.Resources.export__3_;
            this.btnExport.Location = new System.Drawing.Point(1223, 118);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(55, 45);
            this.btnExport.TabIndex = 1;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::GUI.Properties.Resources.logo_and_text_2;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(73, 69);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(101, 101);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 3;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.pbHome);
            this.panel2.Controls.Add(this.lblTitleHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 59);
            this.panel2.TabIndex = 2;
            // 
            // pbHome
            // 
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Image = global::GUI.Properties.Resources.icons8_reply_arrow_32;
            this.pbHome.Location = new System.Drawing.Point(1285, 13);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(32, 32);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHome.TabIndex = 1;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            this.pbHome.MouseEnter += new System.EventHandler(this.pbHome_MouseEnter);
            this.pbHome.MouseLeave += new System.EventHandler(this.pbHome_MouseLeave);
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.AutoSize = true;
            this.lblTitleHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeader.ForeColor = System.Drawing.Color.White;
            this.lblTitleHeader.Location = new System.Drawing.Point(512, 7);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Size = new System.Drawing.Size(323, 45);
            this.lblTitleHeader.TabIndex = 0;
            this.lblTitleHeader.Text = "Thống Kê Nhân Viên";
            // 
            // pnFilter
            // 
            this.pnFilter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnFilter.Controls.Add(this.pnQuatity);
            this.pnFilter.Controls.Add(this.pnDateFilter);
            this.pnFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFilter.Location = new System.Drawing.Point(0, 0);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(238, 535);
            this.pnFilter.TabIndex = 1;
            // 
            // pnQuatity
            // 
            this.pnQuatity.BackColor = System.Drawing.Color.White;
            this.pnQuatity.BorderRadius = 30;
            this.pnQuatity.Controls.Add(this.txtTo);
            this.pnQuatity.Controls.Add(this.txtLessThan);
            this.pnQuatity.Controls.Add(this.txtFrom);
            this.pnQuatity.Controls.Add(this.txtMoreThan);
            this.pnQuatity.Controls.Add(this.rbtbFromTo);
            this.pnQuatity.Controls.Add(this.rbtnLessThan);
            this.pnQuatity.Controls.Add(this.rbtnMoreThan);
            this.pnQuatity.Controls.Add(this.lblQuantity);
            this.pnQuatity.Controls.Add(this.label3);
            this.pnQuatity.Controls.Add(this.label5);
            this.pnQuatity.Controls.Add(this.label2);
            this.pnQuatity.Controls.Add(this.label1);
            this.pnQuatity.ForeColor = System.Drawing.Color.Black;
            this.pnQuatity.GradientAngle = 90F;
            this.pnQuatity.GradientBottomColor = System.Drawing.Color.LightSkyBlue;
            this.pnQuatity.GradientTopColor = System.Drawing.Color.LightSkyBlue;
            this.pnQuatity.Location = new System.Drawing.Point(31, 183);
            this.pnQuatity.Name = "pnQuatity";
            this.pnQuatity.Size = new System.Drawing.Size(194, 200);
            this.pnQuatity.TabIndex = 4;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.txtTo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.txtTo.BorderRadius = 0;
            this.txtTo.BorderSize = 2;
            this.txtTo.Enabled = false;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTo.Location = new System.Drawing.Point(71, 147);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Multiline = false;
            this.txtTo.Name = "txtTo";
            this.txtTo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTo.PasswordChar = false;
            this.txtTo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTo.PlaceholderText = "";
            this.txtTo.Size = new System.Drawing.Size(100, 31);
            this.txtTo.TabIndex = 6;
            this.txtTo.Texts = "";
            this.txtTo.UnderlinedStyle = true;
            this.txtTo._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.txtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            // 
            // txtLessThan
            // 
            this.txtLessThan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtLessThan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.txtLessThan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.txtLessThan.BorderRadius = 0;
            this.txtLessThan.BorderSize = 2;
            this.txtLessThan.Enabled = false;
            this.txtLessThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLessThan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLessThan.Location = new System.Drawing.Point(71, 71);
            this.txtLessThan.Margin = new System.Windows.Forms.Padding(4);
            this.txtLessThan.Multiline = false;
            this.txtLessThan.Name = "txtLessThan";
            this.txtLessThan.Padding = new System.Windows.Forms.Padding(7);
            this.txtLessThan.PasswordChar = false;
            this.txtLessThan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLessThan.PlaceholderText = "";
            this.txtLessThan.Size = new System.Drawing.Size(100, 31);
            this.txtLessThan.TabIndex = 6;
            this.txtLessThan.Texts = "";
            this.txtLessThan.UnderlinedStyle = true;
            this.txtLessThan._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.txtLessThan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.txtFrom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.txtFrom.BorderRadius = 0;
            this.txtFrom.BorderSize = 2;
            this.txtFrom.Enabled = false;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFrom.Location = new System.Drawing.Point(71, 108);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Multiline = false;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Padding = new System.Windows.Forms.Padding(7);
            this.txtFrom.PasswordChar = false;
            this.txtFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.Size = new System.Drawing.Size(100, 31);
            this.txtFrom.TabIndex = 6;
            this.txtFrom.Texts = "";
            this.txtFrom.UnderlinedStyle = true;
            this.txtFrom._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            // 
            // txtMoreThan
            // 
            this.txtMoreThan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtMoreThan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.txtMoreThan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.txtMoreThan.BorderRadius = 0;
            this.txtMoreThan.BorderSize = 2;
            this.txtMoreThan.Enabled = false;
            this.txtMoreThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoreThan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMoreThan.Location = new System.Drawing.Point(71, 33);
            this.txtMoreThan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoreThan.Multiline = false;
            this.txtMoreThan.Name = "txtMoreThan";
            this.txtMoreThan.Padding = new System.Windows.Forms.Padding(7);
            this.txtMoreThan.PasswordChar = false;
            this.txtMoreThan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMoreThan.PlaceholderText = "";
            this.txtMoreThan.Size = new System.Drawing.Size(100, 31);
            this.txtMoreThan.TabIndex = 6;
            this.txtMoreThan.Texts = "";
            this.txtMoreThan.UnderlinedStyle = true;
            this.txtMoreThan._TextChanged += new System.EventHandler(this.TextBox__TextChanged);
            this.txtMoreThan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            // 
            // rbtbFromTo
            // 
            this.rbtbFromTo.AutoSize = true;
            this.rbtbFromTo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rbtbFromTo.Location = new System.Drawing.Point(16, 122);
            this.rbtbFromTo.Name = "rbtbFromTo";
            this.rbtbFromTo.Size = new System.Drawing.Size(14, 13);
            this.rbtbFromTo.TabIndex = 4;
            this.rbtbFromTo.TabStop = true;
            this.rbtbFromTo.UseVisualStyleBackColor = false;
            this.rbtbFromTo.CheckedChanged += new System.EventHandler(this.rbtbFromTo_CheckedChanged);
            // 
            // rbtnLessThan
            // 
            this.rbtnLessThan.AutoSize = true;
            this.rbtnLessThan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rbtnLessThan.Location = new System.Drawing.Point(16, 83);
            this.rbtnLessThan.Name = "rbtnLessThan";
            this.rbtnLessThan.Size = new System.Drawing.Size(14, 13);
            this.rbtnLessThan.TabIndex = 4;
            this.rbtnLessThan.TabStop = true;
            this.rbtnLessThan.UseVisualStyleBackColor = false;
            this.rbtnLessThan.CheckedChanged += new System.EventHandler(this.rbtnLessThan_CheckedChanged);
            // 
            // rbtnMoreThan
            // 
            this.rbtnMoreThan.AutoSize = true;
            this.rbtnMoreThan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rbtnMoreThan.Location = new System.Drawing.Point(16, 45);
            this.rbtnMoreThan.Name = "rbtnMoreThan";
            this.rbtnMoreThan.Size = new System.Drawing.Size(14, 13);
            this.rbtnMoreThan.TabIndex = 4;
            this.rbtnMoreThan.TabStop = true;
            this.rbtnMoreThan.UseVisualStyleBackColor = false;
            this.rbtnMoreThan.CheckedChanged += new System.EventHandler(this.rbtnMoreThan_CheckedChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(11, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 18);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dưới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trên";
            // 
            // pnDateFilter
            // 
            this.pnDateFilter.BackColor = System.Drawing.Color.White;
            this.pnDateFilter.BorderRadius = 30;
            this.pnDateFilter.Controls.Add(this.label4);
            this.pnDateFilter.Controls.Add(this.rbtnDatePicker);
            this.pnDateFilter.Controls.Add(this.rbtnDate);
            this.pnDateFilter.Controls.Add(this.dtpDateTo);
            this.pnDateFilter.Controls.Add(this.dtpDateFrom);
            this.pnDateFilter.Controls.Add(this.lblDate);
            this.pnDateFilter.Controls.Add(this.cbDate);
            this.pnDateFilter.ForeColor = System.Drawing.Color.Black;
            this.pnDateFilter.GradientAngle = 90F;
            this.pnDateFilter.GradientBottomColor = System.Drawing.Color.LightSkyBlue;
            this.pnDateFilter.GradientTopColor = System.Drawing.Color.LightSkyBlue;
            this.pnDateFilter.Location = new System.Drawing.Point(31, 11);
            this.pnDateFilter.Name = "pnDateFilter";
            this.pnDateFilter.Size = new System.Drawing.Size(194, 154);
            this.pnDateFilter.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 92);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnDatePicker
            // 
            this.rbtnDatePicker.AutoSize = true;
            this.rbtnDatePicker.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rbtnDatePicker.Location = new System.Drawing.Point(16, 73);
            this.rbtnDatePicker.Name = "rbtnDatePicker";
            this.rbtnDatePicker.Size = new System.Drawing.Size(14, 13);
            this.rbtnDatePicker.TabIndex = 4;
            this.rbtnDatePicker.TabStop = true;
            this.rbtnDatePicker.UseVisualStyleBackColor = false;
            this.rbtnDatePicker.CheckedChanged += new System.EventHandler(this.rbtnDatePicker_CheckedChanged);
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rbtnDate.Location = new System.Drawing.Point(16, 41);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(14, 13);
            this.rbtnDate.TabIndex = 4;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.UseVisualStyleBackColor = false;
            this.rbtnDate.CheckedChanged += new System.EventHandler(this.rbtnDate_CheckedChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(37, 110);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(134, 23);
            this.dtpDateTo.TabIndex = 2;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(37, 69);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(134, 23);
            this.dtpDateFrom.TabIndex = 2;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 18);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Thời gian";
            // 
            // cbDate
            // 
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.Enabled = false;
            this.cbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(37, 37);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(134, 24);
            this.cbDate.TabIndex = 0;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnContent.Controls.Add(this.tbStaff);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(238, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1096, 535);
            this.pnContent.TabIndex = 2;
            // 
            // tbStaff
            // 
            this.tbStaff.AllowUserToAddRows = false;
            this.tbStaff.AllowUserToDeleteRows = false;
            this.tbStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbStaff.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbStaff.ColumnHeadersHeight = 40;
            this.tbStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Quantity,
            this.PriceToSell});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbStaff.DefaultCellStyle = dataGridViewCellStyle5;
            this.tbStaff.EnableHeadersVisualStyles = false;
            this.tbStaff.GridColor = System.Drawing.Color.White;
            this.tbStaff.Location = new System.Drawing.Point(40, 11);
            this.tbStaff.Name = "tbStaff";
            this.tbStaff.ReadOnly = true;
            this.tbStaff.RowHeadersVisible = false;
            this.tbStaff.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.tbStaff.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tbStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbStaff.Size = new System.Drawing.Size(1000, 485);
            this.tbStaff.TabIndex = 0;
            this.tbStaff.Paint += new System.Windows.Forms.PaintEventHandler(this.tbProduct_Paint);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "StaffId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductId.HeaderText = "Mã nhân viên";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductId.Width = 120;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "StaffName";
            this.ProductName.FillWeight = 300F;
            this.ProductName.HeaderText = "Tên nhân viên";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "NumberPhone";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.FillWeight = 300F;
            this.Quantity.HeaderText = "Số điện thoại";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PriceToSell
            // 
            this.PriceToSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceToSell.DataPropertyName = "Revenue";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PriceToSell.DefaultCellStyle = dataGridViewCellStyle4;
            this.PriceToSell.FillWeight = 280F;
            this.PriceToSell.HeaderText = "Doanh thu";
            this.PriceToSell.Name = "PriceToSell";
            this.PriceToSell.ReadOnly = true;
            this.PriceToSell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnContent);
            this.pnBody.Controls.Add(this.pnFilter);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 176);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1334, 535);
            this.pnBody.TabIndex = 2;
            // 
            // frmStaffSta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStaffSta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê nhân viên";
            this.Load += new System.EventHandler(this.frmProductSta_Load);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.pnFilter.ResumeLayout(false);
            this.pnQuatity.ResumeLayout(false);
            this.pnQuatity.PerformLayout();
            this.pnDateFilter.ResumeLayout(false);
            this.pnDateFilter.PerformLayout();
            this.pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbStaff)).EndInit();
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Khoa.KhoaPanel pnDateFilter;
        private System.Windows.Forms.RadioButton rbtnDate;
        private Khoa.KhoaPanel pnQuatity;
        private System.Windows.Forms.RadioButton rbtnDatePicker;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.RadioButton rbtbFromTo;
        private System.Windows.Forms.RadioButton rbtnLessThan;
        private System.Windows.Forms.RadioButton rbtnMoreThan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleHeader;
        private RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.DataGridView tbStaff;
        private System.Windows.Forms.PictureBox pbHome;
        private RJControls.RJTextBox txtMoreThan;
        private RJControls.RJTextBox txtLessThan;
        private RJControls.RJTextBox txtTo;
        private RJControls.RJTextBox txtFrom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceToSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}