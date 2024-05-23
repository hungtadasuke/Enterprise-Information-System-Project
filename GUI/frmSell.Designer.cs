using System.Drawing;
using System.Runtime.CompilerServices;

namespace GUI
{
    partial class frmSell
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.picPrintBill = new System.Windows.Forms.PictureBox();
            this.lblStaffInfo = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.pnCustomerSearch = new System.Windows.Forms.Panel();
            this.picAddCustomer = new System.Windows.Forms.PictureBox();
            this.picDelCustomerSearch = new System.Windows.Forms.PictureBox();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.pnChoseProductContainer = new System.Windows.Forms.Panel();
            this.PanelBarcode = new System.Windows.Forms.Panel();
            this.lblProductIdBarcode = new System.Windows.Forms.Label();
            this.tbBarcodeQuantity = new System.Windows.Forms.TextBox();
            this.btnConfirmBarcode = new System.Windows.Forms.Button();
            this.lblProductNameBarcode = new System.Windows.Forms.Label();
            this.Camera = new System.Windows.Forms.PictureBox();
            this.btnDisplayCamera = new GUI.HRJButton();
            this.pnProductSearch = new System.Windows.Forms.Panel();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.fpnProductFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProductFilter = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnDevidePagesContainer = new System.Windows.Forms.Panel();
            this.btnRightPage = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnLeftPage = new System.Windows.Forms.Button();
            this.fpnProductInforContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.statusDateTimeBar = new System.Windows.Forms.StatusStrip();
            this.lblDateTimeNowInBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTimeBar = new System.Windows.Forms.Timer(this.components);
            this.fpnShowDetailOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDisplayItemOrder = new System.Windows.Forms.Panel();
            this.btnApplyPoint = new GUI.HRJButton();
            this.lblDoubleDot6 = new System.Windows.Forms.Label();
            this.lblDoubleDot5 = new System.Windows.Forms.Label();
            this.lblDoubleDot3 = new System.Windows.Forms.Label();
            this.lblDoubleDot4 = new System.Windows.Forms.Label();
            this.lblDoubleDot2 = new System.Windows.Forms.Label();
            this.lblDoubleDot1 = new System.Windows.Forms.Label();
            this.lblPointResult = new System.Windows.Forms.Label();
            this.lblNumberPhoneResult = new System.Windows.Forms.Label();
            this.lblCustomerNameResult = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.lblDiscountResult = new System.Windows.Forms.Label();
            this.lblDiscountedTotalResult = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblNumberPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDiscountedTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrintBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.pnCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelCustomerSearch)).BeginInit();
            this.pnChoseProductContainer.SuspendLayout();
            this.PanelBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).BeginInit();
            this.pnProductSearch.SuspendLayout();
            this.pnDevidePagesContainer.SuspendLayout();
            this.statusDateTimeBar.SuspendLayout();
            this.pnDisplayItemOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.pnHeader.Controls.Add(this.picPrintBill);
            this.pnHeader.Controls.Add(this.lblStaffInfo);
            this.pnHeader.Controls.Add(this.picHome);
            this.pnHeader.Controls.Add(this.pnCustomerSearch);
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1334, 49);
            this.pnHeader.TabIndex = 0;
            // 
            // picPrintBill
            // 
            this.picPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPrintBill.Image = global::GUI.Properties.Resources.printer__2_;
            this.picPrintBill.Location = new System.Drawing.Point(1219, 7);
            this.picPrintBill.Name = "picPrintBill";
            this.picPrintBill.Size = new System.Drawing.Size(37, 37);
            this.picPrintBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPrintBill.TabIndex = 3;
            this.picPrintBill.TabStop = false;
            this.picPrintBill.Click += new System.EventHandler(this.picPrintBill_Click);
            this.picPrintBill.MouseEnter += new System.EventHandler(this.picPrintBill_MouseEnter);
            this.picPrintBill.MouseLeave += new System.EventHandler(this.picPrintBill_MouseLeave);
            // 
            // lblStaffInfo
            // 
            this.lblStaffInfo.AutoSize = true;
            this.lblStaffInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffInfo.ForeColor = System.Drawing.Color.White;
            this.lblStaffInfo.Location = new System.Drawing.Point(1021, 15);
            this.lblStaffInfo.Name = "lblStaffInfo";
            this.lblStaffInfo.Size = new System.Drawing.Size(183, 19);
            this.lblStaffInfo.TabIndex = 2;
            this.lblStaffInfo.Text = "ST01_Võ Quang Đăng Khoa";
            this.lblStaffInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(1274, 7);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 37);
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.picHome.MouseEnter += new System.EventHandler(this.picHome_MouseEnter);
            this.picHome.MouseLeave += new System.EventHandler(this.picHome_MouseLeave);
            // 
            // pnCustomerSearch
            // 
            this.pnCustomerSearch.BackColor = System.Drawing.Color.White;
            this.pnCustomerSearch.Controls.Add(this.picAddCustomer);
            this.pnCustomerSearch.Controls.Add(this.picDelCustomerSearch);
            this.pnCustomerSearch.Controls.Add(this.txtCustomerSearch);
            this.pnCustomerSearch.Location = new System.Drawing.Point(12, 10);
            this.pnCustomerSearch.Name = "pnCustomerSearch";
            this.pnCustomerSearch.Size = new System.Drawing.Size(313, 29);
            this.pnCustomerSearch.TabIndex = 0;
            // 
            // picAddCustomer
            // 
            this.picAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddCustomer.Image = global::GUI.Properties.Resources.plus__1_;
            this.picAddCustomer.Location = new System.Drawing.Point(278, 0);
            this.picAddCustomer.Name = "picAddCustomer";
            this.picAddCustomer.Size = new System.Drawing.Size(31, 29);
            this.picAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAddCustomer.TabIndex = 1;
            this.picAddCustomer.TabStop = false;
            this.picAddCustomer.Click += new System.EventHandler(this.picAddCustomer_Click);
            // 
            // picDelCustomerSearch
            // 
            this.picDelCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelCustomerSearch.Image = global::GUI.Properties.Resources.close__1_;
            this.picDelCustomerSearch.Location = new System.Drawing.Point(278, 0);
            this.picDelCustomerSearch.Name = "picDelCustomerSearch";
            this.picDelCustomerSearch.Size = new System.Drawing.Size(31, 29);
            this.picDelCustomerSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDelCustomerSearch.TabIndex = 0;
            this.picDelCustomerSearch.TabStop = false;
            this.picDelCustomerSearch.Click += new System.EventHandler(this.picDelCustomerSearch_Click);
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtCustomerSearch.Location = new System.Drawing.Point(16, 5);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(256, 19);
            this.txtCustomerSearch.TabIndex = 0;
            this.txtCustomerSearch.Text = "Số Điện Thoại Khách Hàng";
            this.txtCustomerSearch.EnabledChanged += new System.EventHandler(this.txtCustomerSearch_EnabledChanged);
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            this.txtCustomerSearch.Enter += new System.EventHandler(this.txtCustomerSearch_Enter);
            this.txtCustomerSearch.Leave += new System.EventHandler(this.txtCustomerSearch_Leave);
            // 
            // pnChoseProductContainer
            // 
            this.pnChoseProductContainer.BackColor = System.Drawing.Color.White;
            this.pnChoseProductContainer.Controls.Add(this.PanelBarcode);
            this.pnChoseProductContainer.Controls.Add(this.btnDisplayCamera);
            this.pnChoseProductContainer.Controls.Add(this.pnProductSearch);
            this.pnChoseProductContainer.Controls.Add(this.fpnProductFilter);
            this.pnChoseProductContainer.Controls.Add(this.btnProductFilter);
            this.pnChoseProductContainer.Controls.Add(this.btnPayment);
            this.pnChoseProductContainer.Controls.Add(this.pnDevidePagesContainer);
            this.pnChoseProductContainer.Controls.Add(this.fpnProductInforContainer);
            this.pnChoseProductContainer.Location = new System.Drawing.Point(673, 49);
            this.pnChoseProductContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnChoseProductContainer.Name = "pnChoseProductContainer";
            this.pnChoseProductContainer.Size = new System.Drawing.Size(661, 634);
            this.pnChoseProductContainer.TabIndex = 2;
            // 
            // PanelBarcode
            // 
            this.PanelBarcode.Controls.Add(this.lblProductIdBarcode);
            this.PanelBarcode.Controls.Add(this.tbBarcodeQuantity);
            this.PanelBarcode.Controls.Add(this.btnConfirmBarcode);
            this.PanelBarcode.Controls.Add(this.lblProductNameBarcode);
            this.PanelBarcode.Controls.Add(this.Camera);
            this.PanelBarcode.Location = new System.Drawing.Point(24, 65);
            this.PanelBarcode.Name = "PanelBarcode";
            this.PanelBarcode.Size = new System.Drawing.Size(614, 483);
            this.PanelBarcode.TabIndex = 0;
            this.PanelBarcode.Visible = false;
            // 
            // lblProductIdBarcode
            // 
            this.lblProductIdBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lblProductIdBarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductIdBarcode.Location = new System.Drawing.Point(10, 448);
            this.lblProductIdBarcode.Name = "lblProductIdBarcode";
            this.lblProductIdBarcode.Size = new System.Drawing.Size(183, 27);
            this.lblProductIdBarcode.TabIndex = 8;
            // 
            // tbBarcodeQuantity
            // 
            this.tbBarcodeQuantity.Enabled = false;
            this.tbBarcodeQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBarcodeQuantity.Location = new System.Drawing.Point(403, 404);
            this.tbBarcodeQuantity.Name = "tbBarcodeQuantity";
            this.tbBarcodeQuantity.Size = new System.Drawing.Size(139, 27);
            this.tbBarcodeQuantity.TabIndex = 7;
            this.tbBarcodeQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            // 
            // btnConfirmBarcode
            // 
            this.btnConfirmBarcode.Enabled = false;
            this.btnConfirmBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmBarcode.Location = new System.Drawing.Point(421, 437);
            this.btnConfirmBarcode.Name = "btnConfirmBarcode";
            this.btnConfirmBarcode.Size = new System.Drawing.Size(108, 33);
            this.btnConfirmBarcode.TabIndex = 6;
            this.btnConfirmBarcode.Text = "Xác nhận";
            this.btnConfirmBarcode.UseVisualStyleBackColor = true;
            this.btnConfirmBarcode.Click += new System.EventHandler(this.btnConfirmBarcode_Click);
            // 
            // lblProductNameBarcode
            // 
            this.lblProductNameBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lblProductNameBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameBarcode.Location = new System.Drawing.Point(10, 399);
            this.lblProductNameBarcode.Name = "lblProductNameBarcode";
            this.lblProductNameBarcode.Size = new System.Drawing.Size(277, 47);
            this.lblProductNameBarcode.TabIndex = 5;
            // 
            // Camera
            // 
            this.Camera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Camera.Location = new System.Drawing.Point(0, 0);
            this.Camera.Margin = new System.Windows.Forms.Padding(0);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(614, 395);
            this.Camera.TabIndex = 0;
            this.Camera.TabStop = false;
            // 
            // btnDisplayCamera
            // 
            this.btnDisplayCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnDisplayCamera.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnDisplayCamera.BorderColor = System.Drawing.Color.White;
            this.btnDisplayCamera.BorderRadius = 8;
            this.btnDisplayCamera.BorderSize = 0;
            this.btnDisplayCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayCamera.FlatAppearance.BorderSize = 0;
            this.btnDisplayCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayCamera.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCamera.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayCamera.Image = global::GUI.Properties.Resources.icons8_barcode_24;
            this.btnDisplayCamera.Location = new System.Drawing.Point(352, 18);
            this.btnDisplayCamera.Name = "btnDisplayCamera";
            this.btnDisplayCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDisplayCamera.Size = new System.Drawing.Size(130, 32);
            this.btnDisplayCamera.TabIndex = 7;
            this.btnDisplayCamera.Text = "  Quét Mã Vạch";
            this.btnDisplayCamera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisplayCamera.TextColor = System.Drawing.Color.Black;
            this.btnDisplayCamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisplayCamera.UseVisualStyleBackColor = false;
            this.btnDisplayCamera.Click += new System.EventHandler(this.btnDisplayCamera_Click);
            // 
            // pnProductSearch
            // 
            this.pnProductSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnProductSearch.Controls.Add(this.txtProductSearch);
            this.pnProductSearch.Location = new System.Drawing.Point(24, 18);
            this.pnProductSearch.Name = "pnProductSearch";
            this.pnProductSearch.Size = new System.Drawing.Size(287, 32);
            this.pnProductSearch.TabIndex = 5;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtProductSearch.Location = new System.Drawing.Point(13, 6);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(262, 20);
            this.txtProductSearch.TabIndex = 3;
            this.txtProductSearch.Text = "Tên Sản Phẩm (Từ Khóa)";
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            this.txtProductSearch.Enter += new System.EventHandler(this.txtProductSearch_Enter);
            this.txtProductSearch.Leave += new System.EventHandler(this.txtProductSearch_Leave);
            // 
            // fpnProductFilter
            // 
            this.fpnProductFilter.BackColor = System.Drawing.Color.Transparent;
            this.fpnProductFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnProductFilter.Location = new System.Drawing.Point(445, 50);
            this.fpnProductFilter.Name = "fpnProductFilter";
            this.fpnProductFilter.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.fpnProductFilter.Size = new System.Drawing.Size(193, 103);
            this.fpnProductFilter.TabIndex = 6;
            this.fpnProductFilter.Visible = false;
            // 
            // btnProductFilter
            // 
            this.btnProductFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnProductFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductFilter.FlatAppearance.BorderSize = 0;
            this.btnProductFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductFilter.Image = global::GUI.Properties.Resources.filter;
            this.btnProductFilter.Location = new System.Drawing.Point(601, 18);
            this.btnProductFilter.Name = "btnProductFilter";
            this.btnProductFilter.Size = new System.Drawing.Size(37, 32);
            this.btnProductFilter.TabIndex = 4;
            this.btnProductFilter.UseVisualStyleBackColor = false;
            this.btnProductFilter.Click += new System.EventHandler(this.btnProductFilter_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.LightGray;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.Enabled = false;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(199, 559);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(439, 52);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "THANH TOÁN";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            this.btnPayment.MouseEnter += new System.EventHandler(this.btnPayment_MouseEnter);
            this.btnPayment.MouseLeave += new System.EventHandler(this.btnPayment_MouseLeave);
            // 
            // pnDevidePagesContainer
            // 
            this.pnDevidePagesContainer.BackColor = System.Drawing.Color.White;
            this.pnDevidePagesContainer.Controls.Add(this.btnRightPage);
            this.pnDevidePagesContainer.Controls.Add(this.lblPageInfo);
            this.pnDevidePagesContainer.Controls.Add(this.btnLeftPage);
            this.pnDevidePagesContainer.Location = new System.Drawing.Point(24, 559);
            this.pnDevidePagesContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnDevidePagesContainer.Name = "pnDevidePagesContainer";
            this.pnDevidePagesContainer.Size = new System.Drawing.Size(150, 52);
            this.pnDevidePagesContainer.TabIndex = 1;
            // 
            // btnRightPage
            // 
            this.btnRightPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightPage.Image = global::GUI.Properties.Resources.arrow_point_to_right__1_;
            this.btnRightPage.Location = new System.Drawing.Point(104, 13);
            this.btnRightPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightPage.Name = "btnRightPage";
            this.btnRightPage.Size = new System.Drawing.Size(26, 30);
            this.btnRightPage.TabIndex = 1;
            this.btnRightPage.UseVisualStyleBackColor = true;
            this.btnRightPage.Click += new System.EventHandler(this.btnRightPage_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.Location = new System.Drawing.Point(49, 13);
            this.lblPageInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(50, 28);
            this.lblPageInfo.TabIndex = 2;
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPageInfo.TextChanged += new System.EventHandler(this.lblPageInfo_TextChanged);
            // 
            // btnLeftPage
            // 
            this.btnLeftPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeftPage.Image = global::GUI.Properties.Resources.arrowhead_thin_outline_to_the_left__1_;
            this.btnLeftPage.Location = new System.Drawing.Point(22, 13);
            this.btnLeftPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftPage.Name = "btnLeftPage";
            this.btnLeftPage.Size = new System.Drawing.Size(26, 30);
            this.btnLeftPage.TabIndex = 0;
            this.btnLeftPage.UseVisualStyleBackColor = true;
            this.btnLeftPage.Click += new System.EventHandler(this.btnLeftPage_Click);
            // 
            // fpnProductInforContainer
            // 
            this.fpnProductInforContainer.AutoScroll = true;
            this.fpnProductInforContainer.BackColor = System.Drawing.Color.White;
            this.fpnProductInforContainer.Location = new System.Drawing.Point(24, 65);
            this.fpnProductInforContainer.Margin = new System.Windows.Forms.Padding(2);
            this.fpnProductInforContainer.Name = "fpnProductInforContainer";
            this.fpnProductInforContainer.Size = new System.Drawing.Size(614, 483);
            this.fpnProductInforContainer.TabIndex = 0;
            // 
            // statusDateTimeBar
            // 
            this.statusDateTimeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(171)))), ((int)(((byte)(239)))));
            this.statusDateTimeBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusDateTimeBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDateTimeNowInBar});
            this.statusDateTimeBar.Location = new System.Drawing.Point(0, 689);
            this.statusDateTimeBar.Name = "statusDateTimeBar";
            this.statusDateTimeBar.Padding = new System.Windows.Forms.Padding(1140, 5, 0, 5);
            this.statusDateTimeBar.Size = new System.Drawing.Size(1334, 22);
            this.statusDateTimeBar.TabIndex = 3;
            // 
            // lblDateTimeNowInBar
            // 
            this.lblDateTimeNowInBar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeNowInBar.Name = "lblDateTimeNowInBar";
            this.lblDateTimeNowInBar.Size = new System.Drawing.Size(0, 7);
            // 
            // timerDateTimeBar
            // 
            this.timerDateTimeBar.Enabled = true;
            this.timerDateTimeBar.Interval = 1000;
            this.timerDateTimeBar.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fpnShowDetailOrder
            // 
            this.fpnShowDetailOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fpnShowDetailOrder.Location = new System.Drawing.Point(12, 54);
            this.fpnShowDetailOrder.Name = "fpnShowDetailOrder";
            this.fpnShowDetailOrder.Size = new System.Drawing.Size(661, 517);
            this.fpnShowDetailOrder.TabIndex = 4;
            this.fpnShowDetailOrder.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.fpnShowDetailOrder_ControlAdded);
            this.fpnShowDetailOrder.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.fpnShowDetailOrder_ControlRemoved);
            // 
            // pnDisplayItemOrder
            // 
            this.pnDisplayItemOrder.BackColor = System.Drawing.Color.LightGray;
            this.pnDisplayItemOrder.Controls.Add(this.btnApplyPoint);
            this.pnDisplayItemOrder.Controls.Add(this.lblDoubleDot6);
            this.pnDisplayItemOrder.Controls.Add(this.lblDoubleDot5);
            this.pnDisplayItemOrder.Controls.Add(this.lblDoubleDot3);
            this.pnDisplayItemOrder.Controls.Add(this.lblDoubleDot4);
            this.pnDisplayItemOrder.Controls.Add(this.lblDoubleDot2);
            this.pnDisplayItemOrder.Controls.Add(this.lblDoubleDot1);
            this.pnDisplayItemOrder.Controls.Add(this.lblPointResult);
            this.pnDisplayItemOrder.Controls.Add(this.lblNumberPhoneResult);
            this.pnDisplayItemOrder.Controls.Add(this.lblCustomerNameResult);
            this.pnDisplayItemOrder.Controls.Add(this.lblTotalResult);
            this.pnDisplayItemOrder.Controls.Add(this.lblDiscountResult);
            this.pnDisplayItemOrder.Controls.Add(this.lblDiscountedTotalResult);
            this.pnDisplayItemOrder.Controls.Add(this.lblPoint);
            this.pnDisplayItemOrder.Controls.Add(this.lblNumberPhone);
            this.pnDisplayItemOrder.Controls.Add(this.lblCustomerName);
            this.pnDisplayItemOrder.Controls.Add(this.lblDiscountedTotal);
            this.pnDisplayItemOrder.Controls.Add(this.lblTotal);
            this.pnDisplayItemOrder.Controls.Add(this.lblDiscount);
            this.pnDisplayItemOrder.Location = new System.Drawing.Point(0, 578);
            this.pnDisplayItemOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pnDisplayItemOrder.Name = "pnDisplayItemOrder";
            this.pnDisplayItemOrder.Size = new System.Drawing.Size(673, 105);
            this.pnDisplayItemOrder.TabIndex = 1;
            // 
            // btnApplyPoint
            // 
            this.btnApplyPoint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApplyPoint.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnApplyPoint.BorderColor = System.Drawing.Color.Silver;
            this.btnApplyPoint.BorderRadius = 4;
            this.btnApplyPoint.BorderSize = 1;
            this.btnApplyPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyPoint.FlatAppearance.BorderSize = 0;
            this.btnApplyPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyPoint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPoint.ForeColor = System.Drawing.Color.White;
            this.btnApplyPoint.Location = new System.Drawing.Point(205, 70);
            this.btnApplyPoint.Name = "btnApplyPoint";
            this.btnApplyPoint.Size = new System.Drawing.Size(79, 23);
            this.btnApplyPoint.TabIndex = 16;
            this.btnApplyPoint.Text = "Quy Đổi";
            this.btnApplyPoint.TextColor = System.Drawing.Color.White;
            this.btnApplyPoint.UseVisualStyleBackColor = false;
            this.btnApplyPoint.Visible = false;
            this.btnApplyPoint.Click += new System.EventHandler(this.btnApplyPoint_Click);
            this.btnApplyPoint.MouseEnter += new System.EventHandler(this.btnApplyPoint_MouseEnter);
            this.btnApplyPoint.MouseLeave += new System.EventHandler(this.btnApplyPoint_MouseLeave);
            // 
            // lblDoubleDot6
            // 
            this.lblDoubleDot6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleDot6.Location = new System.Drawing.Point(535, 73);
            this.lblDoubleDot6.Name = "lblDoubleDot6";
            this.lblDoubleDot6.Size = new System.Drawing.Size(10, 17);
            this.lblDoubleDot6.TabIndex = 15;
            this.lblDoubleDot6.Text = ":";
            this.lblDoubleDot6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoubleDot5
            // 
            this.lblDoubleDot5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleDot5.Location = new System.Drawing.Point(535, 43);
            this.lblDoubleDot5.Name = "lblDoubleDot5";
            this.lblDoubleDot5.Size = new System.Drawing.Size(10, 17);
            this.lblDoubleDot5.TabIndex = 14;
            this.lblDoubleDot5.Text = ":";
            this.lblDoubleDot5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoubleDot3
            // 
            this.lblDoubleDot3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleDot3.Location = new System.Drawing.Point(122, 73);
            this.lblDoubleDot3.Name = "lblDoubleDot3";
            this.lblDoubleDot3.Size = new System.Drawing.Size(10, 17);
            this.lblDoubleDot3.TabIndex = 13;
            this.lblDoubleDot3.Text = ":";
            this.lblDoubleDot3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoubleDot4
            // 
            this.lblDoubleDot4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleDot4.Location = new System.Drawing.Point(535, 12);
            this.lblDoubleDot4.Name = "lblDoubleDot4";
            this.lblDoubleDot4.Size = new System.Drawing.Size(10, 17);
            this.lblDoubleDot4.TabIndex = 12;
            this.lblDoubleDot4.Text = ":";
            this.lblDoubleDot4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoubleDot2
            // 
            this.lblDoubleDot2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleDot2.Location = new System.Drawing.Point(122, 43);
            this.lblDoubleDot2.Name = "lblDoubleDot2";
            this.lblDoubleDot2.Size = new System.Drawing.Size(10, 17);
            this.lblDoubleDot2.TabIndex = 11;
            this.lblDoubleDot2.Text = ":";
            this.lblDoubleDot2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoubleDot1
            // 
            this.lblDoubleDot1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleDot1.Location = new System.Drawing.Point(122, 12);
            this.lblDoubleDot1.Name = "lblDoubleDot1";
            this.lblDoubleDot1.Size = new System.Drawing.Size(10, 17);
            this.lblDoubleDot1.TabIndex = 10;
            this.lblDoubleDot1.Text = ":";
            this.lblDoubleDot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPointResult
            // 
            this.lblPointResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointResult.Location = new System.Drawing.Point(139, 73);
            this.lblPointResult.Name = "lblPointResult";
            this.lblPointResult.Size = new System.Drawing.Size(51, 17);
            this.lblPointResult.TabIndex = 9;
            this.lblPointResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPointResult.TextChanged += new System.EventHandler(this.lblPointResult_TextChanged);
            // 
            // lblNumberPhoneResult
            // 
            this.lblNumberPhoneResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPhoneResult.Location = new System.Drawing.Point(139, 43);
            this.lblNumberPhoneResult.Name = "lblNumberPhoneResult";
            this.lblNumberPhoneResult.Size = new System.Drawing.Size(200, 17);
            this.lblNumberPhoneResult.TabIndex = 8;
            this.lblNumberPhoneResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerNameResult
            // 
            this.lblCustomerNameResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNameResult.Location = new System.Drawing.Point(139, 12);
            this.lblCustomerNameResult.Name = "lblCustomerNameResult";
            this.lblCustomerNameResult.Size = new System.Drawing.Size(200, 17);
            this.lblCustomerNameResult.TabIndex = 7;
            this.lblCustomerNameResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResult.Location = new System.Drawing.Point(552, 12);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(97, 17);
            this.lblTotalResult.TabIndex = 6;
            this.lblTotalResult.Text = "0 đ";
            this.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountResult
            // 
            this.lblDiscountResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountResult.Location = new System.Drawing.Point(552, 43);
            this.lblDiscountResult.Name = "lblDiscountResult";
            this.lblDiscountResult.Size = new System.Drawing.Size(97, 17);
            this.lblDiscountResult.TabIndex = 5;
            this.lblDiscountResult.Text = "0 đ";
            this.lblDiscountResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountedTotalResult
            // 
            this.lblDiscountedTotalResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountedTotalResult.Location = new System.Drawing.Point(552, 73);
            this.lblDiscountedTotalResult.Name = "lblDiscountedTotalResult";
            this.lblDiscountedTotalResult.Size = new System.Drawing.Size(97, 17);
            this.lblDiscountedTotalResult.TabIndex = 4;
            this.lblDiscountedTotalResult.Text = "0 đ";
            this.lblDiscountedTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(9, 73);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(74, 17);
            this.lblPoint.TabIndex = 3;
            this.lblPoint.Text = "Tổng Điểm";
            // 
            // lblNumberPhone
            // 
            this.lblNumberPhone.AutoSize = true;
            this.lblNumberPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPhone.Location = new System.Drawing.Point(9, 43);
            this.lblNumberPhone.Name = "lblNumberPhone";
            this.lblNumberPhone.Size = new System.Drawing.Size(91, 17);
            this.lblNumberPhone.TabIndex = 3;
            this.lblNumberPhone.Text = "Số Điện Thoại";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(9, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(107, 17);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Tên Khách Hàng";
            // 
            // lblDiscountedTotal
            // 
            this.lblDiscountedTotal.AutoSize = true;
            this.lblDiscountedTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountedTotal.Location = new System.Drawing.Point(398, 73);
            this.lblDiscountedTotal.Name = "lblDiscountedTotal";
            this.lblDiscountedTotal.Size = new System.Drawing.Size(127, 17);
            this.lblDiscountedTotal.TabIndex = 2;
            this.lblDiscountedTotal.Text = "Số Tiền Thanh Toán";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(398, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Tổng Đơn";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(398, 43);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(62, 17);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "Giảm Giá";
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.statusDateTimeBar);
            this.Controls.Add(this.pnChoseProductContainer);
            this.Controls.Add(this.pnDisplayItemOrder);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.fpnShowDetailOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveChip Mart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSell_FormClosing);
            this.Load += new System.EventHandler(this.frmSell_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrintBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.pnCustomerSearch.ResumeLayout(false);
            this.pnCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelCustomerSearch)).EndInit();
            this.pnChoseProductContainer.ResumeLayout(false);
            this.PanelBarcode.ResumeLayout(false);
            this.PanelBarcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).EndInit();
            this.pnProductSearch.ResumeLayout(false);
            this.pnProductSearch.PerformLayout();
            this.pnDevidePagesContainer.ResumeLayout(false);
            this.statusDateTimeBar.ResumeLayout(false);
            this.statusDateTimeBar.PerformLayout();
            this.pnDisplayItemOrder.ResumeLayout(false);
            this.pnDisplayItemOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnChoseProductContainer;
        private System.Windows.Forms.FlowLayoutPanel fpnProductInforContainer;
        private System.Windows.Forms.StatusStrip statusDateTimeBar;
        private System.Windows.Forms.Timer timerDateTimeBar;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTimeNowInBar;
        private System.Windows.Forms.Panel pnDevidePagesContainer;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnLeftPage;
        private System.Windows.Forms.Button btnRightPage;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnProductFilter;
        private System.Windows.Forms.Panel pnProductSearch;
        private System.Windows.Forms.FlowLayoutPanel fpnShowDetailOrder;
        private System.Windows.Forms.Panel pnCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.FlowLayoutPanel fpnProductFilter;
        private System.Windows.Forms.Panel pnDisplayItemOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountedTotal;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblNumberPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblStaffInfo;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Label lblDiscountResult;
        private System.Windows.Forms.Label lblDiscountedTotalResult;
        private System.Windows.Forms.Label lblCustomerNameResult;
        private System.Windows.Forms.Label lblPointResult;
        private System.Windows.Forms.Label lblNumberPhoneResult;
        private System.Windows.Forms.Label lblDoubleDot6;
        private System.Windows.Forms.Label lblDoubleDot5;
        private System.Windows.Forms.Label lblDoubleDot3;
        private System.Windows.Forms.Label lblDoubleDot4;
        private System.Windows.Forms.Label lblDoubleDot2;
        private System.Windows.Forms.Label lblDoubleDot1;
        private HRJButton btnApplyPoint;
        private System.Windows.Forms.PictureBox picDelCustomerSearch;
        private System.Windows.Forms.PictureBox picAddCustomer;
        private System.Windows.Forms.PictureBox picPrintBill;
        private HRJButton btnDisplayCamera;
        private System.Windows.Forms.PictureBox Camera;
        private System.Windows.Forms.Panel PanelBarcode;
        private System.Windows.Forms.Button btnConfirmBarcode;
        private System.Windows.Forms.Label lblProductNameBarcode;
        private System.Windows.Forms.TextBox tbBarcodeQuantity;
        private System.Windows.Forms.Label lblProductIdBarcode;
    }
}