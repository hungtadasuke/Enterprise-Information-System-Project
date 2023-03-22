namespace GUI
{
    partial class frmInventoryReceivingVoucherDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryReceivingVoucherDetail));
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblOweShow = new System.Windows.Forms.Label();
            this.lblOwe = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPaidShow = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotalShow = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtIRVId = new System.Windows.Forms.TextBox();
            this.lblIRVId = new System.Windows.Forms.Label();
            this.flowLayoutPanelHintProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.pictureBoxAddProduct = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackWard = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanelHintProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackWard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.AutoScroll = true;
            this.flowLayoutPanelProduct.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(12, 114);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(825, 585);
            this.flowLayoutPanelProduct.TabIndex = 0;
            this.flowLayoutPanelProduct.Click += new System.EventHandler(this.flowLayoutPanelProduct_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 41);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(697, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(589, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hàng";
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.SystemColors.Control;
            this.panelDetail.Controls.Add(this.comboBoxSupplier);
            this.panelDetail.Controls.Add(this.panel9);
            this.panelDetail.Controls.Add(this.panel8);
            this.panelDetail.Controls.Add(this.btnPay);
            this.panelDetail.Controls.Add(this.btnComplete);
            this.panelDetail.Controls.Add(this.panel7);
            this.panelDetail.Controls.Add(this.txtStaff);
            this.panelDetail.Controls.Add(this.dateTimePickerDate);
            this.panelDetail.Controls.Add(this.panel4);
            this.panelDetail.Controls.Add(this.panel5);
            this.panelDetail.Controls.Add(this.panel6);
            this.panelDetail.Controls.Add(this.panel3);
            this.panelDetail.Controls.Add(this.lblSupplier);
            this.panelDetail.Controls.Add(this.lblStaff);
            this.panelDetail.Controls.Add(this.lblDate);
            this.panelDetail.Controls.Add(this.txtIRVId);
            this.panelDetail.Controls.Add(this.lblIRVId);
            this.panelDetail.Location = new System.Drawing.Point(843, 73);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(479, 626);
            this.panelDetail.TabIndex = 1;
            this.panelDetail.Click += new System.EventHandler(this.panelDetail_Click);
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(183, 246);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(246, 29);
            this.comboBoxSupplier.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblOweShow);
            this.panel9.Controls.Add(this.lblOwe);
            this.panel9.Location = new System.Drawing.Point(43, 404);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(384, 25);
            this.panel9.TabIndex = 16;
            // 
            // lblOweShow
            // 
            this.lblOweShow.AutoSize = true;
            this.lblOweShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOweShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOweShow.Location = new System.Drawing.Point(365, 0);
            this.lblOweShow.Name = "lblOweShow";
            this.lblOweShow.Size = new System.Drawing.Size(19, 21);
            this.lblOweShow.TabIndex = 12;
            this.lblOweShow.Text = "0";
            // 
            // lblOwe
            // 
            this.lblOwe.AutoSize = true;
            this.lblOwe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOwe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwe.Location = new System.Drawing.Point(0, 0);
            this.lblOwe.Name = "lblOwe";
            this.lblOwe.Size = new System.Drawing.Size(45, 21);
            this.lblOwe.TabIndex = 11;
            this.lblOwe.Text = "Nợ : ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblPaidShow);
            this.panel8.Controls.Add(this.lblPaid);
            this.panel8.Location = new System.Drawing.Point(43, 355);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(384, 25);
            this.panel8.TabIndex = 14;
            // 
            // lblPaidShow
            // 
            this.lblPaidShow.AutoSize = true;
            this.lblPaidShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPaidShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidShow.Location = new System.Drawing.Point(365, 0);
            this.lblPaidShow.Name = "lblPaidShow";
            this.lblPaidShow.Size = new System.Drawing.Size(19, 21);
            this.lblPaidShow.TabIndex = 12;
            this.lblPaidShow.Text = "0";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(0, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(64, 21);
            this.lblPaid.TabIndex = 11;
            this.lblPaid.Text = "Đã trả :";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = global::GUI.Properties.Resources.payIRV;
            this.btnPay.Location = new System.Drawing.Point(47, 517);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(130, 66);
            this.btnPay.TabIndex = 15;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            this.btnPay.MouseEnter += new System.EventHandler(this.btnPay_MouseEnter);
            this.btnPay.MouseLeave += new System.EventHandler(this.btnPay_MouseLeave);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Image = global::GUI.Properties.Resources.check;
            this.btnComplete.Location = new System.Drawing.Point(197, 515);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(232, 66);
            this.btnComplete.TabIndex = 14;
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            this.btnComplete.MouseEnter += new System.EventHandler(this.btnComplete_MouseEnter);
            this.btnComplete.MouseLeave += new System.EventHandler(this.btnComplete_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblTotalShow);
            this.panel7.Controls.Add(this.lblTotal);
            this.panel7.Location = new System.Drawing.Point(43, 304);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 25);
            this.panel7.TabIndex = 13;
            // 
            // lblTotalShow
            // 
            this.lblTotalShow.AutoSize = true;
            this.lblTotalShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalShow.Location = new System.Drawing.Point(365, 0);
            this.lblTotalShow.Name = "lblTotalShow";
            this.lblTotalShow.Size = new System.Drawing.Size(19, 21);
            this.lblTotalShow.TabIndex = 12;
            this.lblTotalShow.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 21);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Tổng tiền : ";
            // 
            // txtStaff
            // 
            this.txtStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.Location = new System.Drawing.Point(183, 187);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(246, 29);
            this.txtStaff.TabIndex = 9;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(183, 133);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(246, 29);
            this.dateTimePickerDate.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 1);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 625);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(477, 1);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(478, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 626);
            this.panel6.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 626);
            this.panel3.TabIndex = 6;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(41, 249);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(119, 21);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Nhà Cung Cấp";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(41, 190);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(91, 21);
            this.lblStaff.TabIndex = 3;
            this.lblStaff.Text = "Nhân Viên";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(41, 132);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 21);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Ngày Tạo";
            // 
            // txtIRVId
            // 
            this.txtIRVId.Enabled = false;
            this.txtIRVId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIRVId.Location = new System.Drawing.Point(183, 69);
            this.txtIRVId.Name = "txtIRVId";
            this.txtIRVId.Size = new System.Drawing.Size(246, 29);
            this.txtIRVId.TabIndex = 1;
            // 
            // lblIRVId
            // 
            this.lblIRVId.AutoSize = true;
            this.lblIRVId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRVId.Location = new System.Drawing.Point(41, 72);
            this.lblIRVId.Name = "lblIRVId";
            this.lblIRVId.Size = new System.Drawing.Size(136, 21);
            this.lblIRVId.TabIndex = 0;
            this.lblIRVId.Text = "Mã Phiếu Nhập  ";
            // 
            // flowLayoutPanelHintProduct
            // 
            this.flowLayoutPanelHintProduct.AutoScroll = true;
            this.flowLayoutPanelHintProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanelHintProduct.Controls.Add(this.panel10);
            this.flowLayoutPanelHintProduct.Location = new System.Drawing.Point(91, 54);
            this.flowLayoutPanelHintProduct.Name = "flowLayoutPanelHintProduct";
            this.flowLayoutPanelHintProduct.Size = new System.Drawing.Size(420, 194);
            this.flowLayoutPanelHintProduct.TabIndex = 22;
            this.flowLayoutPanelHintProduct.Visible = false;
            this.flowLayoutPanelHintProduct.MouseEnter += new System.EventHandler(this.pictureBoxBackWard_MouseEnter);
            this.flowLayoutPanelHintProduct.MouseLeave += new System.EventHandler(this.pictureBoxHome_MouseLeave);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Red;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 0);
            this.panel10.TabIndex = 0;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchProduct.Location = new System.Drawing.Point(91, 22);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(404, 29);
            this.txtSearchProduct.TabIndex = 21;
            this.txtSearchProduct.Text = "Tìm sản phẩm theo mã hoặc tên";
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            this.txtSearchProduct.Enter += new System.EventHandler(this.txtSearchProduct_Enter);
            this.txtSearchProduct.Leave += new System.EventHandler(this.txtSearchProduct_Leave);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(1033, 30);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(212, 21);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "ST01 - Võ Quang Đăng Khoa";
            this.lblUser.MouseEnter += new System.EventHandler(this.pictureBoxBackWard_MouseEnter);
            this.lblUser.MouseLeave += new System.EventHandler(this.pictureBoxHome_MouseLeave);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnImportExcel.Image = global::GUI.Properties.Resources.excel;
            this.btnImportExcel.Location = new System.Drawing.Point(805, 22);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(32, 32);
            this.btnImportExcel.TabIndex = 26;
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // pictureBoxAddProduct
            // 
            this.pictureBoxAddProduct.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxAddProduct.Image = global::GUI.Properties.Resources.plus1;
            this.pictureBoxAddProduct.Location = new System.Drawing.Point(497, 22);
            this.pictureBoxAddProduct.Name = "pictureBoxAddProduct";
            this.pictureBoxAddProduct.Size = new System.Drawing.Size(34, 29);
            this.pictureBoxAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAddProduct.TabIndex = 25;
            this.pictureBoxAddProduct.TabStop = false;
            this.pictureBoxAddProduct.Click += new System.EventHandler(this.pictureBoxAddProduct_Click);
            // 
            // pictureBoxBackWard
            // 
            this.pictureBoxBackWard.BackgroundImage = global::GUI.Properties.Resources.backwards;
            this.pictureBoxBackWard.Location = new System.Drawing.Point(33, 19);
            this.pictureBoxBackWard.Name = "pictureBoxBackWard";
            this.pictureBoxBackWard.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxBackWard.TabIndex = 24;
            this.pictureBoxBackWard.TabStop = false;
            this.pictureBoxBackWard.Click += new System.EventHandler(this.pictureBoxBackWard_Click);
            this.pictureBoxBackWard.MouseEnter += new System.EventHandler(this.pictureBoxBackWard_MouseEnter);
            this.pictureBoxBackWard.MouseLeave += new System.EventHandler(this.pictureBoxBackWard_MouseLeave);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::GUI.Properties.Resources.home;
            this.pictureBoxHome.Location = new System.Drawing.Point(1255, 22);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxHome.TabIndex = 23;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Visible = false;
            this.pictureBoxHome.MouseEnter += new System.EventHandler(this.pictureBoxHome_MouseEnter);
            this.pictureBoxHome.MouseLeave += new System.EventHandler(this.pictureBoxHome_MouseLeave);
            // 
            // frmInventoryReceivingVoucherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.pictureBoxAddProduct);
            this.Controls.Add(this.flowLayoutPanelHintProduct);
            this.Controls.Add(this.pictureBoxBackWard);
            this.Controls.Add(this.pictureBoxHome);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.flowLayoutPanelProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventoryReceivingVoucherDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu nhập";
            this.Load += new System.EventHandler(this.frmInventoryReceivingVoucherDetail_Load);
            this.Click += new System.EventHandler(this.frmInventoryReceivingVoucherDetail_Click);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanelHintProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackWard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.TextBox txtIRVId;
        private System.Windows.Forms.Label lblIRVId;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label lblTotalShow;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblOweShow;
        private System.Windows.Forms.Label lblOwe;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblPaidShow;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHintProduct;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.PictureBox pictureBoxBackWard;
        private System.Windows.Forms.PictureBox pictureBoxAddProduct;
        private System.Windows.Forms.Button btnImportExcel;
    }
}