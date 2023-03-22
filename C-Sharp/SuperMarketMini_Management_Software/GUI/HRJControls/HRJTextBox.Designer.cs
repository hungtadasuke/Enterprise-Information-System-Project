namespace GUI
{
    partial class HRJTextBox
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
            this.txtMyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMyBox
            // 
            this.txtMyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMyBox.Location = new System.Drawing.Point(10, 7);
            this.txtMyBox.Name = "txtMyBox";
            this.txtMyBox.Size = new System.Drawing.Size(230, 15);
            this.txtMyBox.TabIndex = 0;
            this.txtMyBox.Click += new System.EventHandler(this.txtMyBox_Click);
            this.txtMyBox.TextChanged += new System.EventHandler(this.txtMyBox_TextChanged);
            this.txtMyBox.Enter += new System.EventHandler(this.txtMyBox_Enter);
            this.txtMyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMyBox_KeyPress);
            this.txtMyBox.Leave += new System.EventHandler(this.txtMyBox_Leave);
            this.txtMyBox.MouseEnter += new System.EventHandler(this.txtMyBox_MouseEnter);
            this.txtMyBox.MouseLeave += new System.EventHandler(this.txtMyBox_MouseLeave);
            // 
            // HRJTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtMyBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "HRJTextBox";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMyBox;
    }
}
