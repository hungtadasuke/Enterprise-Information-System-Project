
namespace GUI
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNameSearch = new GUI.RJControls.RJTextBox();
            this.btnSearch = new GUI.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox1 = new GUI.RJControls.RJCircularPictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new GUI.RJControls.RJButton();
            this.btnAdd = new GUI.RJControls.RJButton();
            this.btnEdit = new GUI.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.radiobtnOff = new GUI.RJControls.RJRadioButton();
            this.radiobtnOn = new GUI.RJControls.RJRadioButton();
            this.txtName = new GUI.RJControls.RJTextBox();
            this.txtID = new GUI.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipBtnHome = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBtnRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBtnAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBtnEdit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBtnSearch = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(339, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 37);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quản Lý Nhóm Hàng";
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
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.txtNameSearch);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(992, 82);
            this.panel4.TabIndex = 0;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.txtNameSearch.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtNameSearch.BorderRadius = 8;
            this.txtNameSearch.BorderSize = 2;
            this.txtNameSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtNameSearch.Location = new System.Drawing.Point(419, 22);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameSearch.Multiline = false;
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNameSearch.PasswordChar = false;
            this.txtNameSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNameSearch.PlaceholderText = "Tên";
            this.txtNameSearch.Size = new System.Drawing.Size(291, 36);
            this.txtNameSearch.TabIndex = 23;
            this.txtNameSearch.Texts = "";
            this.txtNameSearch.UnderlinedStyle = false;
            this.txtNameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(764, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.toolTipBtnSearch.SetToolTip(this.btnSearch, "Dùng để tìm kiếm sau khi nhập từ khóa là Tên vào ô bên cạnh.");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.panel3.Controls.Add(this.rjCircularPictureBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(992, 167);
            this.panel3.TabIndex = 2;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::GUI.Properties.Resources.logo_and_text_2;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(35, 1);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(83, 83);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 4;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(938, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 27);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.toolTipBtnHome.SetToolTip(this.btnExit, "Quay lại giao diện chọn chức năng.");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(920, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 531);
            this.panel1.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 6;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(18, 253);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 36);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.toolTipBtnRefresh.SetToolTip(this.btnRefresh, "Dùng để làm mới trang.");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnRefresh_MouseLeave);
            this.btnRefresh.MouseHover += new System.EventHandler(this.btnRefresh_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::GUI.Properties.Resources.add__2_;
            this.btnAdd.Location = new System.Drawing.Point(18, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.toolTipBtnAdd.SetToolTip(this.btnAdd, "Dùng để lưu thông tin khi muốn thêm nhóm hàng mới.");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 6;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::GUI.Properties.Resources.draw;
            this.btnEdit.Location = new System.Drawing.Point(18, 406);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(35, 36);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.toolTipBtnEdit.SetToolTip(this.btnEdit, "Dùng để lưu chỉnh sửa thông tin nhóm hàng.");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            this.btnEdit.MouseHover += new System.EventHandler(this.btnEdit_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCategory);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 531);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AllowUserToAddRows = false;
            this.dataGridViewCategory.AllowUserToDeleteRows = false;
            this.dataGridViewCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCategory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategory.ColumnHeadersHeight = 35;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCategory.EnableHeadersVisualStyles = false;
            this.dataGridViewCategory.GridColor = System.Drawing.Color.White;
            this.dataGridViewCategory.Location = new System.Drawing.Point(416, 189);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.ReadOnly = true;
            this.dataGridViewCategory.RowHeadersVisible = false;
            this.dataGridViewCategory.RowHeadersWidth = 50;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(151)))), ((int)(((byte)(237)))));
            this.dataGridViewCategory.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategory.Size = new System.Drawing.Size(499, 326);
            this.dataGridViewCategory.TabIndex = 7;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "CategoryId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductName.HeaderText = "Mã nhóm hàng";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "CategoryName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.FillWeight = 180F;
            this.Quantity.HeaderText = "Tên nhóm hàng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StatusItem";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.FillWeight = 140F;
            this.Column1.HeaderText = "Trạng thái";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.radiobtnOff);
            this.panel6.Controls.Add(this.radiobtnOn);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Controls.Add(this.txtID);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(3, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(410, 544);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-1, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "*Mã nhóm hàng sẽ được tạo tự động sau khi bạn thêm nhóm hàng mới.";
            // 
            // radiobtnOff
            // 
            this.radiobtnOff.AutoSize = true;
            this.radiobtnOff.CheckedColor = System.Drawing.Color.OrangeRed;
            this.radiobtnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobtnOff.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radiobtnOff.Location = new System.Drawing.Point(252, 192);
            this.radiobtnOff.MinimumSize = new System.Drawing.Size(0, 21);
            this.radiobtnOff.Name = "radiobtnOff";
            this.radiobtnOff.Size = new System.Drawing.Size(162, 24);
            this.radiobtnOff.TabIndex = 16;
            this.radiobtnOff.TabStop = true;
            this.radiobtnOff.Text = "Ngừng kinh doanh";
            this.radiobtnOff.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.radiobtnOff.UseVisualStyleBackColor = true;
            // 
            // radiobtnOn
            // 
            this.radiobtnOn.AutoSize = true;
            this.radiobtnOn.CheckedColor = System.Drawing.Color.OrangeRed;
            this.radiobtnOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobtnOn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radiobtnOn.Location = new System.Drawing.Point(138, 192);
            this.radiobtnOn.MinimumSize = new System.Drawing.Size(0, 21);
            this.radiobtnOn.Name = "radiobtnOn";
            this.radiobtnOn.Size = new System.Drawing.Size(114, 24);
            this.radiobtnOn.TabIndex = 15;
            this.radiobtnOn.TabStop = true;
            this.radiobtnOn.Text = "Kinh doanh";
            this.radiobtnOn.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.radiobtnOn.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(232)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtName.BorderRadius = 8;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(143, 124);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(263, 31);
            this.txtName.TabIndex = 9;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.BorderColor = System.Drawing.Color.Gray;
            this.txtID.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txtID.BorderRadius = 8;
            this.txtID.BorderSize = 2;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.DimGray;
            this.txtID.Location = new System.Drawing.Point(142, 55);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtID.PlaceholderText = "";
            this.txtID.Size = new System.Drawing.Size(264, 31);
            this.txtID.TabIndex = 8;
            this.txtID.Texts = "";
            this.txtID.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(3, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(2, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm hàng";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveChip Mart";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RJControls.RJButton btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private RJControls.RJTextBox txtNameSearch;
        private RJControls.RJButton btnSearch;
        private RJControls.RJButton btnEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private RJControls.RJRadioButton radiobtnOff;
        private RJControls.RJRadioButton radiobtnOn;
        private RJControls.RJTextBox txtName;
        private RJControls.RJTextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnExit;
        private RJControls.RJButton btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Label label4;
        private RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolTip toolTipBtnHome;
        private System.Windows.Forms.ToolTip toolTipBtnRefresh;
        private System.Windows.Forms.ToolTip toolTipBtnAdd;
        private System.Windows.Forms.ToolTip toolTipBtnEdit;
        private System.Windows.Forms.ToolTip toolTipBtnSearch;
    }
}