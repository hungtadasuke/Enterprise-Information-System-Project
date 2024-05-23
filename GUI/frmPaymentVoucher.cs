using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPaymentVoucher : Form
    {
        PaymentVoucherBUS PaymentVoucherBUS = new PaymentVoucherBUS();
        InventoryReceivingVoucherBUS irvBUS = new InventoryReceivingVoucherBUS();

        ErrorProvider  errorProvider = new ErrorProvider();

        public frmPaymentVoucher()
        {
            InitializeComponent();
        }

        public frmPaymentVoucher(StaffDTO staff)
        {
            InitializeComponent();
            lblUser.Text = staff.StaffID + " - " + staff.StaffName;
        }

        private void clearComponent()
        {
            comboBoxDecription.SelectedIndex = -1;
            dateTimePickerDate.Value = DateTime.Now;
            rdbDate.Checked = false;
            rdbDateFromTo.Checked = false;
            rdbTTAbove.Checked = false;
            rdbTTBelow.Checked = false;
            rdbTTFromTo.Checked = false;
            txtPVID.textBox1.Clear();
            txtNote.textBox1.Clear();
            txtPayMoney.textBox1.Clear();
            txtReID.textBox1.Clear();
            txtImportID_S.Clear();
            txtStaffID_S.Clear();
            comboBoxReason.SelectedIndex = -1;
        }

        private void setUpFrom()
        {
            btnDelete.Enabled = false;
            btnUpdatePV.Enabled = false;
            btnAddPV.Enabled = true;
            txtSearch.Text = "Tìm kiếm mã phiếu chi";
            txtStaffID.Texts = lblUser.Text;
            clearComponent();
            loadDataGridView(PaymentVoucherBUS.getAllPaymentVoucher());
        }

        private void loadDataGridView(DataTable dt)
        {
            dataGridViewPaymentVoucher.AutoGenerateColumns = false;
            dataGridViewPaymentVoucher.DataSource = dt;
            dataGridViewPaymentVoucher.ClearSelection();
        }

        public void designDataGridView()
        {
            dataGridViewPaymentVoucher.Columns["colMoney"].DefaultCellStyle.Format = "c0";
            dataGridViewPaymentVoucher.Columns["colMoney"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
        }

        private void loadTextBoxAutoCompleteCustomSource()
        {
            AutoCompleteStringCollection staffData = new AutoCompleteStringCollection();
            DataTable staff = irvBUS.getAllStaff();
            foreach (DataRow dr in staff.Rows)
            {
                staffData.Add(dr[0] + " - " + dr[1]);
            }
            txtStaffID_S.AutoCompleteCustomSource = staffData;

            txtStaffID.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtStaffID.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtStaffID.textBox1.AutoCompleteCustomSource = staffData;

            AutoCompleteStringCollection ỉvOwedData = new AutoCompleteStringCollection();
            DataTable irvOwed = irvBUS.getInventoryReceivingVoucherOwed();
            foreach (DataRow dr in irvOwed.Rows)
            {
                ỉvOwedData.Add(dr[0].ToString());
            }
            txtReID.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtReID.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtReID.textBox1.AutoCompleteCustomSource = ỉvOwedData;
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
                dateTimePickerDate_S.Enabled = true;
                dateTimePickerDate_S.Focus();
            }
            else
            {
                dateTimePickerDate_S.Enabled = false;
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm mã phiếu chi")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Tìm kiếm mã phiếu chi";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void frmPaymentVoucher_Load(object sender, EventArgs e)
        {
            setUpFrom();
            designDataGridView();
            loadTextBoxAutoCompleteCustomSource();
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.LightSkyBlue;
        }

        private void btnAddPV_MouseEnter(object sender, EventArgs e)
        {
            btnAddPV.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnAddPV_MouseLeave(object sender, EventArgs e)
        {
            btnAddPV.BackColor = Color.LightSkyBlue;
        }

        private void btnUpdatePV_MouseEnter(object sender, EventArgs e)
        {
            btnUpdatePV.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnUpdatePV_MouseLeave(object sender, EventArgs e)
        {
            btnUpdatePV.BackColor = Color.LightSkyBlue;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightSkyBlue;
        }

        private void panelTop_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panelFiller_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panelDetail_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void comboBoxDecription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDecription.SelectedIndex == 0)
            {
                lblReID.Visible = true;
                txtReID.Visible = true;
            }
            else
            {
                lblReID.Visible = false;
                txtReID.Visible = false;
            }
        }

        private void dataGridViewPaymentVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                errorProvider.Clear();
                DataGridViewRow row = dataGridViewPaymentVoucher.Rows[e.RowIndex];
                txtPVID.Texts = row.Cells["colID"].Value.ToString();
                dateTimePickerDate.Value = Convert.ToDateTime(row.Cells["colDate"].Value.ToString());
                txtPayMoney.Texts = Convert.ToString(row.Cells["colMoney"].Value).Split('.')[0];
                txtNote.Texts = row.Cells["colNote"].Value.ToString();
                if (row.Cells["colDecription"].Value.ToString().Equals("Thanh toán phiếu nhập") == true)
                {
                    comboBoxDecription.SelectedIndex = 0;
                    txtReID.Texts = row.Cells["colReID"].Value.ToString();
                }
                else
                {
                    comboBoxDecription.SelectedIndex = 1;
                }
                foreach (string s in txtStaffID.textBox1.AutoCompleteCustomSource)
                {
                    if (s.Contains(row.Cells["colStaffID"].Value.ToString()))
                    {
                        txtStaffID.Texts = s;
                        break;
                    }
                }

                btnAddPV.Enabled = false;

                btnUpdatePV.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void pictureBoxHome_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHome.Image = GUI.Properties.Resources.home_hover;
        }

        private void pictureBoxHome_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHome.Image = GUI.Properties.Resources.home;
        }

        private bool checkParamenter()
        {
            bool check = true;
            bool reID = true;
            bool staff = false;
            errorProvider.Clear();
            if (txtPayMoney.Texts == "")
            {
                errorProvider.SetError(this.txtPayMoney, "Trường này không được để trống!");
                check = false;
            }
            foreach (string s in txtStaffID.textBox1.AutoCompleteCustomSource)
            {
                if (s.Equals(txtStaffID.Texts))
                {
                    staff = true;
                }
            }
            if(staff == false)
            {
                errorProvider.SetError(txtStaffID, "Nhân viên không hợp lệ!");
            }
            if (comboBoxDecription.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxDecription, "Chọn lý do chi!");
                check = false;
            }
            else
            {
                if (comboBoxDecription.SelectedIndex == 0)
                {
                    reID = false;
                    foreach (string s in txtReID.textBox1.AutoCompleteCustomSource)
                    {
                        if (s.Equals(txtReID.Texts))
                        {
                            reID = true;
                        }
                    }
                    if (reID == false)
                    {
                        errorProvider.SetError(txtReID, "Phiếu nhập không hợp lệ");
                    }
                }
            }
            return (check && staff && reID);
        }

        private void btnAddPV_Click(object sender, EventArgs e)
        {
            if(checkParamenter())
            {
                DialogResult result = MessageBox.Show("Xác nhận thêm phiếu chi !", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PaymentVoucherDTO pv = new PaymentVoucherDTO();
                    pv.StaffID = txtStaffID.Texts.Split('-')[0].Trim();
                    pv.Date = dateTimePickerDate.Value;
                    pv.Reason = comboBoxDecription.Text;
                    pv.Paymoney = double.Parse(txtPayMoney.Texts);
                    pv.Note = txtNote.Texts;
                    pv.ReID = txtReID.Texts;

                    if (PaymentVoucherBUS.insertPV(pv))
                    {
                        MessageBox.Show("Thêm phiếu chi thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu chi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    setUpFrom();
                }
            }
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

        private void txtPayMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (texboxLimit_Numberic(e))
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa phiếu chi ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PaymentVoucherDTO pv = new PaymentVoucherDTO();
                pv.Id = txtPVID.Texts;
                pv.StaffID = txtStaffID.Texts.Split('-')[0].Trim();
                pv.Date = dateTimePickerDate.Value;
                pv.Reason = comboBoxDecription.Text;
                pv.Paymoney = double.Parse(txtPayMoney.Texts);
                pv.Note = txtNote.Texts;
                pv.ReID = txtReID.Texts;

                if (PaymentVoucherBUS.deletePV(pv))
                {
                    MessageBox.Show("Xóa phiếu chi thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa phiếu chi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                setUpFrom();
            }
        }

        private void btnUpdatePV_Click(object sender, EventArgs e)
        {
            if (checkParamenter())
            {
                DialogResult result = MessageBox.Show("Xác nhận sửa phiếu chi !", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PaymentVoucherDTO pv = new PaymentVoucherDTO();
                    pv.StaffID = txtStaffID.Texts.Split('-')[0].Trim();
                    pv.Date = dateTimePickerDate.Value;
                    pv.Reason = comboBoxDecription.Text;
                    pv.Paymoney = double.Parse(txtPayMoney.Texts);
                    pv.Note = txtNote.Texts;
                    pv.ReID = txtReID.Texts;
                    pv.Id = txtPVID.Texts;

                    if (PaymentVoucherBUS.updatePV(pv))
                    {
                        MessageBox.Show("Sửa phiếu chi thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa phiếu chi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    setUpFrom();
                }
            }
        }

        private void searchFilter()
        {
            string id = txtSearch.Text;
            string staffId = txtStaffID_S.Text;
            string irvID = txtImportID_S.Text;
            string reason = comboBoxReason.Text;

            string[] staff = txtStaffID_S.Text.Split('-');
            staffId = staff[0].Trim();

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
                date = dateTimePickerDate_S.Value.Date;
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
            loadDataGridView(PaymentVoucherBUS.getPVSearchList(id, staffId, irvID, reason, dateOption, date, dateFrom, dateTo, totalOption, total, totalFrom, totalTo));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*if (!txtSearch.Text.Equals("") && !txtSearch.Text.Equals("Tìm kiếm mã phiếu chi"))
            {
                searchFilter();
            }
            else
            {
                loadDataGridView(PaymentVoucherBUS.getAllPaymentVoucher());
            }*/
            searchFilter();
        }

        private void txtImportID_S_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void comboBoxReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReason.SelectedIndex != -1)
            {
                searchFilter();
            }
        }

        private void txtStaffID_S_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void rdbTTAbove_CheckedChanged_1(object sender, EventArgs e)
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

        private void rdbTTBelow_CheckedChanged_1(object sender, EventArgs e)
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

        private void rdbDate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbDate.Checked)
            {
                dateTimePickerDate_S.Enabled = true;
                dateTimePickerDate_S.Focus();
            }
            else
            {
                dateTimePickerDate_S.Enabled = false;
            }
        }

        private void rdbDateFromTo_CheckedChanged_1(object sender, EventArgs e)
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

        private void dateTimePickerDate_S_ValueChanged(object sender, EventArgs e)
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
            searchFilter();
        }

        private void txtTTBelow_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void txtTTFrom_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void txtTTTo_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void txtTTAbove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (texboxLimit_Numberic(e))
            {
                return;
            }
        }

        private void txtTTBelow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (texboxLimit_Numberic(e))
            {
                return;
            }
        }

        private void txtTTFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (texboxLimit_Numberic(e))
            {
                return;
            }
        }

        private void txtTTTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (texboxLimit_Numberic(e))
            {
                return;
            }
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
