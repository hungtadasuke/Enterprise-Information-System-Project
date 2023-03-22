using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using CustomMessageBox;
using DTO;

//thu nhỏ form
namespace GUI
{
    public partial class frmCategory : Form
    {
        private CategoryBUS categoryBUS = new CategoryBUS();

        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(24, 126, 232);
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(24, 126, 232);
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(24, 126, 232);
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(24, 126, 232);
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            dataGridViewCategory.DataSource = categoryBUS.getAllCategory();

            radiobtnOn.Checked = true;
            btnEdit.Enabled = false;//ẩn
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;//hiện
            btnAdd.Enabled = false;//ẩn
            int i;
            i = dataGridViewCategory.CurrentRow.Index;
            //Console.WriteLine(i);
            txtID.Texts = dataGridViewCategory.Rows[i].Cells[0].Value.ToString();
            txtName.Texts = dataGridViewCategory.Rows[i].Cells[1].Value.ToString();
            bool flag = dataGridViewCategory.Rows[i].Cells[2].Value.ToString() == "Kinh doanh";
            if (flag)
                radiobtnOn.Checked = true;
            else
                radiobtnOff.Checked = true;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Image = GUI.Properties.Resources.icons8_home_page_322;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = GUI.Properties.Resources.icons8_home_page_32__1_;
        }

        //Hàm kiểu tra coi textbox có chứa ký tự đặc biệt hay không, nếu có thì trả về True, hong thì False
        /*
         * https://helpex.vn/question/kiem-tra-cac-ky-tu-dac-biet-amp-%23-trong-mot-chuoi-60bfa127983d9c7a94c6555b
         */

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        //Hàm này để xóa những khoảng trắng dư thừa
        /*
         * https://blog.luyencode.net/xoa-khoang-trang-thua-trong-chuoi/
         */

        public string removeWhiteSpace(string str)
        {
            //format string
            str = str.Trim(); // Xóa đầu cuối
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            str = trimmer.Replace(str, " ");
            return str;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //format string
            string str = removeWhiteSpace(txtName.Texts);

            //check rỗng và kí tự đặc biệt
            var flag2 = false;

            if (str.Length == 0)
            {
                RJMessageBox.Show("Vui lòng nhập tên!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            //hợp lệ thì...
            else
            {
                //hong cho chứa kí tự đặc biệt
                flag2 = hasSpecialChar(str);
                if (flag2 == true)
                {
                    RJMessageBox.Show("Tên nhóm hàng không được chứa ký tự đặc biệt!",
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
                else
                {
                    bool flag3 = categoryBUS.checkTrung(str);
                    if (flag3 == true)
                    {
                        RJMessageBox.Show("Nhóm hàng đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        var status = false;
                        if (radiobtnOn.Checked)
                            status = true;
                        if (radiobtnOff.Checked)
                            status = false;

                        int flag = categoryBUS.addCategory(str, status) ? 1 : 0;

                        if (flag == 1)
                        {
                            RJMessageBox.Show("Thêm nhóm hàng thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            RefreshForm();
                        }
                        else
                            RJMessageBox.Show("Thêm nhóm hàng thất bại!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //format string
            string str = removeWhiteSpace(txtName.Texts);

            //check rỗng và kí tự đặc biệt
            var flag2 = false;

            if (str.Length == 0)
            {
                RJMessageBox.Show("Vui lòng nhập tên!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            //hợp lệ thì...
            else
            {
                //hong cho chứa kí tự đặc biệt
                flag2 = hasSpecialChar(str);
                if (flag2 == true)
                {
                    RJMessageBox.Show("Tên nhóm hàng không được chứa ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int indexRow = dataGridViewCategory.CurrentRow.Index;
                    bool flag3 = categoryBUS.checkTrung(str);
                    if (txtName.Texts == dataGridViewCategory.Rows[indexRow].Cells[1].Value.ToString())
                    {
                        var status = false;
                        if (radiobtnOn.Checked)
                            status = true;
                        if (radiobtnOff.Checked)
                            status = false;
                        int flag = categoryBUS.editCategory(str, status, txtID.Texts) ? 1 : 0;

                        if (flag == 1)
                        {
                            RJMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshForm();
                        }
                        else
                            RJMessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (flag3 == true)
                        {
                            RJMessageBox.Show("Nhóm hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            var status = false;
                            if (radiobtnOn.Checked)
                                status = true;
                            if (radiobtnOff.Checked)
                                status = false;
                            int flag = categoryBUS.editCategory(str, status, txtID.Texts) ? 1 : 0;

                            if (flag == 1)
                            {
                                RJMessageBox.Show("Cập nhật thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                RefreshForm();
                            }
                            else
                                RJMessageBox.Show("Cập nhật thất bại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        public void RefreshForm()
        {
            btnEdit.Enabled = false;//ẩn
            btnAdd.Enabled = true;//hiện
            dataGridViewCategory.DataSource = categoryBUS.getAllCategory();
            txtID.Texts = "";
            txtName.Texts = "";
            radiobtnOn.Checked = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            DataView dv = categoryBUS.getAllCategory().DefaultView;
            dv.RowFilter = string.Format("CategoryName like '%{0}%'", txtNameSearch.Texts);
            if (dv.Count.ToString() != "0")
            {
                dataGridViewCategory.DataSource = dv.ToTable();
            }
            else
            {
                RefreshForm();
                // MessageBox.Show("Không tìm thấy nhóm hàng '" + txtNameSearch.Texts + "'");
                RJMessageBox.Show("Không tìm thấy nhóm hàng '" + txtNameSearch.Texts + "'",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void txtNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Search();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}