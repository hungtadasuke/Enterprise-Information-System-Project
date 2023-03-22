using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class frmSupplier : Form
    {
        private SupplierBUS supplierBUS;
        private ErrorProvider errorProvider;
        public SupplierBUS SupplierBUS { get => supplierBUS; set => supplierBUS = value; }
        public ErrorProvider ErrorProvider { get => errorProvider; set => errorProvider = value; }
        public frmSupplier()
        {
            this.supplierBUS = new SupplierBUS();
            this.errorProvider = new ErrorProvider();
            InitializeComponent();
        }

        
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            SupportUI.DoubleBuffered(this.dataGridViewSupplier, true);
            this.loadDataGridView();
            this.removeSelectionCurrentRow();
            this.resetSupplierInfoUi();
        }

        public void loadDataGridView()
        {
            this.dataGridViewSupplier.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridViewSupplier.DataSource = this.supplierBUS.formatDataTableToShowUi(this.SupplierBUS.SupplierList);
            this.dataGridViewSupplier.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void removeSelectionCurrentRow()
        {
            if (this.dataGridViewSupplier.Rows.Count != 0)
            {
                this.dataGridViewSupplier.CurrentRow.Selected = false;
            }
        }
        private void resetSupplierInfoUi()
        {
            errorProvider.Clear();
            this.txtSupplierName1.Text = "";
            this.txtSupplierPhone1.Text = "";
            this.txtSupplierID.Text = "";
            this.txtSupplierName.Text = "";
            this.txtSupplierPhone.Text = "";
            this.txtSupplierAddress.Text = "";
            this.rbtnTrue.Checked = true;
            this.removeSelectionCurrentRow();

            this.btnAdd.Enabled = true;
            this.btnAdd.BackColor = Color.LightSkyBlue;

            this.btnUpdate.Enabled = false;
            this.btnUpdate.BackColor = Color.LightGray;
        }
        public void loadSupplierSearchListToDataGridView()
        {
            this.errorProvider.Clear();
            bool check = true;
            int Phone = -1;
            string name = "";
            string phone = "";
            name = this.txtSupplierName1.Text.Trim();
            if ((this.txtSupplierPhone1.Text.Trim() != "") && ((int.TryParse(this.txtSupplierPhone1.Text.Trim(), out Phone)) == false || int.Parse(this.txtSupplierPhone1.Text) < 0))
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierPhone1, "Số điện thoại không hợp lệ!");
            }
            phone = this.txtSupplierPhone1.Text.Trim();
            if(name ==""&&phone=="")
            {
                check = false;
                this.loadDataGridView();
                this.removeSelectionCurrentRow();
            }
            if (check == true)
            {
                DataTable tableSupplierSearch = this.supplierBUS.getSupplierSearchList(name, phone);
                this.dataGridViewSupplier.DataSource = this.supplierBUS.formatDataTableToShowUi(tableSupplierSearch);
                if (dataGridViewSupplier.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào theo yêu cầu của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadDataGridView();
                    this.removeSelectionCurrentRow();
                    this.resetSupplierInfoUi();
                }
            }
        }
        //click
        //hàm click
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.resetSupplierInfoUi();
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
            double Phone = 0;
            this.errorProvider.Clear();
            if (this.txtSupplierName.Text == "")
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierName, "Trường này không được để trống!");
            }
            if (this.txtSupplierPhone.Text == "")
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierPhone, "Trường này không được để trống!");
            }
            else if ((double.TryParse(this.txtSupplierPhone.Text.Trim(), out Phone)) == false || double.Parse(this.txtSupplierPhone.Text) < 0)
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierPhone, "Số điện thoại không hợp lệ!");
            }
            if (this.SupplierBUS.checkUniquePhoneAdd(this.txtSupplierPhone.Text.Trim()) == false)
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierPhone, "Số điện thoại bị trùng");
            }
            if (check == true)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thêm nhà cung cấp này vào database?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    SupplierDTO newSupplier = new SupplierDTO(null, this.txtSupplierName.Text.Trim(), this.txtSupplierAddress.Text.Trim(), this.txtSupplierPhone.Text.Trim(), this.getStatus());
                    MessageBox.Show(supplierBUS.insertSupplier(newSupplier), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetSupplierInfoUi();
                    this.loadDataGridView();
                    this.removeSelectionCurrentRow();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = true;
            double Phone = 0;
            this.errorProvider.Clear();
            if (this.txtSupplierName.Text == "")
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierName, "Trường này không được để trống!");
            }
            if (this.txtSupplierPhone.Text == "")
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierPhone, "Trường này không được để trống!");
            }
            else if ((double.TryParse(this.txtSupplierPhone.Text.Trim(), out Phone)) == false || double.Parse(this.txtSupplierPhone.Text) < 0)
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierPhone, "Số điện thoại không hợp lệ!");
            }
            if (this.SupplierBUS.checkUniquePhoneUpdate(this.txtSupplierID.Text.Trim(), this.txtSupplierPhone.Text.Trim()) == false)
            {
                check = false;
                this.errorProvider.SetError(this.txtSupplierPhone, "Số điện thoại bị trùng");
            }
            if (check == true)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa nhà cung cấp này trong database?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    SupplierDTO supplier = new SupplierDTO(this.txtSupplierID.Text.Trim(), this.txtSupplierName.Text.Trim(), this.txtSupplierAddress.Text.Trim(), this.txtSupplierPhone.Text.Trim(), this.getStatus());
                    MessageBox.Show(supplierBUS.updateSupplier(supplier), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetSupplierInfoUi();
                    this.loadDataGridView();
                    this.removeSelectionCurrentRow();
                }
            }
        }
        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                errorProvider.Clear();
                DataGridViewRow row = dataGridViewSupplier.Rows[e.RowIndex];
                this.txtSupplierID.Text = row.Cells[0].Value.ToString();
                this.txtSupplierName.Text = row.Cells[1].Value.ToString();
                this.txtSupplierAddress.Text = row.Cells[2].Value.ToString();
                this.txtSupplierPhone.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Hoạt động")
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
            this.loadSupplierSearchListToDataGridView();
            this.removeSelectionCurrentRow();
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        //đổi màu
        private void txtSupplierName1__TextChanged(object sender, EventArgs e)
        {
            this.txtSupplierName1.ForeColor = Color.Black;
        }

        private void txtSupplierPhone1__TextChanged(object sender, EventArgs e)
        {
            this.txtSupplierPhone1.ForeColor = Color.Black;
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
        private bool getStatus()
        {
            if (this.rbtnTrue.Checked)
            {
                return true;
            }
            return false;
        }
        
    }
}
