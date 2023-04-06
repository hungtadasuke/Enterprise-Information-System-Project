namespace GUI
{
    partial class frmProductSta
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSta));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTableView = new System.Windows.Forms.Button();
            this.btnChartView = new System.Windows.Forms.Button();
            this.txtSearch = new GUI.RJControls.RJTextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.rjCircularPictureBox1 = new GUI.RJControls.RJCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.pnCategory = new GUI.Khoa.KhoaPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.pnQuatity = new GUI.Khoa.KhoaPanel();
            this.txtTo = new GUI.RJControls.RJTextBox();
            this.txtLessThan = new GUI.RJControls.RJTextBox();
            this.txtFrom = new GUI.RJControls.RJTextBox();
            this.txtMoreThan = new GUI.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtbFromTo = new System.Windows.Forms.RadioButton();
            this.rbtnLessThan = new System.Windows.Forms.RadioButton();
            this.rbtnMoreThan = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDateFilter = new GUI.Khoa.KhoaPanel();
            this.pnContentChart = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnDatePicker = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.pnContent = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbTotalTitle = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.DataGridView();
            this.pnBody = new System.Windows.Forms.Panel();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceToSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.pnFilter.SuspendLayout();
            this.pnCategory.SuspendLayout();
            this.pnQuatity.SuspendLayout();
            this.pnDateFilter.SuspendLayout();
            this.pnContentChart.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduct)).BeginInit();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnHeader.Controls.Add(this.btnRefresh);
            this.pnHeader.Controls.Add(this.btnTableView);
            this.pnHeader.Controls.Add(this.btnChartView);
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
            // btnTableView
            // 
            this.btnTableView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableView.Image = global::GUI.Properties.Resources.table;
            this.btnTableView.Location = new System.Drawing.Point(1040, 118);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(55, 45);
            this.btnTableView.TabIndex = 5;
            this.btnTableView.UseVisualStyleBackColor = true;
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click);
            // 
            // btnChartView
            // 
            this.btnChartView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChartView.Image = global::GUI.Properties.Resources.bar_chart;
            this.btnChartView.Location = new System.Drawing.Point(1101, 118);
            this.btnChartView.Name = "btnChartView";
            this.btnChartView.Size = new System.Drawing.Size(55, 45);
            this.btnChartView.TabIndex = 5;
            this.btnChartView.UseVisualStyleBackColor = true;
            this.btnChartView.Click += new System.EventHandler(this.btnChartView_Click);
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
            this.txtSearch.PlaceholderText = "Tên / Mã hàng hóa";
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
            this.lblTitleHeader.Size = new System.Drawing.Size(317, 45);
            this.lblTitleHeader.TabIndex = 0;
            this.lblTitleHeader.Text = "Thống Kê Hàng Hóa";
            // 
            // pnFilter
            // 
            this.pnFilter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnFilter.Controls.Add(this.pnCategory);
            this.pnFilter.Controls.Add(this.pnQuatity);
            this.pnFilter.Controls.Add(this.pnDateFilter);
            this.pnFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFilter.Location = new System.Drawing.Point(0, 0);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(238, 535);
            this.pnFilter.TabIndex = 1;
            // 
            // pnCategory
            // 
            this.pnCategory.BackColor = System.Drawing.Color.White;
            this.pnCategory.BorderRadius = 30;
            this.pnCategory.Controls.Add(this.lblCategory);
            this.pnCategory.Controls.Add(this.cbCategory);
            this.pnCategory.ForeColor = System.Drawing.Color.Black;
            this.pnCategory.GradientAngle = 90F;
            this.pnCategory.GradientBottomColor = System.Drawing.Color.LightSkyBlue;
            this.pnCategory.GradientTopColor = System.Drawing.Color.LightSkyBlue;
            this.pnCategory.Location = new System.Drawing.Point(31, 354);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(194, 72);
            this.pnCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(11, 10);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 18);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Loại hàng";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(37, 36);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(134, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // pnQuatity
            // 
            this.pnQuatity.BackColor = System.Drawing.Color.White;
            this.pnQuatity.BorderRadius = 30;
            this.pnQuatity.Controls.Add(this.txtTo);
            this.pnQuatity.Controls.Add(this.txtLessThan);
            this.pnQuatity.Controls.Add(this.txtFrom);
            this.pnQuatity.Controls.Add(this.txtMoreThan);
            this.pnQuatity.Controls.Add(this.label3);
            this.pnQuatity.Controls.Add(this.rbtbFromTo);
            this.pnQuatity.Controls.Add(this.rbtnLessThan);
            this.pnQuatity.Controls.Add(this.rbtnMoreThan);
            this.pnQuatity.Controls.Add(this.lblQuantity);
            this.pnQuatity.Controls.Add(this.label2);
            this.pnQuatity.Controls.Add(this.label1);
            this.pnQuatity.ForeColor = System.Drawing.Color.Black;
            this.pnQuatity.GradientAngle = 90F;
            this.pnQuatity.GradientBottomColor = System.Drawing.Color.LightSkyBlue;
            this.pnQuatity.GradientTopColor = System.Drawing.Color.LightSkyBlue;
            this.pnQuatity.Location = new System.Drawing.Point(31, 183);
            this.pnQuatity.Name = "pnQuatity";
            this.pnQuatity.Size = new System.Drawing.Size(194, 155);
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
            this.txtTo.Location = new System.Drawing.Point(121, 113);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Multiline = false;
            this.txtTo.Name = "txtTo";
            this.txtTo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTo.PasswordChar = false;
            this.txtTo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTo.PlaceholderText = "";
            this.txtTo.Size = new System.Drawing.Size(50, 31);
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
            this.txtFrom.Location = new System.Drawing.Point(37, 113);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Multiline = false;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Padding = new System.Windows.Forms.Padding(7);
            this.txtFrom.PasswordChar = false;
            this.txtFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.Size = new System.Drawing.Size(50, 31);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
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
            this.lblQuantity.Size = new System.Drawing.Size(95, 18);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Số lượng bán";
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
            this.pnDateFilter.Controls.Add(this.pnContentChart);
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
            // pnContentChart
            // 
            this.pnContentChart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnContentChart.Controls.Add(this.tableLayoutPanel1);
            this.pnContentChart.Location = new System.Drawing.Point(121, 18);
            this.pnContentChart.Name = "pnContentChart";
            this.pnContentChart.Size = new System.Drawing.Size(1075, 503);
            this.pnContentChart.TabIndex = 1;
            this.pnContentChart.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 455);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng đã bán";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(585, 449);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(594, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Segoe UI", 12F);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(388, 449);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            title1.Name = "Title1";
            title1.Text = "Top 5 sản phẩm bán chạy";
            this.chart2.Titles.Add(title1);
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
            this.pnContent.Controls.Add(this.lblTotal);
            this.pnContent.Controls.Add(this.lbTotalTitle);
            this.pnContent.Controls.Add(this.tbProduct);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(238, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1096, 535);
            this.pnContent.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(855, 454);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(185, 32);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "10.000.000 đ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalTitle
            // 
            this.lbTotalTitle.AutoSize = true;
            this.lbTotalTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTitle.Location = new System.Drawing.Point(715, 451);
            this.lbTotalTitle.Name = "lbTotalTitle";
            this.lbTotalTitle.Size = new System.Drawing.Size(135, 32);
            this.lbTotalTitle.TabIndex = 1;
            this.lbTotalTitle.Text = "Tổng cộng:";
            // 
            // tbProduct
            // 
            this.tbProduct.AllowUserToAddRows = false;
            this.tbProduct.AllowUserToDeleteRows = false;
            this.tbProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbProduct.ColumnHeadersHeight = 40;
            this.tbProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Quantity,
            this.PriceToSell,
            this.Status,
            this.Sold,
            this.Revenue});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.tbProduct.EnableHeadersVisualStyles = false;
            this.tbProduct.GridColor = System.Drawing.Color.White;
            this.tbProduct.Location = new System.Drawing.Point(40, 11);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.ReadOnly = true;
            this.tbProduct.RowHeadersVisible = false;
            this.tbProduct.RowHeadersWidth = 40;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.tbProduct.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tbProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbProduct.Size = new System.Drawing.Size(1000, 415);
            this.tbProduct.TabIndex = 0;
            this.tbProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.tbProduct_Paint);
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
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductId.HeaderText = "Mã hàng hóa";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductId.Width = 120;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 220F;
            this.ProductName.HeaderText = "Tên hàng hóa";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.HeaderText = "Tồn kho";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 80;
            // 
            // PriceToSell
            // 
            this.PriceToSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceToSell.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PriceToSell.DefaultCellStyle = dataGridViewCellStyle4;
            this.PriceToSell.FillWeight = 120F;
            this.PriceToSell.HeaderText = "Giá bán";
            this.PriceToSell.Name = "PriceToSell";
            this.PriceToSell.ReadOnly = true;
            this.PriceToSell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusItem";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle5;
            this.Status.FillWeight = 160F;
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Width = 90;
            // 
            // Sold
            // 
            this.Sold.DataPropertyName = "QuantitySold";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sold.DefaultCellStyle = dataGridViewCellStyle6;
            this.Sold.HeaderText = "Đã bán";
            this.Sold.Name = "Sold";
            this.Sold.ReadOnly = true;
            this.Sold.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sold.Width = 80;
            // 
            // Revenue
            // 
            this.Revenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Revenue.DataPropertyName = "Revenue";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Revenue.DefaultCellStyle = dataGridViewCellStyle7;
            this.Revenue.FillWeight = 160F;
            this.Revenue.HeaderText = "Doanh thu";
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            this.Revenue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmProductSta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductSta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hàng hóa";
            this.Load += new System.EventHandler(this.frmProductSta_Load);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.pnFilter.ResumeLayout(false);
            this.pnCategory.ResumeLayout(false);
            this.pnCategory.PerformLayout();
            this.pnQuatity.ResumeLayout(false);
            this.pnQuatity.PerformLayout();
            this.pnDateFilter.ResumeLayout(false);
            this.pnDateFilter.PerformLayout();
            this.pnContentChart.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProduct)).EndInit();
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Khoa.KhoaPanel pnDateFilter;
        private System.Windows.Forms.RadioButton rbtnDate;
        private Khoa.KhoaPanel pnQuatity;
        private System.Windows.Forms.RadioButton rbtnDatePicker;
        private Khoa.KhoaPanel pnCategory;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.RadioButton rbtbFromTo;
        private System.Windows.Forms.RadioButton rbtnLessThan;
        private System.Windows.Forms.RadioButton rbtnMoreThan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleHeader;
        private RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.Button btnChartView;
        private System.Windows.Forms.Panel pnContentChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView tbProduct;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Button btnTableView;
        private RJControls.RJTextBox txtMoreThan;
        private RJControls.RJTextBox txtLessThan;
        private RJControls.RJTextBox txtTo;
        private RJControls.RJTextBox txtFrom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbTotalTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceToSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
    }
}