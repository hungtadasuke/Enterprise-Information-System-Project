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
    public partial class frmFastPayment : Form
    {

        public InventoryReceivingVoucherDTO irv = new InventoryReceivingVoucherDTO();
        ErrorProvider errorProvider = new ErrorProvider();
        PaymentVoucherBUS pvBUS = new PaymentVoucherBUS();

        public frmFastPayment()
        {
            InitializeComponent();
        }

        public frmFastPayment(InventoryReceivingVoucherDTO irv, StaffDTO staff)
        {
            InitializeComponent();
            this.irv = irv;
            lblUser.Text = staff.StaffID + " - " + staff.StaffName;
        }

        private void pictureBoxFastFillMoney_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFastFillMoney.Image = GUI.Properties.Resources.credit_card_hoverpng;
        }

        private void pictureBoxFastFillMoney_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFastFillMoney.Image = GUI.Properties.Resources.credit_card;
        }

        private void btnComplete_MouseEnter(object sender, EventArgs e)
        {
            btnComplete.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnComplete_MouseLeave(object sender, EventArgs e)
        {
            btnComplete.BackColor = Color.LightSkyBlue;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(253, 15, 41);
        }

        private void txtNote_Enter(object sender, EventArgs e)
        {
            if (txtNote.Texts == "Ghi chú")
            {
                txtNote.Texts = "";
                txtNote.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtNote_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNote.Texts))
            {
                txtNote.Texts = "Ghi chú";
                txtNote.ForeColor = Color.Gray;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMain_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void frmFastPayment_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txtReID.textBox1.Text = this.irv.Id;
        }

        private void pictureBoxFastFillMoney_Click(object sender, EventArgs e)
        {
            double maxValue = irv.Total - irv.Paid;
            txtMoney.Texts = maxValue.ToString();
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

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            texboxLimit_Numberic(e);
        }

        private void txtMoney__TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Texts != "")
            {
                double value = double.Parse(txtMoney.Texts);
                double maxValue = irv.Total - irv.Paid;
                if (value > maxValue)
                {
                    txtMoney.Texts = maxValue.ToString();
                }
            }
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (txtMoney.Texts == "")
            {
                errorProvider.SetError(txtMoney, "Thêm số tiền thanh toán");
            }
            else
            {
                DialogResult result = MessageBox.Show("Thanh toán phiếu nhập này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (txtNote.Texts == "Ghi chú")
                    {
                        txtNote.textBox1.Clear();
                    }

                    PaymentVoucherDTO pv = new PaymentVoucherDTO();
                    pv.Paymoney = double.Parse(txtMoney.Texts);
                    pv.Date = DateTime.Now.Date;
                    pv.StaffID = lblUser.Text.Split('-')[0].Trim();
                    pv.Reason = "Thanh toán phiếu nhập";
                    pv.Note = txtNote.Texts;
                    pv.ReID = txtReID.Texts;

                    if (pvBUS.insertPV(pv))
                    {
                        MessageBox.Show("Thanh toán thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
        }
    }
}
