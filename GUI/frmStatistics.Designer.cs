namespace GUI
{
    partial class frmStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.pnContentContainer = new System.Windows.Forms.Panel();
            this.pnContentCenter = new System.Windows.Forms.Panel();
            this.tlpnContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnStaffStatistics = new System.Windows.Forms.Panel();
            this.pbStaff = new System.Windows.Forms.PictureBox();
            this.lblStaffNumber = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.pnCustomerStatistics = new System.Windows.Forms.Panel();
            this.pbCustomer = new System.Windows.Forms.PictureBox();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pnProductStatistics = new System.Windows.Forms.Panel();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnRevenueStatistics = new System.Windows.Forms.Panel();
            this.pbRevenue = new System.Windows.Forms.PictureBox();
            this.lblRevenueToday = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.pnContentLeft = new System.Windows.Forms.Panel();
            this.pnContentBottom = new System.Windows.Forms.Panel();
            this.pnContentRight = new System.Windows.Forms.Panel();
            this.pnContentTop = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.pnContentContainer.SuspendLayout();
            this.pnContentCenter.SuspendLayout();
            this.tlpnContent.SuspendLayout();
            this.pnStaffStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).BeginInit();
            this.pnCustomerStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            this.pnProductStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.pnRevenueStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.pnHeader.Controls.Add(this.pbHome);
            this.pnHeader.Controls.Add(this.lblTitleHeader);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnHeader.Size = new System.Drawing.Size(1250, 80);
            this.pnHeader.TabIndex = 0;
            // 
            // pbHome
            // 
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Image = global::GUI.Properties.Resources.icons8_home_page_32;
            this.pbHome.Location = new System.Drawing.Point(1193, 23);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(32, 32);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHome.TabIndex = 2;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            this.pbHome.MouseEnter += new System.EventHandler(this.pbHome_MouseEnter);
            this.pbHome.MouseLeave += new System.EventHandler(this.pbHome_MouseLeave);
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleHeader.AutoSize = true;
            this.lblTitleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.lblTitleHeader.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeader.ForeColor = System.Drawing.Color.White;
            this.lblTitleHeader.Location = new System.Drawing.Point(418, 13);
            this.lblTitleHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Size = new System.Drawing.Size(414, 54);
            this.lblTitleHeader.TabIndex = 0;
            this.lblTitleHeader.Text = "BÁO CÁO THỐNG KÊ";
            this.lblTitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContentContainer
            // 
            this.pnContentContainer.Controls.Add(this.pnContentCenter);
            this.pnContentContainer.Controls.Add(this.pnContentLeft);
            this.pnContentContainer.Controls.Add(this.pnContentBottom);
            this.pnContentContainer.Controls.Add(this.pnContentRight);
            this.pnContentContainer.Controls.Add(this.pnContentTop);
            this.pnContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContentContainer.Location = new System.Drawing.Point(0, 80);
            this.pnContentContainer.Name = "pnContentContainer";
            this.pnContentContainer.Size = new System.Drawing.Size(1250, 571);
            this.pnContentContainer.TabIndex = 1;
            // 
            // pnContentCenter
            // 
            this.pnContentCenter.BackColor = System.Drawing.Color.RosyBrown;
            this.pnContentCenter.Controls.Add(this.tlpnContent);
            this.pnContentCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContentCenter.Location = new System.Drawing.Point(230, 80);
            this.pnContentCenter.Name = "pnContentCenter";
            this.pnContentCenter.Size = new System.Drawing.Size(790, 411);
            this.pnContentCenter.TabIndex = 5;
            // 
            // tlpnContent
            // 
            this.tlpnContent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpnContent.ColumnCount = 2;
            this.tlpnContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnContent.Controls.Add(this.pnStaffStatistics, 0, 1);
            this.tlpnContent.Controls.Add(this.pnCustomerStatistics, 0, 1);
            this.tlpnContent.Controls.Add(this.pnProductStatistics, 0, 0);
            this.tlpnContent.Controls.Add(this.pnRevenueStatistics, 1, 0);
            this.tlpnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnContent.Location = new System.Drawing.Point(0, 0);
            this.tlpnContent.Margin = new System.Windows.Forms.Padding(0);
            this.tlpnContent.Name = "tlpnContent";
            this.tlpnContent.RowCount = 2;
            this.tlpnContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnContent.Size = new System.Drawing.Size(790, 411);
            this.tlpnContent.TabIndex = 0;
            // 
            // pnStaffStatistics
            // 
            this.pnStaffStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnStaffStatistics.Controls.Add(this.pbStaff);
            this.pnStaffStatistics.Controls.Add(this.lblStaffNumber);
            this.pnStaffStatistics.Controls.Add(this.lblStaff);
            this.pnStaffStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnStaffStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStaffStatistics.Location = new System.Drawing.Point(3, 225);
            this.pnStaffStatistics.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
            this.pnStaffStatistics.Name = "pnStaffStatistics";
            this.pnStaffStatistics.Size = new System.Drawing.Size(372, 183);
            this.pnStaffStatistics.TabIndex = 3;
            this.pnStaffStatistics.Click += new System.EventHandler(this.pnStaffStatistics_Click);
            // 
            // pbStaff
            // 
            this.pbStaff.Image = global::GUI.Properties.Resources.icons8_staff_100;
            this.pbStaff.Location = new System.Drawing.Point(236, 40);
            this.pbStaff.Name = "pbStaff";
            this.pbStaff.Size = new System.Drawing.Size(111, 103);
            this.pbStaff.TabIndex = 4;
            this.pbStaff.TabStop = false;
            this.pbStaff.Click += new System.EventHandler(this.pnStaffStatistics_Click);
            // 
            // lblStaffNumber
            // 
            this.lblStaffNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffNumber.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblStaffNumber.ForeColor = System.Drawing.Color.White;
            this.lblStaffNumber.Location = new System.Drawing.Point(4, 56);
            this.lblStaffNumber.Name = "lblStaffNumber";
            this.lblStaffNumber.Padding = new System.Windows.Forms.Padding(6);
            this.lblStaffNumber.Size = new System.Drawing.Size(180, 87);
            this.lblStaffNumber.TabIndex = 1;
            this.lblStaffNumber.Text = "40";
            this.lblStaffNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStaffNumber.Click += new System.EventHandler(this.pnStaffStatistics_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.lblStaff.ForeColor = System.Drawing.Color.White;
            this.lblStaff.Location = new System.Drawing.Point(4, 6);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Padding = new System.Windows.Forms.Padding(6);
            this.lblStaff.Size = new System.Drawing.Size(180, 52);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "Nhân viên";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStaff.Click += new System.EventHandler(this.pnStaffStatistics_Click);
            // 
            // pnCustomerStatistics
            // 
            this.pnCustomerStatistics.BackColor = System.Drawing.Color.Gray;
            this.pnCustomerStatistics.Controls.Add(this.pbCustomer);
            this.pnCustomerStatistics.Controls.Add(this.lblCustomerNumber);
            this.pnCustomerStatistics.Controls.Add(this.lblCustomer);
            this.pnCustomerStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnCustomerStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCustomerStatistics.Location = new System.Drawing.Point(415, 225);
            this.pnCustomerStatistics.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.pnCustomerStatistics.Name = "pnCustomerStatistics";
            this.pnCustomerStatistics.Size = new System.Drawing.Size(372, 183);
            this.pnCustomerStatistics.TabIndex = 2;
            this.pnCustomerStatistics.Click += new System.EventHandler(this.pnCustomerStatistics_Click);
            // 
            // pbCustomer
            // 
            this.pbCustomer.Image = global::GUI.Properties.Resources.icons8_employees_100;
            this.pbCustomer.Location = new System.Drawing.Point(243, 40);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(111, 103);
            this.pbCustomer.TabIndex = 4;
            this.pbCustomer.TabStop = false;
            this.pbCustomer.Click += new System.EventHandler(this.pnCustomerStatistics_Click);
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerNumber.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblCustomerNumber.ForeColor = System.Drawing.Color.White;
            this.lblCustomerNumber.Location = new System.Drawing.Point(4, 56);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Padding = new System.Windows.Forms.Padding(6);
            this.lblCustomerNumber.Size = new System.Drawing.Size(180, 87);
            this.lblCustomerNumber.TabIndex = 1;
            this.lblCustomerNumber.Text = "60";
            this.lblCustomerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustomerNumber.Click += new System.EventHandler(this.pnCustomerStatistics_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(4, 6);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Padding = new System.Windows.Forms.Padding(6);
            this.lblCustomer.Size = new System.Drawing.Size(180, 52);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Khách hàng";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustomer.Click += new System.EventHandler(this.pnCustomerStatistics_Click);
            // 
            // pnProductStatistics
            // 
            this.pnProductStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnProductStatistics.Controls.Add(this.pbProduct);
            this.pnProductStatistics.Controls.Add(this.lblProductNumber);
            this.pnProductStatistics.Controls.Add(this.lblProduct);
            this.pnProductStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnProductStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProductStatistics.Location = new System.Drawing.Point(3, 3);
            this.pnProductStatistics.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.pnProductStatistics.Name = "pnProductStatistics";
            this.pnProductStatistics.Size = new System.Drawing.Size(372, 182);
            this.pnProductStatistics.TabIndex = 0;
            this.pnProductStatistics.Click += new System.EventHandler(this.pnProductStatistics_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.Image = global::GUI.Properties.Resources.icons8_ingredients_100;
            this.pbProduct.Location = new System.Drawing.Point(236, 40);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(111, 103);
            this.pbProduct.TabIndex = 4;
            this.pbProduct.TabStop = false;
            this.pbProduct.Click += new System.EventHandler(this.pnProductStatistics_Click);
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductNumber.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNumber.ForeColor = System.Drawing.Color.White;
            this.lblProductNumber.Location = new System.Drawing.Point(4, 56);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Padding = new System.Windows.Forms.Padding(6);
            this.lblProductNumber.Size = new System.Drawing.Size(180, 87);
            this.lblProductNumber.TabIndex = 1;
            this.lblProductNumber.Text = "40";
            this.lblProductNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductNumber.Click += new System.EventHandler(this.pnProductStatistics_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(4, 6);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Padding = new System.Windows.Forms.Padding(6);
            this.lblProduct.Size = new System.Drawing.Size(180, 52);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Hàng hóa";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProduct.Click += new System.EventHandler(this.pnProductStatistics_Click);
            // 
            // pnRevenueStatistics
            // 
            this.pnRevenueStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnRevenueStatistics.Controls.Add(this.pbRevenue);
            this.pnRevenueStatistics.Controls.Add(this.lblRevenueToday);
            this.pnRevenueStatistics.Controls.Add(this.lblRevenue);
            this.pnRevenueStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnRevenueStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRevenueStatistics.Location = new System.Drawing.Point(415, 3);
            this.pnRevenueStatistics.Margin = new System.Windows.Forms.Padding(20, 3, 3, 20);
            this.pnRevenueStatistics.Name = "pnRevenueStatistics";
            this.pnRevenueStatistics.Size = new System.Drawing.Size(372, 182);
            this.pnRevenueStatistics.TabIndex = 1;
            this.pnRevenueStatistics.Click += new System.EventHandler(this.pnRevenueStatistics_Click);
            // 
            // pbRevenue
            // 
            this.pbRevenue.Image = global::GUI.Properties.Resources.icons8_combo_chart_100;
            this.pbRevenue.Location = new System.Drawing.Point(243, 40);
            this.pbRevenue.Name = "pbRevenue";
            this.pbRevenue.Size = new System.Drawing.Size(111, 103);
            this.pbRevenue.TabIndex = 4;
            this.pbRevenue.TabStop = false;
            this.pbRevenue.Click += new System.EventHandler(this.pnRevenueStatistics_Click);
            // 
            // lblRevenueToday
            // 
            this.lblRevenueToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRevenueToday.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblRevenueToday.ForeColor = System.Drawing.Color.White;
            this.lblRevenueToday.Location = new System.Drawing.Point(4, 56);
            this.lblRevenueToday.Name = "lblRevenueToday";
            this.lblRevenueToday.Padding = new System.Windows.Forms.Padding(6);
            this.lblRevenueToday.Size = new System.Drawing.Size(240, 87);
            this.lblRevenueToday.TabIndex = 1;
            this.lblRevenueToday.Text = "500.000.000 đ";
            this.lblRevenueToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRevenueToday.Click += new System.EventHandler(this.pnRevenueStatistics_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Location = new System.Drawing.Point(4, 6);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Padding = new System.Windows.Forms.Padding(6);
            this.lblRevenue.Size = new System.Drawing.Size(240, 52);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "Doanh thu";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRevenue.Click += new System.EventHandler(this.pnRevenueStatistics_Click);
            // 
            // pnContentLeft
            // 
            this.pnContentLeft.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnContentLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnContentLeft.Location = new System.Drawing.Point(0, 80);
            this.pnContentLeft.Name = "pnContentLeft";
            this.pnContentLeft.Size = new System.Drawing.Size(230, 411);
            this.pnContentLeft.TabIndex = 4;
            // 
            // pnContentBottom
            // 
            this.pnContentBottom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnContentBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnContentBottom.Location = new System.Drawing.Point(0, 491);
            this.pnContentBottom.Name = "pnContentBottom";
            this.pnContentBottom.Size = new System.Drawing.Size(1020, 80);
            this.pnContentBottom.TabIndex = 3;
            // 
            // pnContentRight
            // 
            this.pnContentRight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnContentRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnContentRight.Location = new System.Drawing.Point(1020, 80);
            this.pnContentRight.Name = "pnContentRight";
            this.pnContentRight.Size = new System.Drawing.Size(230, 491);
            this.pnContentRight.TabIndex = 2;
            // 
            // pnContentTop
            // 
            this.pnContentTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnContentTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContentTop.Location = new System.Drawing.Point(0, 0);
            this.pnContentTop.Name = "pnContentTop";
            this.pnContentTop.Size = new System.Drawing.Size(1250, 80);
            this.pnContentTop.TabIndex = 1;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 651);
            this.Controls.Add(this.pnContentContainer);
            this.Controls.Add(this.pnHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStatistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.pnContentContainer.ResumeLayout(false);
            this.pnContentCenter.ResumeLayout(false);
            this.tlpnContent.ResumeLayout(false);
            this.pnStaffStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStaff)).EndInit();
            this.pnCustomerStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            this.pnProductStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.pnRevenueStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblTitleHeader;
        private System.Windows.Forms.Panel pnContentContainer;
        private System.Windows.Forms.Panel pnContentLeft;
        private System.Windows.Forms.Panel pnContentBottom;
        private System.Windows.Forms.Panel pnContentRight;
        private System.Windows.Forms.Panel pnContentTop;
        private System.Windows.Forms.Panel pnContentCenter;
        private System.Windows.Forms.TableLayoutPanel tlpnContent;
        private System.Windows.Forms.Panel pnProductStatistics;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.Panel pnStaffStatistics;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Panel pnCustomerStatistics;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel pnRevenueStatistics;
        private System.Windows.Forms.Label lblRevenueToday;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.PictureBox pbRevenue;
        private System.Windows.Forms.Label lblStaffNumber;
        private System.Windows.Forms.PictureBox pbStaff;
        private System.Windows.Forms.PictureBox pbCustomer;
    }
}