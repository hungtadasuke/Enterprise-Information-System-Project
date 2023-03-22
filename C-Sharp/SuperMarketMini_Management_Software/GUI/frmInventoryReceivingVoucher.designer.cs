using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class frmInventoryReceivingVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryReceivingVoucher));
            this.dataGridViewImport = new System.Windows.Forms.DataGridView();
            this.clmStockReceivedDocketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnHeading = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.txtTTTo = new System.Windows.Forms.TextBox();
            this.rdbTTFromTo = new System.Windows.Forms.RadioButton();
            this.txtTTFrom = new System.Windows.Forms.TextBox();
            this.rdbTTBelow = new System.Windows.Forms.RadioButton();
            this.txtTTBelow = new System.Windows.Forms.TextBox();
            this.rdbTTAbove = new System.Windows.Forms.RadioButton();
            this.txtTTAbove = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panelFiller = new System.Windows.Forms.Panel();
            this.panelStaffID = new System.Windows.Forms.Panel();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelDate = new System.Windows.Forms.Panel();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.rdbDateFromTo = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.rdbDate = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnImportGoods = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).BeginInit();
            this.pnHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.panelSupplier.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelFiller.SuspendLayout();
            this.panelStaffID.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImport
            // 
            this.dataGridViewImport.AllowUserToAddRows = false;
            this.dataGridViewImport.AllowUserToDeleteRows = false;
            this.dataGridViewImport.AllowUserToResizeColumns = false;
            this.dataGridViewImport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridViewImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewImport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStockReceivedDocketID,
            this.colStaffID,
            this.clmDate,
            this.clmSupplier,
            this.clmTotal,
            this.colOwed});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImport.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImport.EnableHeadersVisualStyles = false;
            this.dataGridViewImport.Location = new System.Drawing.Point(296, 151);
            this.dataGridViewImport.MultiSelect = false;
            this.dataGridViewImport.Name = "dataGridViewImport";
            this.dataGridViewImport.ReadOnly = true;
            this.dataGridViewImport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImport.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImport.RowHeadersVisible = false;
            this.dataGridViewImport.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dataGridViewImport.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImport.RowTemplate.Height = 30;
            this.dataGridViewImport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImport.ShowCellToolTips = false;
            this.dataGridViewImport.Size = new System.Drawing.Size(1012, 530);
            this.dataGridViewImport.TabIndex = 1;
            this.dataGridViewImport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImport_CellClick);
            this.dataGridViewImport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImport_CellDoubleClick);
            // 
            // clmStockReceivedDocketID
            // 
            this.clmStockReceivedDocketID.DataPropertyName = "Re_Id";
            this.clmStockReceivedDocketID.HeaderText = "Mã Phiếu Nhập";
            this.clmStockReceivedDocketID.MinimumWidth = 6;
            this.clmStockReceivedDocketID.Name = "clmStockReceivedDocketID";
            this.clmStockReceivedDocketID.ReadOnly = true;
            this.clmStockReceivedDocketID.Width = 150;
            // 
            // colStaffID
            // 
            this.colStaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffID.DataPropertyName = "StaffId";
            this.colStaffID.HeaderText = "Mã Nhân Viên";
            this.colStaffID.MinimumWidth = 6;
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.DataPropertyName = "Re_Date";
            this.clmDate.HeaderText = "Ngày Tạo";
            this.clmDate.MinimumWidth = 6;
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 170;
            // 
            // clmSupplier
            // 
            this.clmSupplier.DataPropertyName = "SupplierName";
            this.clmSupplier.HeaderText = "Nhà Cung Cấp";
            this.clmSupplier.MinimumWidth = 6;
            this.clmSupplier.Name = "clmSupplier";
            this.clmSupplier.ReadOnly = true;
            this.clmSupplier.Width = 220;
            // 
            // clmTotal
            // 
            this.clmTotal.DataPropertyName = "Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmTotal.HeaderText = "Cần trả";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            this.clmTotal.Width = 160;
            // 
            // colOwed
            // 
            this.colOwed.DataPropertyName = "Owe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOwed.DefaultCellStyle = dataGridViewCellStyle4;
            this.colOwed.HeaderText = "Còn nợ";
            this.colOwed.MinimumWidth = 6;
            this.colOwed.Name = "colOwed";
            this.colOwed.ReadOnly = true;
            this.colOwed.Width = 160;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearch.Location = new System.Drawing.Point(296, 39);
            this.txtSearch.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(260, 29);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Tìm kiếm mã phiếu nhập";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pnHeading
            // 
            this.pnHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            this.pnHeading.Controls.Add(this.pictureBoxHome);
            this.pnHeading.Controls.Add(this.lblUser);
            this.pnHeading.Controls.Add(this.lblHeading);
            this.pnHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeading.Location = new System.Drawing.Point(0, 0);
            this.pnHeading.Name = "pnHeading";
            this.pnHeading.Size = new System.Drawing.Size(1334, 50);
            this.pnHeading.TabIndex = 10;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::GUI.Properties.Resources.home;
            this.pictureBoxHome.Location = new System.Drawing.Point(1276, 10);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxHome.TabIndex = 20;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            this.pictureBoxHome.MouseEnter += new System.EventHandler(this.pictureBoxHome_MouseEnter);
            this.pictureBoxHome.MouseLeave += new System.EventHandler(this.pictureBoxHome_MouseLeave);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(1059, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(212, 21);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "ST01 - Võ Quang Đăng Khoa";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(558, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(237, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Quản Lý Phiếu Nhập";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSupplier
            // 
            this.panelSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.panelSupplier.Controls.Add(this.txtSupplier);
            this.panelSupplier.Controls.Add(this.lblSupplier);
            this.panelSupplier.Controls.Add(this.panel11);
            this.panelSupplier.Controls.Add(this.panel12);
            this.panelSupplier.Controls.Add(this.panel13);
            this.panelSupplier.Controls.Add(this.panel14);
            this.panelSupplier.Location = new System.Drawing.Point(26, 268);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(244, 77);
            this.panelSupplier.TabIndex = 9;
            // 
            // txtSupplier
            // 
            this.txtSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSupplier.Location = new System.Drawing.Point(32, 39);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(183, 25);
            this.txtSupplier.TabIndex = 6;
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(3, 4);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(115, 21);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Nhà cung cấp";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Blue;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(1, 76);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(242, 1);
            this.panel11.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Blue;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(243, 1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 76);
            this.panel12.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Blue;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(1, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(243, 1);
            this.panel13.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Blue;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1, 77);
            this.panel14.TabIndex = 0;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.SystemColors.Window;
            this.panelTotal.Controls.Add(this.txtTTTo);
            this.panelTotal.Controls.Add(this.rdbTTFromTo);
            this.panelTotal.Controls.Add(this.txtTTFrom);
            this.panelTotal.Controls.Add(this.rdbTTBelow);
            this.panelTotal.Controls.Add(this.txtTTBelow);
            this.panelTotal.Controls.Add(this.rdbTTAbove);
            this.panelTotal.Controls.Add(this.txtTTAbove);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Controls.Add(this.panel16);
            this.panelTotal.Controls.Add(this.panel17);
            this.panelTotal.Controls.Add(this.panel18);
            this.panelTotal.Controls.Add(this.panel19);
            this.panelTotal.Location = new System.Drawing.Point(26, 376);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(244, 151);
            this.panelTotal.TabIndex = 9;
            // 
            // txtTTTo
            // 
            this.txtTTTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTTo.Location = new System.Drawing.Point(100, 121);
            this.txtTTTo.Name = "txtTTTo";
            this.txtTTTo.ReadOnly = true;
            this.txtTTTo.Size = new System.Drawing.Size(100, 22);
            this.txtTTTo.TabIndex = 15;
            this.txtTTTo.TextChanged += new System.EventHandler(this.txtTTTo_TextChanged);
            // 
            // rdbTTFromTo
            // 
            this.rdbTTFromTo.AutoSize = true;
            this.rdbTTFromTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdbTTFromTo.Location = new System.Drawing.Point(29, 99);
            this.rdbTTFromTo.Name = "rdbTTFromTo";
            this.rdbTTFromTo.Size = new System.Drawing.Size(63, 46);
            this.rdbTTFromTo.TabIndex = 14;
            this.rdbTTFromTo.TabStop = true;
            this.rdbTTFromTo.Text = "Từ :\nĐến :";
            this.rdbTTFromTo.UseVisualStyleBackColor = true;
            this.rdbTTFromTo.CheckedChanged += new System.EventHandler(this.rdbTTFromTo_CheckedChanged);
            // 
            // txtTTFrom
            // 
            this.txtTTFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTFrom.Location = new System.Drawing.Point(100, 99);
            this.txtTTFrom.Name = "txtTTFrom";
            this.txtTTFrom.ReadOnly = true;
            this.txtTTFrom.Size = new System.Drawing.Size(100, 22);
            this.txtTTFrom.TabIndex = 13;
            this.txtTTFrom.TextChanged += new System.EventHandler(this.txtTTFrom_TextChanged);
            // 
            // rdbTTBelow
            // 
            this.rdbTTBelow.AutoSize = true;
            this.rdbTTBelow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdbTTBelow.Location = new System.Drawing.Point(29, 70);
            this.rdbTTBelow.Name = "rdbTTBelow";
            this.rdbTTBelow.Size = new System.Drawing.Size(69, 25);
            this.rdbTTBelow.TabIndex = 12;
            this.rdbTTBelow.TabStop = true;
            this.rdbTTBelow.Text = "Dưới :";
            this.rdbTTBelow.UseVisualStyleBackColor = true;
            this.rdbTTBelow.CheckedChanged += new System.EventHandler(this.rdbTTBelow_CheckedChanged);
            // 
            // txtTTBelow
            // 
            this.txtTTBelow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTBelow.Location = new System.Drawing.Point(100, 73);
            this.txtTTBelow.Name = "txtTTBelow";
            this.txtTTBelow.ReadOnly = true;
            this.txtTTBelow.Size = new System.Drawing.Size(100, 22);
            this.txtTTBelow.TabIndex = 11;
            this.txtTTBelow.TextChanged += new System.EventHandler(this.txtTTBelow_TextChanged);
            // 
            // rdbTTAbove
            // 
            this.rdbTTAbove.AutoSize = true;
            this.rdbTTAbove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdbTTAbove.Location = new System.Drawing.Point(29, 35);
            this.rdbTTAbove.Name = "rdbTTAbove";
            this.rdbTTAbove.Size = new System.Drawing.Size(69, 25);
            this.rdbTTAbove.TabIndex = 10;
            this.rdbTTAbove.TabStop = true;
            this.rdbTTAbove.Text = "Trên : ";
            this.rdbTTAbove.UseVisualStyleBackColor = true;
            this.rdbTTAbove.CheckedChanged += new System.EventHandler(this.rdbTTAbove_CheckedChanged);
            // 
            // txtTTAbove
            // 
            this.txtTTAbove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTAbove.Location = new System.Drawing.Point(100, 38);
            this.txtTTAbove.Name = "txtTTAbove";
            this.txtTTAbove.ReadOnly = true;
            this.txtTTAbove.Size = new System.Drawing.Size(100, 22);
            this.txtTTAbove.TabIndex = 8;
            this.txtTTAbove.TextChanged += new System.EventHandler(this.txtTTAbove_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 21);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Tổng tiền";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Blue;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(1, 150);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(242, 1);
            this.panel16.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Blue;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(243, 1);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1, 150);
            this.panel17.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Blue;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(1, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(243, 1);
            this.panel18.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Blue;
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1, 151);
            this.panel19.TabIndex = 0;
            // 
            // panelFiller
            // 
            this.panelFiller.Controls.Add(this.panelStaffID);
            this.panelFiller.Controls.Add(this.panelDate);
            this.panelFiller.Controls.Add(this.panelTotal);
            this.panelFiller.Controls.Add(this.panelSupplier);
            this.panelFiller.Location = new System.Drawing.Point(0, 147);
            this.panelFiller.Name = "panelFiller";
            this.panelFiller.Size = new System.Drawing.Size(290, 530);
            this.panelFiller.TabIndex = 7;
            this.panelFiller.Click += new System.EventHandler(this.panelFiller_Click);
            // 
            // panelStaffID
            // 
            this.panelStaffID.BackColor = System.Drawing.SystemColors.Window;
            this.panelStaffID.Controls.Add(this.txtStaffID);
            this.panelStaffID.Controls.Add(this.lblStaffID);
            this.panelStaffID.Controls.Add(this.panel6);
            this.panelStaffID.Controls.Add(this.panel7);
            this.panelStaffID.Controls.Add(this.panel8);
            this.panelStaffID.Controls.Add(this.panel9);
            this.panelStaffID.Location = new System.Drawing.Point(27, 157);
            this.panelStaffID.Name = "panelStaffID";
            this.panelStaffID.Size = new System.Drawing.Size(244, 77);
            this.panelStaffID.TabIndex = 10;
            // 
            // txtStaffID
            // 
            this.txtStaffID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStaffID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStaffID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStaffID.Location = new System.Drawing.Point(32, 39);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(183, 25);
            this.txtStaffID.TabIndex = 5;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(3, 4);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(89, 21);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Nhân viên";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(1, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(242, 1);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Blue;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(243, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 76);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(1, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(243, 1);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Blue;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 77);
            this.panel9.TabIndex = 0;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.SystemColors.Window;
            this.panelDate.Controls.Add(this.dateTimePickerDateTo);
            this.panelDate.Controls.Add(this.dateTimePickerDateFrom);
            this.panelDate.Controls.Add(this.rdbDateFromTo);
            this.panelDate.Controls.Add(this.dateTimePickerDate);
            this.panelDate.Controls.Add(this.rdbDate);
            this.panelDate.Controls.Add(this.lblDate);
            this.panelDate.Controls.Add(this.panel5);
            this.panelDate.Controls.Add(this.panel4);
            this.panelDate.Controls.Add(this.panel3);
            this.panelDate.Controls.Add(this.panel2);
            this.panelDate.Location = new System.Drawing.Point(26, 3);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(244, 123);
            this.panelDate.TabIndex = 8;
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.Enabled = false;
            this.dateTimePickerDateTo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePickerDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(103, 96);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(111, 22);
            this.dateTimePickerDateTo.TabIndex = 19;
            this.dateTimePickerDateTo.ValueChanged += new System.EventHandler(this.dateTimePickerDateTo_ValueChanged);
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.Enabled = false;
            this.dateTimePickerDateFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePickerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(103, 74);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(111, 22);
            this.dateTimePickerDateFrom.TabIndex = 18;
            this.dateTimePickerDateFrom.ValueChanged += new System.EventHandler(this.dateTimePickerDateFrom_ValueChanged);
            // 
            // rdbDateFromTo
            // 
            this.rdbDateFromTo.AutoSize = true;
            this.rdbDateFromTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdbDateFromTo.Location = new System.Drawing.Point(30, 70);
            this.rdbDateFromTo.Name = "rdbDateFromTo";
            this.rdbDateFromTo.Size = new System.Drawing.Size(59, 46);
            this.rdbDateFromTo.TabIndex = 16;
            this.rdbDateFromTo.TabStop = true;
            this.rdbDateFromTo.Text = "Từ :\nĐến:";
            this.rdbDateFromTo.UseVisualStyleBackColor = true;
            this.rdbDateFromTo.CheckedChanged += new System.EventHandler(this.rdbDateFromTo_CheckedChanged);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(103, 38);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(111, 22);
            this.dateTimePickerDate.TabIndex = 17;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // rdbDate
            // 
            this.rdbDate.AutoSize = true;
            this.rdbDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rdbDate.Location = new System.Drawing.Point(30, 35);
            this.rdbDate.Name = "rdbDate";
            this.rdbDate.Size = new System.Drawing.Size(72, 25);
            this.rdbDate.TabIndex = 15;
            this.rdbDate.TabStop = true;
            this.rdbDate.Text = "Ngày :";
            this.rdbDate.UseVisualStyleBackColor = true;
            this.rdbDate.CheckedChanged += new System.EventHandler(this.rdbDate_CheckedChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 1);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 21);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Thời gian";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(243, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 122);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 1);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 123);
            this.panel2.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnImportGoods);
            this.panelTop.Location = new System.Drawing.Point(0, 48);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1334, 100);
            this.panelTop.TabIndex = 13;
            this.panelTop.Click += new System.EventHandler(this.panelTop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(69, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.Image = global::GUI.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(945, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 26);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "      Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.btnRefresh_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::GUI.Properties.Resources.delete_file;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1203, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnImportGoods
            // 
            this.btnImportGoods.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnImportGoods.Image = global::GUI.Properties.Resources.add_Huy;
            this.btnImportGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportGoods.Location = new System.Drawing.Point(1069, 39);
            this.btnImportGoods.Name = "btnImportGoods";
            this.btnImportGoods.Size = new System.Drawing.Size(105, 26);
            this.btnImportGoods.TabIndex = 12;
            this.btnImportGoods.Text = "      Nhập Hàng";
            this.btnImportGoods.UseVisualStyleBackColor = false;
            this.btnImportGoods.Click += new System.EventHandler(this.btnImportGoods_Click);
            this.btnImportGoods.MouseEnter += new System.EventHandler(this.btnImportGoods_MouseEnter);
            this.btnImportGoods.MouseLeave += new System.EventHandler(this.btnImportGoods_MouseLeave);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(293, 689);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(220, 13);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "* Nhấn đúp chuột để xem chi tiết phiếu nhập";
            // 
            // frmInventoryReceivingVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFiller);
            this.Controls.Add(this.pnHeading);
            this.Controls.Add(this.dataGridViewImport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInventoryReceivingVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).EndInit();
            this.pnHeading.ResumeLayout(false);
            this.pnHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelFiller.ResumeLayout(false);
            this.panelStaffID.ResumeLayout(false);
            this.panelStaffID.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewImport;
        private Button btnDelete;
        private TextBox txtSearch;
        private Panel pnHeading;
        private Label lblHeading;
        private Panel panelSupplier;
        private Label lblSupplier;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Button btnImportGoods;
        private Panel panelTotal;
        private Label lblTotal;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panelFiller;
        private TextBox txtTTAbove;
        private RadioButton rdbTTAbove;
        private Panel panelTop;
        private RadioButton rdbTTBelow;
        private TextBox txtTTBelow;
        private RadioButton rdbTTFromTo;
        private TextBox txtTTFrom;
        private TextBox txtTTTo;
        private Button btnRefresh;
        private Panel panelStaffID;
        private TextBox txtStaffID;
        private Label lblStaffID;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private TextBox txtSupplier;
        private PictureBox pictureBoxHome;
        private Label lblUser;
        private Label lblNote;
        private DataGridViewTextBoxColumn clmStockReceivedDocketID;
        private DataGridViewTextBoxColumn colStaffID;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewTextBoxColumn clmSupplier;
        private DataGridViewTextBoxColumn clmTotal;
        private DataGridViewTextBoxColumn colOwed;
        private Panel panelDate;
        private DateTimePicker dateTimePickerDateTo;
        private DateTimePicker dateTimePickerDateFrom;
        private RadioButton rdbDateFromTo;
        private DateTimePicker dateTimePickerDate;
        private RadioButton rdbDate;
        private Label lblDate;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}