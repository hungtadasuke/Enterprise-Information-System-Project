using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using CustomMessageBox;
using DTO;

namespace GUI
{
    public partial class frmStaff : Form
    {
        private StaffBUS staffBUS = new StaffBUS();
        private AccountBUS accountBus = new AccountBUS();
        public string newStaffID;

        public frmStaff()
        {
            InitializeComponent();
        }

        //các sự kiện hover đổi màu button, đổi icon
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Image = GUI.Properties.Resources.icons8_home_page_322;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = GUI.Properties.Resources.icons8_home_page_32__1_;
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

        private void btnAutoCreateUsername_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnAutoCreateUsername_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.FromArgb(24, 126, 232);
        }

        //Hàm tạo ID mới dựa vào cái ID mới nhất trong database.
        public void CreateNewStaffID()
        {
            DataTable dataTable = staffBUS.getAllID();//lấy danh sách ID dưới dạng DataTable
            int index = dataTable.Rows.Count;
            string[] staffId = new string[index];//khởi tạo mảng để lưu ID
            int i = 0;
            foreach (DataRow r in dataTable.Rows)
            {
                staffId[i] = r["StaffId"].ToString(); //chuyển đổi dữ liệu từ DT sang mảng
                i++;
            }
            string lastId = staffId[index - 1]; //lấy phần tử cuối của mảng
            string id = lastId.Split('T')[1]; //Cắt chữ "ST01" thì nó ra "S" và "01"
            int Id = int.Parse(id); //Chuyển cái "01" thành số => "01" -> 1
            string a = string.Format("{0:00}", Id + 1); //cộng thêm 1 cho số 1 => id mới = 2, format 2 thành "02"
            string newStaffId = "ST" + a;//thành phẩm là lấy chuỗi "ST" + "02" là ra ID mới <3. Yaaaaaa!
            newStaffID = newStaffId;
            //
            txtID.Texts = newStaffID;//gán cái id mới này vào ô TXTID trong form
            //MessageBox.Show(newStaffID);
        }

        public void loadDataToDatagridview()
        {
            string gender = "";
            if (radiobuttonMan.Checked)
                gender = "Nam";
            else if (radiobuttonWomen.Checked)
                gender = "Nữ";
            DataTable dt = staffBUS.getAllStaff(comboBoxPosition.Text, gender, txtNameSearch.Texts);
            dataGridViewStaff.DataSource = dt;
        }

        //Khi Load form thì đổ dữ liệu vào mấy cái combobox, lấy cái ID mới từ cái hàm ở trên
        private void frmStaff_Load(object sender, EventArgs e)
        {
            loadDataToDatagridview();
            //
            comboBoxPosition.Items.Add("Tất cả");
            comboBoxPosition.Items.Add("Quản lý");
            comboBoxPosition.Items.Add("Nhân viên bán hàng");
            comboBoxPosition.Items.Add("Nhân viên kho");
            comboBoxPosition.SelectedIndex = 0;

            //
            cbbPosition.Items.Add("Quản lý");
            cbbPosition.Items.Add("Nhân viên bán hàng");
            cbbPosition.Items.Add("Nhân viên kho");
            //
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            //
            CreateNewStaffID();
            //
        }

        //Khi Click vào 1 ô trong bảng
        private void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAutoCreateUsername.Enabled = false;
            //
            txtUsername.Enabled = false;//ẩn
            txtUsername.BorderColor = Color.Gray;
            txtUsername.BorderFocusColor = Color.Gray;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            //Ẩn hết mấy cái cảnh báo vì khi đã có trong bảng thì phải đầy đủ dữ liệu
            warningName.Visible = false;
            warningSex.Visible = false;
            warningPhoneNumber.Visible = false;
            warningAge.Visible = false;
            warningPassword.Visible = false;
            warningPhone.Visible = false;
            warningStatus.Visible = false;
            warningUsername.Visible = false;
            warningPosition.Visible = false;
            warningAddress.Visible = false;
            waringSpecialChar.Visible = false;
            warningHasUsername.Visible = false;
            //Thực hiện lấy dữ liệu từ dòng đang click vào đổ qua mấy ô bên cạnh
            int i;
            i = dataGridViewStaff.CurrentRow.Index;
            //Console.WriteLine(i);
            txtID.Texts = dataGridViewStaff.Rows[i].Cells[0].Value.ToString();
            txtName.Texts = dataGridViewStaff.Rows[i].Cells[1].Value.ToString();
            string gender = dataGridViewStaff.Rows[i].Cells[2].Value.ToString();
            if (gender == "Nam")
                radiobtnNam.Checked = true;
            else
                radiobtnNu.Checked = true;

            /*Hàm cắt chuỗi thời gian của ThieuHoang*/

            //string dateTime = dataGridViewStaff.Rows[i].Cells[4].Value.ToString();
            //int day = int.Parse(dateTime.Split(' ')[0].Split('/')[0]);
            //int month = int.Parse(dateTime.Split(' ')[0].Split('/')[1]);
            //int year = int.Parse(dateTime.Split(' ')[0].Split('/')[2]);
            //Console.WriteLine(day + "/" + month + "/" + year);

            /*Hàm format thời gian của Hùng*/
            DateTime dateTime1 = DateTime.Parse(dataGridViewStaff.Rows[i].Cells[3].Value.ToString());
            string datetime2 = dateTime1.ToString("dd/MM/yyyy");
            //Console.WriteLine(datetime2);
            dateTimePickerBirthday.Text = datetime2;

            txtPhoneNumber.Texts = dataGridViewStaff.Rows[i].Cells[4].Value.ToString();
            txtAddress.Texts = dataGridViewStaff.Rows[i].Cells[5].Value.ToString();
            //txtPosition.Texts = dataGridViewStaff.Rows[i].Cells[6].Value.ToString();
            cbbPosition.Texts = dataGridViewStaff.Rows[i].Cells[6].Value.ToString();

            bool flag = (dataGridViewStaff.Rows[i].Cells[7].Value.ToString()) == "Hoạt động";
            if (flag)
                radiobtnOn.Checked = true;
            else
                radiobtnOff.Checked = true;
            //username password thì phải lấy từ AccountDAO thông qua BUS
            AccountBUS accountBUS = new AccountBUS();
            AccountDTO account = new AccountDTO();
            account = accountBUS.GetAccountDTO(txtID.Texts);

            txtUsername.Texts = account.Username;
            txtPassword.Texts = account.Password;
            //Console.WriteLine(y.getUsername() + y.getPassword());
        }

        //Sự kiện cho nút LÀM MỚI hay Refresh, bấm vào là làm sạch mấy ô thông tin bên trái
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnAutoCreateUsername.Enabled = true;
            //
            txtUsername.Enabled = true;
            txtUsername.BorderColor = Color.FromArgb(24, 126, 232);
            txtUsername.BorderFocusColor = Color.OrangeRed;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            RefreshForm();
        }

        //Hàm LÀM MỚI phục vụ cho sự kiện nút LÀM MỚI
        public void RefreshForm()
        {
            //
            WarningPass15Chars.Visible = false;
            WarningUsername15chars.Visible = false;
            //
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            //
            txtUsername.Enabled = true;
            txtUsername.BorderColor = Color.FromArgb(24, 126, 232);
            txtUsername.BorderFocusColor = Color.OrangeRed;
            btnAutoCreateUsername.Enabled = true;

            //Làm xuất hiện lại cái ID mới nhất
            CreateNewStaffID();
            //Reset mọi ô
            //comboBoxPosition.Texts = "";
            comboBoxPosition.SelectedIndex = 0;
            radiobuttonMan.Checked = false;
            radiobuttonWomen.Checked = false;
            //txtNameSearch.Texts = "";
            //dataGridViewStaff.DataSource = staffBUS.getAllStaff();
            loadDataToDatagridview();
            txtID.Texts = newStaffID;
            txtName.Texts = "";
            radiobtnNam.Checked = false;
            radiobtnNu.Checked = false;
            dateTimePickerBirthday.Text = "";
            txtPhoneNumber.Texts = "";
            txtAddress.Texts = "";
            //txtPosition.Texts = "";
            cbbPosition.Texts = "";
            txtUsername.Texts = "";
            txtPassword.Texts = "";
            radiobtnOn.Checked = false;
            radiobtnOff.Checked = false;
            //Ẩn hết các cảnh báo
            warningName.Visible = false;
            warningSex.Visible = false;
            warningPhoneNumber.Visible = false;
            warningAge.Visible = false;
            warningPassword.Visible = false;
            warningPhone.Visible = false;
            warningStatus.Visible = false;
            warningUsername.Visible = false;
            warningPosition.Visible = false;
            warningAddress.Visible = false;
            waringSpecialChar.Visible = false;
            warningHasUsername.Visible = false;
        }

        //Hàm này để kiểm tra các ô nhập, phải nhập, chọn đầy đủ hết mới được thêm hay sửa
        public bool CheckTextBox()
        {
            bool flag = false;
            //format string
            string name = removeWhiteSpace(txtName.Texts);
            string phonenumber = removeWhiteSpace(txtPhoneNumber.Texts);
            string address = removeWhiteSpace(txtAddress.Texts);
            string username = removeWhiteSpace(txtUsername.Texts);
            string password = removeWhiteSpace(txtPassword.Texts);
            string position = removeWhiteSpace(cbbPosition.Texts);

            //check rỗng và kí tự đặc biệt

            //true là rỗng, false là kín
            if (name.Length == 0 || phonenumber.Length == 0 || address.Length == 0 || username.Length == 0 || password.Length == 0 || position.Length == 0)
            {
                flag = true;
                if (name.Length == 0)
                {
                    warningName.Visible = true;
                }
                if (phonenumber.Length == 0)
                {
                    warningPhone.Visible = true;
                }
                if (address.Length == 0)
                {
                    warningAddress.Visible = true;
                }
                if (username.Length == 0)
                {
                    warningUsername.Visible = true;
                }
                if (password.Length == 0)
                {
                    warningPassword.Visible = true;
                }
                if (position.Length == 0)
                {
                    warningPosition.Visible = true;
                }
            }
            else
            {
                flag = false;
                if (name.Length != 0)
                {
                    warningName.Visible = false;
                }
                if (phonenumber.Length != 0)
                {
                    warningPhone.Visible = false;
                }
                if (address.Length != 0)
                {
                    warningAddress.Visible = false;
                }
                if (username.Length != 0)
                {
                    warningUsername.Visible = false;
                }
                if (password.Length != 0)
                {
                    warningPassword.Visible = false;
                }
                if (position.Length != 0)
                {
                    warningPosition.Visible = false;
                }
            }
            return flag;
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

        //Hàm xóa khoảng trắng số điện thoại
        public string removeWhiteSpacePhoneNumberUsernamePassword(string str)
        {
            str = str.Trim();//xóa đầu cuối vd: "0912 0909   0989"
            string str2 = "";
            string[] listStr = str.Split(' ');
            for (int i = 0; i < listStr.Length; i++)
            {
                if (listStr[i] != " ")
                {
                    str2 += listStr[i];
                }
            }
            return str2;
        }

        //Hàm tính tuổi
        /*
         * https://helpex.vn/question/lam-cach-nao-de-tinh-tuoi-cua-ai-do-trong-c-%23-5cb02230ae03f645f42025cd
         */

        public int GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        //Hàm kiểm tra username tài khoản có bị trùng không, username không được trùng
        public bool hasUsername(string newUsername)
        {
            return accountBus.hasUsername(newUsername); //nếu trùng trả về False
        }

        //Hàm xử lý thêm nhân viên
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //
            string address = removeWhiteSpace(txtAddress.Texts);
            string username = removeWhiteSpacePhoneNumberUsernamePassword(txtUsername.Texts);
            string password = removeWhiteSpacePhoneNumberUsernamePassword(txtPassword.Texts);
            string position = removeWhiteSpace(cbbPosition.Texts);

            /*Kiểm tra tên có ký tự đặc biệt hay không*/
            string name = removeWhiteSpace(txtName.Texts);
            bool flag112 = hasSpecialChar(name);
            /*Kiểm số điện thoại có hợp lệ hay không*/
            string phonenumber = removeWhiteSpacePhoneNumberUsernamePassword(txtPhoneNumber.Texts);
            Char[] mang = phonenumber.ToCharArray();
            bool flag12 = false;
            for (int i = 0; i < mang.Length; i++)
            {
                if ((int)mang[i] >= 48 && (int)mang[i] <= 57 || mang.Length == 0)
                    flag12 = true;
                else
                {
                    flag12 = false;
                    break;
                }
            }
            if (flag12 == true && mang.Length == 10)
                warningPhoneNumber.Visible = false;//không hiện

            /*Kiểm các textbox còn lại hay không, nếu không hợp lệ thì hiện ra thông báo, còn hợp lệ hết mới tiến hành thêm nhân viên mới*/
            bool a = CheckTextBox();
            if (username.Length > 15 || password.Length > 15 || a == true || flag12 == false || flag112 == true || GetAge(dateTimePickerBirthday.Value) < 18 || (radiobtnNam.Checked == false && radiobtnNu.Checked == false) || (radiobtnOn.Checked == false & radiobtnOff.Checked == false) || hasUsername(username) == false || phonenumber[0] != '0' || phonenumber[1] == '0' || phonenumber[1] == '1' || phonenumber[1] == '2' || phonenumber[1] == '6' || phonenumber.Length != 10)
            {
                if (GetAge(dateTimePickerBirthday.Value) < 18)
                    warningAge.Visible = true;
                else
                    warningAge.Visible = false;
                //
                if (name.Length != 0)
                {
                    warningName.Visible = false;
                }
                if (address.Length != 0)
                {
                    warningAddress.Visible = false;
                }
                if (username.Length != 0)
                {
                    warningUsername.Visible = false;
                    if (username.Length > 15)
                    {
                        WarningUsername15chars.Visible = true;
                    }
                    else
                    {
                        WarningUsername15chars.Visible = false;
                    }
                }
                if (password.Length != 0)
                {
                    warningPassword.Visible = false;
                    if (password.Length > 15)
                    {
                        WarningPass15Chars.Visible = true;
                    }
                    else
                    {
                        WarningPass15Chars.Visible = false;
                    }
                }

                if (position.Length != 0)
                {
                    warningPosition.Visible = false;
                }
                //

                //
                if (flag112 == true)
                {
                    waringSpecialChar.Visible = true;
                }
                else
                    waringSpecialChar.Visible = false;
                if (radiobtnNam.Checked == false && radiobtnNu.Checked == false)
                {
                    warningSex.Visible = true;
                }
                else
                    warningSex.Visible = false;
                if (radiobtnOn.Checked == false && radiobtnOff.Checked == false)
                {
                    warningStatus.Visible = true;
                }
                else
                    warningStatus.Visible = false;
                if (hasUsername(username) == false)
                {
                    warningHasUsername.Visible = true;
                }
                else
                    warningHasUsername.Visible = false;
                if (phonenumber.Length != 0)
                {
                    warningPhone.Visible = false;
                    if (flag12 == false || phonenumber.Length != 10 || phonenumber[0] != '0' || phonenumber[1] == '0' || phonenumber[1] == '1' || phonenumber[1] == '2' || phonenumber[1] == '6') //không hợp lệ, có chữ hay dấu đặc biệt
                    {
                        warningPhoneNumber.Visible = true;//chỉ được nhập số, 10 ký tự
                        RJMessageBox.Show("Lưu ý: Số điện thoại hợp lệ là số điện thoại có 10 chữ số, không chứa ký tự đặc biệt, bắt đầu bằng '03', '04', '05', '07', '08', '09'.\nVí dụ : 0375 643 378 hay 0984 782 121 ...",
                                  "Thông báo",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    }
                }
                else
                {
                    warningPhone.Visible = true;//cảnh báo không được để trống
                    warningPhoneNumber.Visible = false;//chỉ được nhập số, 10 ký tự
                }
                RJMessageBox.Show("Thông tin nhân viên chưa đủ hoặc không hợp lệ!",
                                 "Thông báo",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            //trường hợp tất cả hợp lệ
            else
            {
                //
                string birthday = dateTimePickerBirthday.Value.Date.ToString("yyyy/MM/dd");
                string day = birthday.Split('/')[2];
                string month = birthday.Split('/')[1];
                string year = birthday.Split('/')[0];
                string birthdayStaff = year + '-' + month + '-' + day;
                //
                string sex = null;
                if (radiobtnNam.Checked)
                    sex = "Nam";
                if (radiobtnNu.Checked)
                    sex = "Nữ";
                //
                bool status = false;
                if (radiobtnOn.Checked)
                    status = true;
                if (radiobtnOff.Checked)
                    status = false;
                //
                int flag = staffBUS.addStaff(name, sex, birthdayStaff, phonenumber, address, cbbPosition.Texts, status) ? 1 : 0;
                //
                int permission = -1;
                if (cbbPosition.Texts == "Quản lý")
                    permission = 0;
                else if (cbbPosition.Texts == "Nhân viên bán hàng")
                    permission = 1;
                else
                    permission = 2;
                bool statusAccount = false;
                if (status == true)
                    statusAccount = true;
                else
                    statusAccount = false;
                //string usernameAuto = createUsername(name, phonenumber, day, month);
                int flag2 = accountBus.addAccount(txtUsername.Texts, password, txtID.Texts, permission, statusAccount) ? 1 : 0;
                //
                if (flag == 1 && flag2 == 1)
                {
                    RefreshForm();
                    RJMessageBox.Show("Thêm nhân viên thành công!",
                                      "Thông báo",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                }
                else
                    RJMessageBox.Show("Thêm nhân viên thất bại!",
                                      "Thông báo",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string phonenumber = removeWhiteSpacePhoneNumberUsernamePassword(txtPhoneNumber.Texts);
            string address = removeWhiteSpace(txtAddress.Texts);
            string username = removeWhiteSpacePhoneNumberUsernamePassword(txtUsername.Texts);
            string password = removeWhiteSpacePhoneNumberUsernamePassword(txtPassword.Texts);
            string position = removeWhiteSpace(cbbPosition.Texts);

            /*Kiểm tra tên có ký tự đặc biệt hay không*/
            string name = removeWhiteSpace(txtName.Texts);
            bool flag112 = hasSpecialChar(name);
            /*Kiểm tra số điện thoại hợp lệ hay không*/
            Char[] mang = phonenumber.ToCharArray();
            bool flag12 = false;
            for (int i = 0; i < mang.Length; i++)
            {
                if ((int)mang[i] >= 48 && (int)mang[i] <= 57 || mang.Length == 0)
                    flag12 = true;
                else
                {
                    flag12 = false;
                    break;
                }
            }
            if (flag12 == true && mang.Length == 10)
                warningPhoneNumber.Visible = false;//ẩn
            else
                warningPhoneNumber.Visible = true;
            /*Kiểm tra các ô còn lại có hợp lệ hay không, phải hợp lệ hết mới tiến hành sửa*/
            bool a = CheckTextBox();
            if (password.Length > 15 || a == true || flag12 == false || flag112 == true || GetAge(dateTimePickerBirthday.Value) < 18 || (radiobtnNam.Checked == false && radiobtnNu.Checked == false) || (radiobtnOn.Checked == false & radiobtnOff.Checked == false) || phonenumber.Length != 10 || phonenumber[0] != '0' || phonenumber[1] == '0' || phonenumber[1] == '1' || phonenumber[1] == '2' || phonenumber[1] == '6')
            {
                if (GetAge(dateTimePickerBirthday.Value) < 18)
                    warningAge.Visible = true;
                else
                    warningAge.Visible = false;
                //
                if (name.Length != 0)
                {
                    warningName.Visible = false;
                }
                if (address.Length != 0)
                {
                    warningAddress.Visible = false;
                }
                if (username.Length != 0)
                {
                    warningUsername.Visible = false;
                }
                if (password.Length != 0)
                {
                    warningPassword.Visible = false;
                    if (password.Length > 15)
                    {
                        WarningPass15Chars.Visible = true;
                    }
                    else
                    {
                        WarningPass15Chars.Visible = false;
                    }
                }
                if (position.Length != 0)
                {
                    warningPosition.Visible = false;
                }
                //

                if (flag112 == true)
                {
                    waringSpecialChar.Visible = true;
                }
                else
                    waringSpecialChar.Visible = false;
                if (radiobtnNam.Checked == false && radiobtnNu.Checked == false)
                {
                    warningSex.Visible = true;
                }
                else
                    warningSex.Visible = false;
                if (radiobtnOn.Checked == false && radiobtnOff.Checked == false)
                {
                    warningStatus.Visible = true;
                }
                else
                    warningStatus.Visible = false;
                if (phonenumber.Length != 0)
                {
                    warningPhone.Visible = false;
                    if (flag12 == false || phonenumber.Length != 10 || phonenumber[0] != '0' || phonenumber[1] == '0' || phonenumber[1] == '1' || phonenumber[1] == '2' || phonenumber[1] == '6') //không hợp lệ, có chữ hay dấu đặc biệt
                    {
                        warningPhoneNumber.Visible = true;//chỉ được nhập số, 10 ký tự
                        RJMessageBox.Show("Lưu ý: Số điện thoại hợp lệ là số điện thoại có 10 chữ số, không chứa ký tự đặc biệt, bắt đầu bằng '03', '04', '05', '07', '08', '09'.\nVí dụ : 0375 643 378 hay 0984 782 121 ...",
                                  "Thông báo",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    }
                }
                else
                {
                    warningPhone.Visible = true;//cảnh báo không được để trống
                    warningPhoneNumber.Visible = false;//chỉ được nhập số
                }
                RJMessageBox.Show("Thông tin nhân viên chưa đủ hoặc không hợp lệ!",
                                  "Thông báo",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
            }
            //Khi tất cả đều hợp lệ
            else
            {
                //
                string birthday = dateTimePickerBirthday.Value.Date.ToString("yyyy/MM/dd");
                string day = birthday.Split('/')[2];
                string month = birthday.Split('/')[1];
                string year = birthday.Split('/')[0];
                string birthdayStaff = year + '-' + month + '-' + day;
                //
                string sex = null;
                if (radiobtnNam.Checked)
                    sex = "Nam";
                if (radiobtnNu.Checked)
                    sex = "Nữ";
                //
                bool status = false;
                if (radiobtnOn.Checked)
                    status = true;
                if (radiobtnOff.Checked)
                    status = false;
                //
                int flag = staffBUS.editStaff(name, sex, birthdayStaff, phonenumber, address, cbbPosition.Texts, status, txtID.Texts) ? 1 : 0;
                //
                int permission = -1;
                if (cbbPosition.Texts == "Quản lý")
                    permission = 0;
                else if (cbbPosition.Texts == "Nhân viên bán hàng")
                    permission = 1;
                else
                    permission = 2;
                bool statusAccount = false;
                if (status == true)
                    statusAccount = true;
                else
                    statusAccount = false;
                int flag2 = accountBus.editAccount(password, txtID.Texts, permission, statusAccount) ? 1 : 0;
                //
                if (flag == 1 && flag2 == 1)
                {
                    RefreshForm();
                    RJMessageBox.Show("Cập nhật thông tin nhân viên thành công!",
                                      "Thông báo",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                }
                else
                    RJMessageBox.Show("Cập nhật thông tin nhân viên thất bại!",
                                      "Thông báo",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataToDatagridview();
        }

        private void radiobuttonMan_CheckedChanged(object sender, EventArgs e)
        {
            loadDataToDatagridview();
        }

        private void radiobuttonWomen_CheckedChanged(object sender, EventArgs e)
        {
            loadDataToDatagridview();
        }

        private void txtNameSearch__TextChanged(object sender, EventArgs e)
        {
            loadDataToDatagridview();
        }

        public string createNumberIdForUsername(string phonenumber)
        {
            string phone1 = phonenumber;//"0123456789"
            string phone2 = phone1[4].ToString() + phone1[6].ToString() + phone1[8].ToString() + phone1[9].ToString();
            return phone2;
        }

        public string createNumberIdFromBirthday(string day, string month)
        {
            return day + month;
        }

        public string createUsername(string Name, string PhoneNumber, string day, string month)
        {
            string username1 = Name;//"Phan Mạnh Quỳnh"
            string username2 = RemoveUnicode(username1);//"Phan Manh Quynh"
            string username3 = username2.ToLower();//"phan manh quynh"
            string[] listChar = username3.Split(' ');//"phan" "manh" "quynh"
            string username4 = "";
            if (listChar.Length == 1)
            {
                username4 = listChar[0] + createNumberIdForUsername(PhoneNumber) + createNumberIdFromBirthday(day, month);
            }
            else
            {
                for (int i = 0; i < listChar.Length - 1; i++)
                {
                    string char1 = listChar[i];//"phan"
                    username4 += char1[0]; //"p"
                }
                username4 += listChar[listChar.Length - 1] + createNumberIdForUsername(PhoneNumber) + createNumberIdFromBirthday(day, month);
            }
            return username4;
        }

        //Hàm bỏ dấu chữ Tiếng Việt
        //http://www.hanhtranglaptrinh.com/2012/11/ham-bo-dau-tieng-viet-trong-c.html
        public string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                           "đ",
                                           "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                                           "í","ì","ỉ","ĩ","ị",
                                           "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                           "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                                           "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                           "d",
                                           "e","e","e","e","e","e","e","e","e","e","e",
                                           "i","i","i","i","i",
                                           "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                           "u","u","u","u","u","u","u","u","u","u","u",
                                           "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void btnAutoCreateUsername_Click(object sender, EventArgs e)
        {
            /*Kiểm tra tên có ký tự đặc biệt hay không*/
            string username = removeWhiteSpacePhoneNumberUsernamePassword(txtUsername.Texts);
            string name = removeWhiteSpace(txtName.Texts);
            bool flag112 = hasSpecialChar(name);
            /*Kiểm số điện thoại có hợp lệ hay không*/
            string phonenumber = removeWhiteSpacePhoneNumberUsernamePassword(txtPhoneNumber.Texts);
            Char[] mang = phonenumber.ToCharArray();
            bool flag12 = false;
            for (int i = 0; i < mang.Length; i++)
            {
                if ((int)mang[i] >= 48 && (int)mang[i] <= 57 || mang.Length == 0)
                    flag12 = true;
                else
                {
                    flag12 = false;
                    break;
                }
            }
            if (flag12 == true && mang.Length == 10)
                warningPhoneNumber.Visible = false;//không hiện

            /*Kiểm các textbox còn lại hay không, nếu không hợp lệ thì hiện ra thông báo, còn hợp lệ hết mới tiến hành thêm nhân viên mới*/
            bool a = CheckTextBox2();
            if (a == true || flag12 == false || flag112 == true || GetAge(dateTimePickerBirthday.Value) < 18 || hasUsername(username) == false || phonenumber.Length != 10)
            {
                if (GetAge(dateTimePickerBirthday.Value) < 18)
                    warningAge.Visible = true;
                else
                    warningAge.Visible = false;
                //
                if (name.Length != 0)
                {
                    warningName.Visible = false;
                }
                if (username.Length != 0)
                {
                    warningUsername.Visible = false;
                }
                //

                if (flag112 == true)
                {
                    waringSpecialChar.Visible = true;
                }
                else
                    waringSpecialChar.Visible = false;
                if (hasUsername(username) == false)
                {
                    warningHasUsername.Visible = true;
                }
                else
                    warningHasUsername.Visible = false;
                if (phonenumber.Length != 0)
                {
                    warningPhone.Visible = false;
                    if (flag12 == false || phonenumber.Length != 10) //không hợp lệ, có chữ hay dấu đặc biệt
                    {
                        warningPhoneNumber.Visible = true;//chỉ được nhập số, 10 ký tự
                        RJMessageBox.Show("Lưu ý: Số điện thoại hợp lệ là số điện thoại có 10 chữ số, không chứa ký tự đặc biệt, bắt đầu bằng '03', '04', '05', '07', '08', '09'.\nVí dụ : 0375 643 378 hay 0984 782 121 ...",
                                 "Thông báo",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    }
                }
                else
                {
                    warningPhone.Visible = true;//cảnh báo không được để trống
                    warningPhoneNumber.Visible = false;//chỉ được nhập số, 10 ký tự
                }
                RJMessageBox.Show("Tính năng 'Tạo tự động' cần có đủ 3 thông tin (hợp lệ) sau: Tên, Số điện thoại và Sinh nhật!",
                                "Thông báo",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            //trường hợp tất cả hợp lệ
            else
            {
                //
                string birthday = dateTimePickerBirthday.Value.Date.ToString("yyyy/MM/dd");
                string day = birthday.Split('/')[2];
                string month = birthday.Split('/')[1];

                string newUsername = createUsername(name, phonenumber, day, month);
                txtUsername.Texts = newUsername;
                warningAge.Visible = false;
            }
        }

        public bool CheckTextBox2()
        {
            bool flag = false;
            //format string
            string name = removeWhiteSpace(txtName.Texts);
            string phonenumber = removeWhiteSpace(txtPhoneNumber.Texts);

            //check rỗng và kí tự đặc biệt

            //true là rỗng, false là kín
            if (name.Length == 0 || phonenumber.Length == 0)
            {
                flag = true;
                if (name.Length == 0)
                {
                    warningName.Visible = true;
                }
                if (phonenumber.Length == 0)
                {
                    warningPhone.Visible = true;
                }
            }
            else
            {
                flag = false;
                if (name.Length != 0)
                {
                    warningName.Visible = false;
                }
                if (phonenumber.Length != 0)
                {
                    warningPhone.Visible = false;
                }
            }
            return flag;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}