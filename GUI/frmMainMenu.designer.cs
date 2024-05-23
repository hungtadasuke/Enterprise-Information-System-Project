using GUI.RJControls;

namespace GUI
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSell = new System.Windows.Forms.Panel();
            this.lblSell = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.panelIRV = new System.Windows.Forms.Panel();
            this.lblIRV = new System.Windows.Forms.Label();
            this.btnIRV = new System.Windows.Forms.Button();
            this.panelPV = new System.Windows.Forms.Panel();
            this.lblPV = new System.Windows.Forms.Label();
            this.btnPV = new System.Windows.Forms.Button();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.headerText = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.picLogo = new GUI.RJControls.RJCircularPictureBox();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.panelSell.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelReceipt.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelStaff.SuspendLayout();
            this.panelIRV.SuspendLayout();
            this.panelPV.SuspendLayout();
            this.panelSupplier.SuspendLayout();
            this.panelStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanelMenu.Controls.Add(this.panelSell);
            this.flowLayoutPanelMenu.Controls.Add(this.panelCustomer);
            this.flowLayoutPanelMenu.Controls.Add(this.panelReceipt);
            this.flowLayoutPanelMenu.Controls.Add(this.panelProduct);
            this.flowLayoutPanelMenu.Controls.Add(this.panelCategory);
            this.flowLayoutPanelMenu.Controls.Add(this.panelStaff);
            this.flowLayoutPanelMenu.Controls.Add(this.panelIRV);
            this.flowLayoutPanelMenu.Controls.Add(this.panelPV);
            this.flowLayoutPanelMenu.Controls.Add(this.panelSupplier);
            this.flowLayoutPanelMenu.Controls.Add(this.panelStatistic);
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(50, 172);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(549, 553);
            this.flowLayoutPanelMenu.TabIndex = 3;
            // 
            // panelSell
            // 
            this.panelSell.Controls.Add(this.lblSell);
            this.panelSell.Controls.Add(this.btnSell);
            this.panelSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSell.Location = new System.Drawing.Point(3, 3);
            this.panelSell.Name = "panelSell";
            this.panelSell.Size = new System.Drawing.Size(177, 132);
            this.panelSell.TabIndex = 0;
            this.panelSell.Visible = false;
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.Location = new System.Drawing.Point(41, 79);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(95, 21);
            this.lblSell.TabIndex = 1;
            this.lblSell.Text = "BÁN HÀNG";
            // 
            // btnSell
            // 
            this.btnSell.Image = global::GUI.Properties.Resources.cashier_machine;
            this.btnSell.Location = new System.Drawing.Point(47, 3);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(83, 73);
            this.btnSell.TabIndex = 0;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.lblCustomer);
            this.panelCustomer.Controls.Add(this.btnCustomer);
            this.panelCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCustomer.Location = new System.Drawing.Point(186, 3);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(177, 132);
            this.panelCustomer.TabIndex = 2;
            this.panelCustomer.Visible = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(30, 79);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(116, 21);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "KHÁCH HÀNG";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::GUI.Properties.Resources.target;
            this.btnCustomer.Location = new System.Drawing.Point(47, 3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(83, 73);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panelReceipt
            // 
            this.panelReceipt.Controls.Add(this.lblReceipt);
            this.panelReceipt.Controls.Add(this.btnReceipt);
            this.panelReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReceipt.Location = new System.Drawing.Point(369, 3);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(177, 132);
            this.panelReceipt.TabIndex = 3;
            this.panelReceipt.Visible = false;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipt.Location = new System.Drawing.Point(45, 79);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(86, 21);
            this.lblReceipt.TabIndex = 1;
            this.lblReceipt.Text = "HÓA ĐƠN";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Image = global::GUI.Properties.Resources.receipt;
            this.btnReceipt.Location = new System.Drawing.Point(47, 3);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(83, 73);
            this.btnReceipt.TabIndex = 0;
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.lblProduct);
            this.panelProduct.Controls.Add(this.btnProduct);
            this.panelProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelProduct.Location = new System.Drawing.Point(3, 141);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(177, 132);
            this.panelProduct.TabIndex = 2;
            this.panelProduct.Visible = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(40, 79);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(96, 21);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "HÀNG HÓA";
            // 
            // btnProduct
            // 
            this.btnProduct.Image = global::GUI.Properties.Resources.products;
            this.btnProduct.Location = new System.Drawing.Point(47, 3);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(83, 73);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.lblCategory);
            this.panelCategory.Controls.Add(this.btnCategory);
            this.panelCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCategory.Location = new System.Drawing.Point(186, 141);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(177, 132);
            this.panelCategory.TabIndex = 3;
            this.panelCategory.Visible = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(33, 79);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(113, 21);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "NHÓM HÀNG";
            // 
            // btnCategory
            // 
            this.btnCategory.Image = global::GUI.Properties.Resources.categories;
            this.btnCategory.Location = new System.Drawing.Point(47, 3);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(83, 73);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // panelStaff
            // 
            this.panelStaff.Controls.Add(this.lblStaff);
            this.panelStaff.Controls.Add(this.btnStaff);
            this.panelStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStaff.Location = new System.Drawing.Point(369, 141);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(177, 132);
            this.panelStaff.TabIndex = 4;
            this.panelStaff.Visible = false;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(38, 79);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(101, 21);
            this.lblStaff.TabIndex = 1;
            this.lblStaff.Text = "NHÂN VIÊN";
            // 
            // btnStaff
            // 
            this.btnStaff.Image = global::GUI.Properties.Resources.staff;
            this.btnStaff.Location = new System.Drawing.Point(47, 3);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(83, 73);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panelIRV
            // 
            this.panelIRV.Controls.Add(this.lblIRV);
            this.panelIRV.Controls.Add(this.btnIRV);
            this.panelIRV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelIRV.Location = new System.Drawing.Point(3, 279);
            this.panelIRV.Name = "panelIRV";
            this.panelIRV.Size = new System.Drawing.Size(177, 132);
            this.panelIRV.TabIndex = 3;
            this.panelIRV.Visible = false;
            // 
            // lblIRV
            // 
            this.lblIRV.AutoSize = true;
            this.lblIRV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRV.Location = new System.Drawing.Point(34, 79);
            this.lblIRV.Name = "lblIRV";
            this.lblIRV.Size = new System.Drawing.Size(108, 21);
            this.lblIRV.TabIndex = 1;
            this.lblIRV.Text = "PHIẾU NHẬP";
            // 
            // btnIRV
            // 
            this.btnIRV.Image = global::GUI.Properties.Resources.import;
            this.btnIRV.Location = new System.Drawing.Point(47, 3);
            this.btnIRV.Name = "btnIRV";
            this.btnIRV.Size = new System.Drawing.Size(83, 73);
            this.btnIRV.TabIndex = 0;
            this.btnIRV.UseVisualStyleBackColor = true;
            this.btnIRV.Click += new System.EventHandler(this.btnIRV_Click);
            // 
            // panelPV
            // 
            this.panelPV.Controls.Add(this.lblPV);
            this.panelPV.Controls.Add(this.btnPV);
            this.panelPV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPV.Location = new System.Drawing.Point(186, 279);
            this.panelPV.Name = "panelPV";
            this.panelPV.Size = new System.Drawing.Size(177, 132);
            this.panelPV.TabIndex = 5;
            this.panelPV.Visible = false;
            // 
            // lblPV
            // 
            this.lblPV.AutoSize = true;
            this.lblPV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPV.Location = new System.Drawing.Point(44, 79);
            this.lblPV.Name = "lblPV";
            this.lblPV.Size = new System.Drawing.Size(89, 21);
            this.lblPV.TabIndex = 1;
            this.lblPV.Text = "PHIẾU CHI";
            // 
            // btnPV
            // 
            this.btnPV.Image = global::GUI.Properties.Resources.payment;
            this.btnPV.Location = new System.Drawing.Point(47, 3);
            this.btnPV.Name = "btnPV";
            this.btnPV.Size = new System.Drawing.Size(83, 73);
            this.btnPV.TabIndex = 0;
            this.btnPV.UseVisualStyleBackColor = true;
            this.btnPV.Click += new System.EventHandler(this.btnPV_Click);
            // 
            // panelSupplier
            // 
            this.panelSupplier.Controls.Add(this.lblSupplier);
            this.panelSupplier.Controls.Add(this.btnSupplier);
            this.panelSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSupplier.Location = new System.Drawing.Point(369, 279);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(177, 132);
            this.panelSupplier.TabIndex = 4;
            this.panelSupplier.Visible = false;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(23, 79);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(131, 21);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "NHÀ CUNG CẤP";
            // 
            // btnSupplier
            // 
            this.btnSupplier.Image = global::GUI.Properties.Resources.supplier;
            this.btnSupplier.Location = new System.Drawing.Point(47, 3);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(83, 73);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // panelStatistic
            // 
            this.panelStatistic.Controls.Add(this.lblStatistic);
            this.panelStatistic.Controls.Add(this.btnStatistic);
            this.panelStatistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStatistic.Location = new System.Drawing.Point(3, 417);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(177, 132);
            this.panelStatistic.TabIndex = 4;
            this.panelStatistic.Visible = false;
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistic.Location = new System.Drawing.Point(43, 79);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(90, 21);
            this.lblStatistic.TabIndex = 1;
            this.lblStatistic.Text = "THỐNG KÊ";
            // 
            // btnStatistic
            // 
            this.btnStatistic.Image = global::GUI.Properties.Resources.analytics;
            this.btnStatistic.Location = new System.Drawing.Point(47, 3);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(83, 73);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // headerText
            // 
            this.headerText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.headerText.Image = global::GUI.Properties.Resources.headerText;
            this.headerText.Location = new System.Drawing.Point(105, 99);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(444, 46);
            this.headerText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headerText.TabIndex = 1;
            this.headerText.TabStop = false;
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBoxBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.Size = new System.Drawing.Size(649, 717);
            this.pictureBoxBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackGround.TabIndex = 0;
            this.pictureBoxBackGround.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(392, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(184, 21);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "ST04 - Nguyễn Nhật Huy";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::GUI.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(605, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(32, 32);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picLogo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picLogo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picLogo.BorderColor2 = System.Drawing.Color.HotPink;
            this.picLogo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picLogo.BorderSize = 2;
            this.picLogo.GradientAngle = 50F;
            this.picLogo.Image = global::GUI.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(287, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(74, 74);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 717);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.pictureBoxBackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện chức năng";
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.panelSell.ResumeLayout(false);
            this.panelSell.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelReceipt.ResumeLayout(false);
            this.panelReceipt.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            this.panelIRV.ResumeLayout(false);
            this.panelIRV.PerformLayout();
            this.panelPV.ResumeLayout(false);
            this.panelPV.PerformLayout();
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            this.panelStatistic.ResumeLayout(false);
            this.panelStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackGround;
        private System.Windows.Forms.PictureBox headerText;
        private RJCircularPictureBox picLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel panelSell;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelReceipt;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel panelIRV;
        private System.Windows.Forms.Label lblIRV;
        private System.Windows.Forms.Button btnIRV;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Panel panelPV;
        private System.Windows.Forms.Label lblPV;
        private System.Windows.Forms.Button btnPV;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogOut;
    }
}