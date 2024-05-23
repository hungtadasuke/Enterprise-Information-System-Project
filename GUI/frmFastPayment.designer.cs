namespace GUI
{
    partial class frmFastPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFastPayment));
            this.lblIRVID = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pictureBoxFastFillMoney = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtNote = new GUI.RJTextBox();
            this.txtMoney = new GUI.RJTextBox();
            this.txtReID = new GUI.RJTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFastFillMoney)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIRVID
            // 
            this.lblIRVID.AutoSize = true;
            this.lblIRVID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRVID.Location = new System.Drawing.Point(22, 51);
            this.lblIRVID.Name = "lblIRVID";
            this.lblIRVID.Size = new System.Drawing.Size(88, 21);
            this.lblIRVID.TabIndex = 0;
            this.lblIRVID.Text = "Phiếu nhập";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(22, 97);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(88, 21);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Thanh toán";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::GUI.Properties.Resources.x;
            this.btnCancel.Location = new System.Drawing.Point(25, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 66);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Image = global::GUI.Properties.Resources.check;
            this.btnComplete.Location = new System.Drawing.Point(111, 266);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(235, 66);
            this.btnComplete.TabIndex = 25;
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            this.btnComplete.MouseEnter += new System.EventHandler(this.btnComplete_MouseEnter);
            this.btnComplete.MouseLeave += new System.EventHandler(this.btnComplete_MouseLeave);
            // 
            // pictureBoxFastFillMoney
            // 
            this.pictureBoxFastFillMoney.Image = global::GUI.Properties.Resources.credit_card;
            this.pictureBoxFastFillMoney.Location = new System.Drawing.Point(96, 97);
            this.pictureBoxFastFillMoney.Name = "pictureBoxFastFillMoney";
            this.pictureBoxFastFillMoney.Size = new System.Drawing.Size(57, 23);
            this.pictureBoxFastFillMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFastFillMoney.TabIndex = 23;
            this.pictureBoxFastFillMoney.TabStop = false;
            this.pictureBoxFastFillMoney.Click += new System.EventHandler(this.pictureBoxFastFillMoney_Click);
            this.pictureBoxFastFillMoney.MouseEnter += new System.EventHandler(this.pictureBoxFastFillMoney_MouseEnter);
            this.pictureBoxFastFillMoney.MouseLeave += new System.EventHandler(this.pictureBoxFastFillMoney_MouseLeave);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblUser);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(373, 354);
            this.panelMain.TabIndex = 27;
            this.panelMain.Click += new System.EventHandler(this.panelMain_Click);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNote.BorderColor = System.Drawing.Color.Indigo;
            this.txtNote.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtNote.BorderSize = 2;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.Gray;
            this.txtNote.Location = new System.Drawing.Point(26, 148);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new System.Windows.Forms.Padding(7);
            this.txtNote.PasswordChar = false;
            this.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNote.Size = new System.Drawing.Size(320, 101);
            this.txtNote.TabIndex = 24;
            this.txtNote.Texts = "Ghi chú";
            this.txtNote.UnderlinedStyle = false;
            this.txtNote.Enter += new System.EventHandler(this.txtNote_Enter);
            this.txtNote.Leave += new System.EventHandler(this.txtNote_Leave);
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtMoney.BorderColor = System.Drawing.Color.Indigo;
            this.txtMoney.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtMoney.BorderSize = 2;
            this.txtMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMoney.Location = new System.Drawing.Point(176, 89);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Multiline = false;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Padding = new System.Windows.Forms.Padding(7);
            this.txtMoney.PasswordChar = false;
            this.txtMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMoney.Size = new System.Drawing.Size(170, 36);
            this.txtMoney.TabIndex = 22;
            this.txtMoney.Texts = "";
            this.txtMoney.UnderlinedStyle = true;
            this.txtMoney._TextChanged += new System.EventHandler(this.txtMoney__TextChanged);
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // txtReID
            // 
            this.txtReID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtReID.BorderColor = System.Drawing.Color.Indigo;
            this.txtReID.BorderFocusColor = System.Drawing.Color.Honeydew;
            this.txtReID.BorderSize = 2;
            this.txtReID.Enabled = false;
            this.txtReID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReID.Location = new System.Drawing.Point(176, 45);
            this.txtReID.Margin = new System.Windows.Forms.Padding(4);
            this.txtReID.Multiline = false;
            this.txtReID.Name = "txtReID";
            this.txtReID.Padding = new System.Windows.Forms.Padding(7);
            this.txtReID.PasswordChar = false;
            this.txtReID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReID.Size = new System.Drawing.Size(68, 36);
            this.txtReID.TabIndex = 21;
            this.txtReID.Texts = "";
            this.txtReID.UnderlinedStyle = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(22, 14);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(184, 21);
            this.lblUser.TabIndex = 28;
            this.lblUser.Text = "ST04 - Nguyễn Nhật Huy";
            // 
            // frmFastPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(373, 354);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtReID);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblIRVID);
            this.Controls.Add(this.pictureBoxFastFillMoney);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFastPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmFastPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFastFillMoney)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIRVID;
        private System.Windows.Forms.Label lblMoney;
        private RJTextBox txtReID;
        private RJTextBox txtMoney;
        private System.Windows.Forms.PictureBox pictureBoxFastFillMoney;
        private RJTextBox txtNote;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblUser;
    }
}