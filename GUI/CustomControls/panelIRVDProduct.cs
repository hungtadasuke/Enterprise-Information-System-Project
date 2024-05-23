using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class panelIRVDProduct : UserControl
    {

        public panelIRVDProduct(string productId, string productName, int quantity, double importPrice)
        {

            InitializeComponent();

            lblProductId.Text = productId;
            lblProductName.Text = productName;
            txtUnitPrice.Text = importPrice.ToString();
            txtQuantity.Text = quantity.ToString();

            designTextbox();
        }

        public panelIRVDProduct()
        {
            InitializeComponent();
        }

        public void designTextbox()
        {
            System.Globalization.CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("vi-VN");
            txtUnitPrice.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", doubleFromCurrency(txtUnitPrice.Text));
            txtTotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", doubleFromCurrency(txtQuantity.Text) * doubleFromCurrency(txtUnitPrice.Text));
        }

        private double doubleFromCurrency(string price)
        {
            double d;
            string productPrice = "";
            string[] numbers = Regex.Split(price, @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    productPrice += value;
                }
            }
            d = double.Parse(productPrice);
            return d;
        }

        public bool texboxLimit_Numberic(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && /*!char.IsControl(ch)*/ !(ch == (char)8))
            {
                e.Handled = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!texboxLimit_Numberic(e))
            {
                return;
            }
        }

        private void btnIncreaseQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = Convert.ToString(int.Parse(txtQuantity.Text) + 1);
        }

        private void btnDecreaseQuantity_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQuantity.Text) > 1)
                txtQuantity.Text = Convert.ToString(int.Parse(txtQuantity.Text) - 1);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtQuantity.Text) > 999)
                {
                    txtQuantity.Text = "999";
                }
                designTextbox();
            }
            catch
            {
                txtQuantity.Text = "1";
            }
        }
    }
}
