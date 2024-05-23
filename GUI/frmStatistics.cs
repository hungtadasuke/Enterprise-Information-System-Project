using BUS;
using GUI.Khoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmStatistics : Form
    {
        ProductBUS productBUS = new ProductBUS();
        StaffBUS staffBUS = new StaffBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        StatisticsBUS statisticsBUS = new StatisticsBUS();
        public frmStatistics()
        {
            InitializeComponent();
            KhoaPanel pnKhoa = new KhoaPanel();
        }

        private void pnProductStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frmProductSta();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void pnRevenueStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frmRevenueSta();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }


        }

        private void pnStaffStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frmStaffSta();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void pnCustomerStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frmCustomerSta();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void pbHome_MouseEnter(object sender, EventArgs e)
        {
            this.pbHome.Image = global::GUI.Properties.Resources.icons8_home_page_322;
        }

        private void pbHome_MouseLeave(object sender, EventArgs e)
        {
            this.pbHome.Image = global::GUI.Properties.Resources.icons8_home_page_32;
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            DataTable dtProduct = productBUS.ProductListFull;
            DataTable dtStaff = staffBUS.getAllStaff("Tất cả", "", "");
            DataTable dtCustomer = customerBUS.CustomerList;
            DataTable dtRevenue =  statisticsBUS.getAllBillByFilter("", DateTime.Today, DateTime.Today, -1, -1, 0);

            lblProductNumber.Text = dtProduct.Rows.Count.ToString();
            lblStaffNumber.Text = dtStaff.Rows.Count.ToString();
            lblCustomerNumber.Text = dtCustomer.Rows.Count.ToString();

            double sum = 0;
            if(dtProduct != null)
                foreach(DataRow dr in dtRevenue.Rows)
                {
                    sum += double.Parse(dr[3].ToString());
                }
            
            lblRevenueToday.Text = SupportBUS.formatPrice(sum.ToString());
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
