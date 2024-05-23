using BUS;
using DTO;
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
    public partial class frmMainMenu : Form
    {
        StaffBUS staffBUS = new StaffBUS();

        public frmMainMenu()
        {
            InitializeComponent();
            //loadManagerMenu();
        }

        public frmMainMenu(AccountDTO account)
        {
            InitializeComponent();
            lblUser.Text = account.StaffID + " - " + staffBUS.getStaffById(account.StaffID).StaffName.ToString();
            if (account.Permission == 0)
            {
                loadManagerMenu();
            }
            else if (account.Permission == 1)
            {
                loadSaleStaffMenu();
            }
            else if (account.Permission == 2)
            {
                loadWarehouseStaffMenu();
            }
        }

        public void loadSaleStaffMenu()
        {
            panelSell.Visible = true;
            panelCustomer.Visible = true;
            panelReceipt.Visible = true;
            this.Size = new Size(this.Size.Width, 400); 
        }

        public void loadWarehouseStaffMenu()
        {
            panelIRV.Visible = true;
            panelPV.Visible = true;
            panelCategory.Visible = true;
            panelProduct.Visible = true;
            panelSupplier.Visible = true;
            this.Size = new Size(this.Size.Width, 500);
        }

        public void loadManagerMenu()
        {
            panelSell.Visible = true;
            panelCustomer.Visible = true;
            panelReceipt.Visible = true;
            panelIRV.Visible = true;
            panelPV.Visible = true;
            panelCategory.Visible = true;
            panelProduct.Visible = true;
            panelSupplier.Visible = true;
            panelStaff.Visible = true;
            panelStatistic.Visible = true;
        }

        private void btnIRV_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lblUser.Text.Split('-')[0].Trim());
            this.Hide();
            frmInventoryReceivingVoucher newForm = new frmInventoryReceivingVoucher(staffBUS.getStaffById(lblUser.Text.Split('-')[0].Trim()));
            newForm.ShowDialog();
            this.Show();
        }

        private void btnPV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaymentVoucher newForm = new frmPaymentVoucher(staffBUS.getStaffById(lblUser.Text.Split('-')[0].Trim()));
            newForm.ShowDialog();
            this.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSell newForm = new frmSell(staffBUS.getStaffById(lblUser.Text.Split('-')[0].Trim()));
            newForm.ShowDialog();
            this.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer newForm = new frmCustomer();
            newForm.ShowDialog();
            this.Show();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBill newForm = new frmBill();
            newForm.ShowDialog();
            this.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductManagement newForm = new frmProductManagement();
            newForm.ShowDialog();
            this.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategory newForm = new frmCategory();
            newForm.ShowDialog();
            this.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaff newForm = new frmStaff();
            newForm.ShowDialog();
            this.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplier newForm = new frmSupplier();
            newForm.ShowDialog();
            this.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStatistics newForm = new frmStatistics();
            newForm.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Dispose();
        }
    }
}
