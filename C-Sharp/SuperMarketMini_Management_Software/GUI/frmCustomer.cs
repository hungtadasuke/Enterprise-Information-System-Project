using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class frmCustomer : Form
    {
        private CustomerBUS customerBUS;
        private ErrorProvider errorProvider;

        public CustomerBUS CustomerBUS { get => customerBUS; set => customerBUS = value; }
        public ErrorProvider ErrorProvider { get => errorProvider; set => errorProvider = value; }
        public frmCustomer()
        {
            this.customerBUS = new CustomerBUS();
            this.errorProvider = new ErrorProvider();
            InitializeComponent();
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            SupportUI.DoubleBuffered(this.dataGridViewCustomer, true);
            this.loadDataGridView();
            this.removeSelectionCurrentRow();
            this.resetCustomerInfoUi();
        }

        public void loadDataGridView()
        {
            this.dataGridViewCustomer.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridViewCustomer.DataSource =this.customerBUS.formatDataTableToShowUi(this.CustomerBUS.CustomerList);
            this.dataGridViewCustomer.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void removeSelectionCurrentRow()
        {
            if (this.dataGridViewCustomer.Rows.Count != 0)
            {
                this.dataGridViewCustomer.CurrentRow.Selected = false;
            }
        }
        private void resetCustomerInfoUi()
        {
            errorProvider.Clear();
            this.rbtnMale1.Checked = false;
            this.rbtnFemale1.Checked = false;
            this.txtCustomerName1.Text = "";
            this.txtCustomerPhone1.Text = "";
            this.txtCustomerID.Text = "";
            this.txtCustomerName.Text = "";
            this.rbtnMale.Checked = false;
            this.rbtnFemale.Checked = false;
            this.txtCustomerPhone.Text = "";
            this.txtCustomerPoint.Text = "";
            this.rbtnTrue.Checked = true;
            this.removeSelectionCurrentRow();

            this.btnAdd.Enabled = true;
            this.btnAdd.BackColor = Color.LightSkyBlue;

            this.btnUpdate.Enabled = false;
            this.btnUpdate.BackColor = Color.LightGray;
        }
        public void loadCustomerSearchListToDataGridView()
        {
            this.errorProvider.Clear();
            bool check = true;
            int Phone = -1;
            string gender = "";
            string name = "";
            string phone = "";
            gender = this.getgender1();
            name = this.txtCustomerName1.Text.Trim();
            if ((this.txtCustomerPhone1.Text.Trim() !="") && ((int.TryParse(this.txtCustomerPhone1.Text.Trim(), out Phone)) == false || int.Parse(this.txtCustomerPhone1.Text) < 0))
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerPhone1, "Số điện thoại không hợp lệ!");
            }
            else
            {
            phone = this.txtCustomerPhone1.Text.Trim();
            }
            if(gender==""&&name==""&&phone=="")
            {
                check = false;
                this.loadDataGridView();
                this.removeSelectionCurrentRow();
            }    
            if (check == true)
            {
                DataTable tableCustomerSearch = this.customerBUS.getCustomerSearchList(gender, name, phone);
                this.dataGridViewCustomer.DataSource = this.customerBUS.formatDataTableToShowUi(tableCustomerSearch);
                if (dataGridViewCustomer.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào theo yêu cầu của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadDataGridView();
                    this.removeSelectionCurrentRow();
                    this.resetCustomerInfoUi();
                }
            }
        }
            //hàm click
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.resetCustomerInfoUi();
            this.loadDataGridView();
            this.removeSelectionCurrentRow();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            int Phone = 0;
            //int Point = 0;
            this.errorProvider.Clear();
            if (this.txtCustomerName.Text == "")
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerName, "Trường này không được để trống!");
            }
            if (this.rbtnMale.Checked == false && this.rbtnFemale.Checked == false)
            {
                check = false;
                this.errorProvider.SetError(this.tableLayoutPanelGender, "Xin hãy chọn giới tính khách hàng!");
            }
            if (this.txtCustomerPhone.Text == "")
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerPhone, "Trường này không được để trống!");
            }
            else if ((int.TryParse(this.txtCustomerPhone.Text.Trim(), out Phone)) == false || int.Parse(this.txtCustomerPhone.Text)<0)
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerPhone, "Số điện thoại không hợp lệ!");
            }
            if (this.CustomerBUS.checkUniquePhoneAdd(this.txtCustomerPhone.Text.Trim()) == false)
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerPhone, "Số điện thoại bị trùng");
            }
            /*else if (this.txtCustomerPoint.Text == "")
            {
                this.errorProvider.SetError(this.txtCustomerPoint, "Trường này không được để trống!");
            }
            else if (int.Parse(this.txtCustomerPoint.Text.Trim()) < 0 || int.TryParse(this.txtCustomerPoint.Text.Trim(), out Point) == false)
            {
                this.errorProvider.SetError(this.txtCustomerPoint, "Số điểm không hợp lệ!");
            }*/
            if (check==true)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thêm khách hàng này vào database?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    CustomerDTO newCustomer = new CustomerDTO(null, this.txtCustomerName.Text.Trim(), this.getgender(), this.txtCustomerPhone.Text.Trim(), 0, this.getStatus());
                    MessageBox.Show(customerBUS.insertCustomer(newCustomer), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetCustomerInfoUi();
                    this.loadDataGridView();
                    this.removeSelectionCurrentRow();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = true;
            int Phone = 0;
            //int Point = 0;
            this.errorProvider.Clear();
            if (this.txtCustomerName.Text == "")
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerName, "Trường này không được để trống!");
            }
            if (this.rbtnMale.Checked == false && this.rbtnFemale.Checked == false)
            {
                check = false;
                this.errorProvider.SetError(this.tableLayoutPanelGender, "Xin hãy chọn giới tính khách hàng!");
            }
            if (this.txtCustomerPhone.Text == "")
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerPhone, "Trường này không được để trống!");
            }
            else if((int.TryParse(this.txtCustomerPhone.Text.Trim(), out Phone)) == false || int.Parse(this.txtCustomerPhone.Text)<0)
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerPhone, "Số điện thoại không hợp lệ!");
            }
            if(this.CustomerBUS.checkUniquePhoneUpdate(this.txtCustomerID.Text.Trim(), this.txtCustomerPhone.Text.Trim())==false)
            {
                check = false;
                this.errorProvider.SetError(this.txtCustomerPhone, "Số điện thoại bị trùng");
            }
            /* else if (this.txtCustomerPoint.Text == "")
             {
                 this.errorProvider.SetError(this.txtCustomerPoint, "Trường này không được để trống!");
             }
             else if (int.Parse(this.txtCustomerPoint.Text.Trim()) < 0 || int.TryParse(this.txtCustomerPoint.Text.Trim(), out Point) == false)
             {
                 this.errorProvider.SetError(this.txtCustomerPoint, "Số điểm không hợp lệ!");
             }*/
            if(check==true)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa khách hàng này trong database?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    CustomerDTO customer = new CustomerDTO(this.txtCustomerID.Text.Trim(), this.txtCustomerName.Text.Trim(), this.getgender(), this.txtCustomerPhone.Text.Trim(), int.Parse(this.txtCustomerPoint.Text.Trim()), this.getStatus());
                    MessageBox.Show(customerBUS.updateCustomer(customer), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetCustomerInfoUi();
                    this.loadDataGridView();
                    this.removeSelectionCurrentRow();
                }
            }
        }
        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                errorProvider.Clear();
                DataGridViewRow row = dataGridViewCustomer.Rows[e.RowIndex];
                this.txtCustomerID.Text = row.Cells[0].Value.ToString();
                this.txtCustomerName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    this.rbtnMale.Checked = true;
                }
                else
                {
                    this.rbtnFemale.Checked = true;
                }
                this.txtCustomerPhone.Text = row.Cells[3].Value.ToString();
                this.txtCustomerPoint.Text = row.Cells[4].Value.ToString().Split(' ')[0].Split(',')[0].Replace(".", ""); ;
                if (row.Cells[5].Value.ToString() == "Hoạt động")
                {
                    this.rbtnTrue.Checked = true;
                }
                else
                {
                    this.rbtnFalse.Checked = true;
                }
                this.btnAdd.Enabled = false;
                this.btnAdd.BackColor = Color.LightGray;

                this.btnUpdate.Enabled = true;
                this.btnUpdate.BackColor = Color.LightSkyBlue;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.loadCustomerSearchListToDataGridView();
            this.removeSelectionCurrentRow();
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void rbtnMale1_Click(object sender, EventArgs e)
        {
            if(this.rbtnMale1.Checked && !isChecked)
            {
                this.rbtnMale1.Checked = false;
            }
            else 
            {
                this.rbtnMale1.Checked = true;
                isChecked = false;
            }
        }
        private void rbtnFemale1_Click(object sender, EventArgs e)
        {
            if (this.rbtnFemale1.Checked && !isChecked2)
            {
                this.rbtnFemale1.Checked = false;
            }
            else
            {
                this.rbtnFemale1.Checked = true;
                isChecked2 = false;
            }
        }
        //đổi màu
        private void txtCustomerName1__TextChanged(object sender, EventArgs e)
        {
            this.txtCustomerName1.ForeColor = Color.Black;
        }

        private void txtCustomerPhone1__TextChanged(object sender, EventArgs e)
        {
            this.txtCustomerPhone1.ForeColor = Color.Black;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.Image = GUI.Properties.Resources.icons8_home_page_322;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.Image = GUI.Properties.Resources.icons8_home_page_32;
        }
        //kiểm tra radiobutton
        private string getgender()
        {
            if (this.rbtnMale.Checked)
            {
                return "Nam";
            }
            return "Nữ";
        }
        private string getgender1()
        {
            if (this.rbtnMale1.Checked)
            {
                return "Nam";
            }
            if (this.rbtnFemale1.Checked)
            {
                return "Nữ";
            }
            return "";
        }
        private bool getStatus()
        {
            if (this.rbtnTrue.Checked)
            {
                return true;
            }
            return false;
        }

        bool isChecked = false;
        private void rbtnMale1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = this.rbtnMale1.Checked;
        }
        bool isChecked2 = false;
        private void rbtnFemale1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked2 = this.rbtnFemale1.Checked;
        }
    }
}
