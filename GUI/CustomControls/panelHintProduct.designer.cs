namespace GUI
{
    partial class panelHintProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCore = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pictureBoxProductImg = new System.Windows.Forms.PictureBox();
            this.panelCore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCore
            // 
            this.panelCore.Controls.Add(this.lblQuantity);
            this.panelCore.Controls.Add(this.lblPrice);
            this.panelCore.Controls.Add(this.lblProductId);
            this.panelCore.Controls.Add(this.lblProductName);
            this.panelCore.Controls.Add(this.pictureBoxProductImg);
            this.panelCore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCore.Location = new System.Drawing.Point(0, 0);
            this.panelCore.Name = "panelCore";
            this.panelCore.Size = new System.Drawing.Size(396, 87);
            this.panelCore.TabIndex = 0;
            this.panelCore.MouseEnter += new System.EventHandler(this.panelCore_MouseEnter);
            this.panelCore.MouseLeave += new System.EventHandler(this.panelCore_MouseLeave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(325, 63);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuantity.MouseEnter += new System.EventHandler(this.lblQuantity_MouseEnter);
            this.lblQuantity.MouseLeave += new System.EventHandler(this.lblQuantity_MouseLeave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(101, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            this.lblPrice.MouseEnter += new System.EventHandler(this.lblPrice_MouseEnter);
            this.lblPrice.MouseLeave += new System.EventHandler(this.lblPrice_MouseLeave);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(101, 38);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(57, 13);
            this.lblProductId.TabIndex = 2;
            this.lblProductId.Text = "ProductId";
            this.lblProductId.MouseEnter += new System.EventHandler(this.lblProductId_MouseEnter);
            this.lblProductId.MouseLeave += new System.EventHandler(this.lblProductId_MouseLeave);
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(98, 11);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(284, 23);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "ProducName";
            this.lblProductName.MouseEnter += new System.EventHandler(this.lblProductName_MouseEnter);
            this.lblProductName.MouseLeave += new System.EventHandler(this.lblProductName_MouseLeave);
            // 
            // pictureBoxProductImg
            // 
            this.pictureBoxProductImg.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxProductImg.Name = "pictureBoxProductImg";
            this.pictureBoxProductImg.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductImg.TabIndex = 0;
            this.pictureBoxProductImg.TabStop = false;
            this.pictureBoxProductImg.MouseEnter += new System.EventHandler(this.pictureBoxProductImg_MouseEnter);
            this.pictureBoxProductImg.MouseLeave += new System.EventHandler(this.pictureBoxProductImg_MouseLeave);
            // 
            // panelHintProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCore);
            this.Name = "panelHintProduct";
            this.Size = new System.Drawing.Size(396, 87);
            this.panelCore.ResumeLayout(false);
            this.panelCore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelCore;
        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.PictureBox pictureBoxProductImg;
        public System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblProductId;
    }
}
