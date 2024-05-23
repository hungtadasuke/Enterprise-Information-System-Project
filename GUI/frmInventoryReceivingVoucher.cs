using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmInventoryReceivingVoucher : Form
    {
        public InventoryReceivingVoucherBUS irvBUS = new InventoryReceivingVoucherBUS();
        public StaffBUS staffBUS = new StaffBUS();
        public ErrorProvider errorProvider = new ErrorProvider();
        public ErrorProvider errorProviderTT = new ErrorProvider();

        public frmInventoryReceivingVoucher()
        {
            InitializeComponent();
        }

        public frmInventoryReceivingVoucher(StaffDTO staff)
        {
            InitializeComponent();
            lblUser.Text = staff.StaffID + " - " + staff.StaffName;
        }

        private void clearComponent()
        {
            rdbDate.Checked = false;
            rdbDateFromTo.Checked = false;
            rdbTTAbove.Checked = false;
            rdbTTBelow.Checked = false;
            rdbTTFromTo.Checked = false;
            txtStaffID.Clear();
            txtSupplier.Clear();
        }

        private void loadDataGridView(DataTable dt)
        {
            dataGridViewImport.AutoGenerateColumns = false;
            dataGridViewImport.DataSource = dt;
            dataGridViewImport.ClearSelection();
        }

        private void loadTextBoxAutoCompleteCustomSource()
        {
            AutoCompleteStringCollection supllierData = new AutoCompleteStringCollection();
            DataTable supplier = irvBUS.getAllSupplier();
            foreach (DataRow dr in supplier.Rows)
            {
                supllierData.Add(dr[0] + " - " + dr[1]);
            }
            txtSupplier.AutoCompleteCustomSource = supllierData;

            AutoCompleteStringCollection staffData = new AutoCompleteStringCollection();
            DataTable staff = irvBUS.getAllStaff();
            foreach (DataRow dr in staff.Rows)
            {
                staffData.Add(dr[0] + " - " + dr[1]);
            }
            txtStaffID.AutoCompleteCustomSource = staffData;
        }

        private void setUpFrom()
        {
            btnDelete.Enabled = false;
            txtSearch.Text = "Tìm kiếm mã phiếu nhập";
            clearComponent();
            loadDataGridView(irvBUS.getAllInventoryReceivingVoucher());
            loadTextBoxAutoCompleteCustomSource();
        }

        private void searchFilter()
        {
            string id = txtSearch.Text;
            string staffId = txtStaffID.Text;
            string supplierId = txtSupplier.Text;

            string[] staff = txtStaffID.Text.Split('-');
            staffId = staff[0].Trim();
            string[] supplier = txtSupplier.Text.Split('-');
            supplierId = supplier[0].Trim();

            int dateOption = 0;
            int totalOption = 0;
            DateTime date = new DateTime();
            DateTime dateFrom = new DateTime();
            DateTime dateTo = new DateTime();
            string total = "";
            string totalFrom = "";
            string totalTo = ""; 
            if (rdbDate.Checked == true)
            {
                dateOption = 1;
                date = dateTimePickerDate.Value.Date;
            }
            if (rdbDateFromTo.Checked)
            {
                dateOption = 2;
                dateFrom = dateTimePickerDateFrom.Value.Date;
                dateTo = dateTimePickerDateTo.Value.Date;
            }
            if (rdbTTAbove.Checked)
            {
                totalOption = 1;
                total = txtTTAbove.Text;
            }
            if (rdbTTBelow.Checked)
            {
                totalOption = 2;
                total = txtTTBelow.Text;
            }
            if (rdbTTFromTo.Checked)
            {
                totalOption = 3;
                totalFrom = txtTTFrom.Text;
                totalTo = txtTTTo.Text;
            }
            loadDataGridView(irvBUS.getIRVSearchLisst(id, staffId, supplierId, dateOption, date, dateFrom, dateTo, totalOption, total, totalFrom, totalTo));
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm mã phiếu nhập")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Tìm kiếm mã phiếu nhập";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnImportGoods_Click(object sender, EventArgs e)
        {
            frmInventoryReceivingVoucherDetail newFrom = new frmInventoryReceivingVoucherDetail();
            newFrom.Show();
        }

        private void rdbTTAbove_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTTAbove.Checked)
            {
                txtTTAbove.ReadOnly = false;
                txtTTAbove.Focus();
            } 
            else
            {
                txtTTAbove.Clear();
                txtTTAbove.ReadOnly = true;
            }
        }

        private void rdbTTBelow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTTBelow.Checked)
            {
                txtTTBelow.ReadOnly = false;
                txtTTBelow.Focus();
            }
            else
            {
                txtTTBelow.Clear();
                txtTTBelow.ReadOnly = true;
            }
        }

        private void rdbTTFromTo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTTFromTo.Checked)
            {
                txtTTFrom.ReadOnly = false;
                txtTTTo.ReadOnly = false;
                txtTTFrom.Focus();
            }
            else
            {
                txtTTFrom.Clear();
                txtTTTo.Clear();
                txtTTFrom.ReadOnly = true;
                txtTTTo.ReadOnly = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            setUpFrom();
        }

        private void rdbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDate.Checked)
            {
                dateTimePickerDate.Enabled = true;
                dateTimePickerDate.Focus();
            }
            else
            {
                dateTimePickerDate.Enabled = false;
            }
        }

        private void rdbDateFromTo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDateFromTo.Checked)
            {
                dateTimePickerDateFrom.Enabled = true;
                dateTimePickerDateTo.Enabled = true;
                dateTimePickerDateFrom.Focus();
            }
            else
            {
                dateTimePickerDateFrom.Enabled = false;
                dateTimePickerDateTo.Enabled = false;
            }
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            designDataGridView();
            setUpFrom();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*if (!txtSearch.Text.Equals("") && !txtSearch.Text.Equals("Tìm kiếm mã phiếu nhập"))
            {
                searchFilter();
            }
            else
            {
                loadDataGridView(irvBUS.getAllInventoryReceivingVoucher());
            }*/

            searchFilter();
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void dateTimePickerDateFrom_ValueChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void dateTimePickerDateTo_ValueChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void txtTTAbove_TextChanged(object sender, EventArgs e)
        {
            if (!txtTTAbove.Text.Equals(""))
            {
                try
                {
                    double.Parse(txtTTAbove.Text);
                    searchFilter();
                    errorProvider.Clear();
                }
                catch
                {
                    errorProvider.SetError(txtTTAbove, "Giá trị không hợp lệ");
                }
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtTTBelow_TextChanged(object sender, EventArgs e)
        {
            if (!txtTTBelow.Text.Equals(""))
            {
                try
                {
                    double.Parse(txtTTBelow.Text);
                    searchFilter();
                    errorProvider.Clear();
                }
                catch
                {
                    errorProvider.SetError(txtTTBelow, "Giá trị không hợp lệ");
                }
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtTTFrom_TextChanged(object sender, EventArgs e)
        {
            if (!txtTTFrom.Text.Equals(""))
            {
                try
                {
                    double.Parse(txtTTFrom.Text);
                    searchFilter();
                    errorProvider.Clear();
                }
                catch
                {
                    errorProvider.SetError(txtTTFrom, "Giá trị không hợp lệ");
                }
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtTTTo_TextChanged(object sender, EventArgs e)
        {
            if (!txtTTTo.Text.Equals(""))
            {
                try
                {
                    double.Parse(txtTTTo.Text);
                    searchFilter();
                    errorProviderTT.Clear();
                }
                catch
                {
                    errorProviderTT.SetError(txtTTTo, "Giá trị không hợp lệ");
                }
            }
            else
            {
                errorProviderTT.Clear();
            }
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.LightSkyBlue;
        }

        private void btnImportGoods_MouseEnter(object sender, EventArgs e)
        {
            btnImportGoods.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnImportGoods_MouseLeave(object sender, EventArgs e)
        {
            btnImportGoods.BackColor = Color.LightSkyBlue;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightSkyBlue;
        }

        public void designDataGridView()
        {
            dataGridViewImport.Columns["clmTotal"].DefaultCellStyle.Format = "c2";
            dataGridViewImport.Columns["clmTotal"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
            dataGridViewImport.Columns["colOwed"].DefaultCellStyle.Format = "c2";
            dataGridViewImport.Columns["colOwed"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
        }

        private void pictureBoxHome_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHome.Image = GUI.Properties.Resources.home;
        }

        private void pictureBoxHome_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHome.Image = GUI.Properties.Resources.home_hover;
        }

        private void dataGridViewImport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    InventoryReceivingVoucherDTO irv = irvBUS.getIRVById(dataGridViewImport.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    frmInventoryReceivingVoucherDetail newForm = new frmInventoryReceivingVoucherDetail(irv, staffBUS.getStaffById(lblUser.Text.Split('-')[0].Trim()));
                    //this.Visible = false;
                    this.Hide();
                    newForm.ShowDialog();
                    this.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Thông tin phiếu nhập không tồn tại.\nVui lòng làm mới trang !");
            }
        }

        private void panelTop_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panelFiller_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewImport.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (irvBUS.deleteIRV(dataGridViewImport.Rows[rowIndex].Cells[0].Value.ToString()) == 1)
                    {
                        setUpFrom();
                        MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo");
                    }
                    else if (irvBUS.deleteIRV(dataGridViewImport.Rows[rowIndex].Cells[0].Value.ToString()) == 2)
                    {
                        MessageBox.Show("Không thể xóa phiếu nhập do xung đột số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Hand);
                    }
                    else if ((irvBUS.deleteIRV(dataGridViewImport.Rows[rowIndex].Cells[0].Value.ToString()) == 0))
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! Vui lòng liên hệ hỗ trợ kĩ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            this.ActiveControl = null;
        }

        private void dataGridViewImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
