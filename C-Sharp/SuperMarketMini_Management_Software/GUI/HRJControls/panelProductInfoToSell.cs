using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class panelProductInfoToSell : Panel
    {
        //Fields
        private Label lblProductPrice;
        private Label lblProductName;
        private PictureBox picProduct;
        private Label lblQuantity;

        //Properties
        public Label LblProductPrice { get => lblProductPrice; set => lblProductPrice = value; }
        public Label LblProductName { get => lblProductName; set => lblProductName = value; }
        public PictureBox PicProduct { get => picProduct; set => picProduct = value; }
        public Label LblQuantity { get => lblQuantity; set => lblQuantity = value; }

        //Constructor
        public panelProductInfoToSell(string productId, string productName, double productPrice, int quantity, Image productImg)
        {
            LblProductName = new Label();
            LblProductPrice = new Label();
            LblQuantity = new Label();
            PicProduct = new PictureBox();

            this.BackColor = Color.White;
            this.Controls.Add(this.LblProductPrice);
            this.Controls.Add(this.LblProductName);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.PicProduct);
            this.Location = new Point(2, 2);
            this.Margin = new Padding(2);
            this.Size = new Size(200, 92);
            this.TabIndex = 0;
            this.Name = productId;
            this.Cursor = Cursors.Hand;
            this.MouseEnter += new EventHandler(this_MouseEnter);
            this.MouseLeave += new EventHandler(this_MouseLeave);
            // 
            // lblProductName
            // 
            this.LblProductName.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.LblProductName.Location = new Point(45, 15);
            this.LblProductName.Margin = new Padding(2, 0, 2, 0);
            this.LblProductName.Size = new Size(153, 40);
            this.LblProductName.TabIndex = 1;
            this.LblProductName.Text = productName;
            this.LblProductName.MouseEnter += new EventHandler(this_MouseEnter);
            this.LblProductName.MouseLeave += new EventHandler(this_MouseLeave);

            // 
            // lblProductPrice
            // 
            this.LblProductPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.LblProductPrice.ForeColor = Color.Blue;
            this.LblProductPrice.Location = new Point(47, 62);
            this.LblProductPrice.Margin = new Padding(2, 0, 2, 0);
            this.LblProductPrice.Size = new Size(85, 15);
            this.LblProductPrice.TabIndex = 2;
            this.LblProductPrice.Text = String.Format("{0:0,0 đ}", productPrice);
            this.LblProductPrice.MouseEnter += new EventHandler(this_MouseEnter);
            this.LblProductPrice.MouseLeave += new EventHandler(this_MouseLeave);

            //
            //lblQuantity
            //
            this.LblQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.ForeColor = Color.Gray;
            this.LblQuantity.Location = new Point(130, 62);
            this.LblQuantity.Size = new Size(60, 15);
            this.LblQuantity.TabIndex = 0;
            this.LblQuantity.Text = "sl: " + quantity.ToString();

            // 
            // picProduct
            // 
            this.PicProduct.BackColor = Color.White;
            this.PicProduct.Image = productImg;
            this.PicProduct.Location = new Point(2, 0);
            this.PicProduct.Margin = new Padding(2);
            this.PicProduct.Size = new Size(40, 92);
            this.PicProduct.SizeMode = PictureBoxSizeMode.Zoom;
            this.PicProduct.TabIndex = 0;
            this.PicProduct.TabStop = false;
            this.PicProduct.MouseEnter += new EventHandler(this_MouseEnter);
            this.PicProduct.MouseLeave += new EventHandler(this_MouseLeave);
        }

        //Hover
        private void this_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void this_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }
    }
}
