using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class panelHintProduct : UserControl
    {
        public panelHintProduct()
        {
            InitializeComponent();
        }
        private Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            Image img = Image.FromStream(ms);
            return img;
        }

        public panelHintProduct(string productId, string productName, byte[] productImage, double price, string quantity)
        {
            InitializeComponent();
            lblProductName.Text = productName;
            lblProductId.Text = productId;
            pictureBoxProductImg.Image = convertBinaryStringToImage(productImage);
            System.Globalization.CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("vi-VN");
            lblPrice.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", price);
            lblQuantity.Text = "SL: " + quantity;
        }

        private void panelCore_MouseEnter(object sender, EventArgs e)
        {
            panelCore.BackColor = Color.LightSteelBlue;
        }

        private void panelCore_MouseLeave(object sender, EventArgs e)
        {
            panelCore.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pictureBoxProductImg_MouseEnter(object sender, EventArgs e)
        {
            panelCore.BackColor = Color.LightSteelBlue;
        }

        private void pictureBoxProductImg_MouseLeave(object sender, EventArgs e)
        {
            panelCore.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void lblProductName_MouseEnter(object sender, EventArgs e)
        {
            panelCore.BackColor = Color.LightSteelBlue;
        }

        private void lblProductName_MouseLeave(object sender, EventArgs e)
        {
            panelCore.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void lblProductId_MouseEnter(object sender, EventArgs e)
        {
            panelCore.BackColor = Color.LightSteelBlue;
        }

        private void lblProductId_MouseLeave(object sender, EventArgs e)
        {
            panelCore.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void lblPrice_MouseEnter(object sender, EventArgs e)
        {
            panelCore.BackColor = Color.LightSteelBlue;
        }

        private void lblPrice_MouseLeave(object sender, EventArgs e)
        {
            panelCore.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void lblQuantity_MouseEnter(object sender, EventArgs e)
        {
            panelCore.BackColor = Color.LightSteelBlue;
        }

        private void lblQuantity_MouseLeave(object sender, EventArgs e)
        {
            panelCore.BackColor = SystemColors.GradientInactiveCaption;
        }
    }
}
