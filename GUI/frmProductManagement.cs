using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmProductManagement : Form
    {
        //Fields
        private ProductBUS productBUS;
        private ErrorProvider errorProvider;
        private Image imagePlaceHolder;

        //Properties
        public ProductBUS ProductBUS { get => productBUS; set => productBUS = value; }
        public ErrorProvider ErrorProvider { get => errorProvider; set => errorProvider = value; }
        public Image ImagePlaceHolder { get => imagePlaceHolder; set => imagePlaceHolder = value; }

        //Constructor
        public frmProductManagement()
        {
            //Khởi tạo các biến thành viên
            this.productBUS = new ProductBUS();
            this.errorProvider = new ErrorProvider();
            InitializeComponent();
            this.imagePlaceHolder = picProduct.Image;
        }

        //
        //Events
        //
        //Xử lý sự kiện load form
        private void frmProductManagementt_Load(object sender, EventArgs e)
        {
            //
            //dataGridView
            //
            //Hàm giúp datagridview scroll smoothly
            SupportUI.DoubleBuffered(this.dataGridViewProduct, true);
            //Hàm design text-align của một số cell column in datagridview
            this.designSomeColumsOfDataGridView();
            //Hàm load datagridview
            this.loadDataGridView();
            //Remove selected cell of datagridview when load form
            this.removeSelectionCurrentRow();

            //
            //comboBox
            //
            //Hàm set values of comboBoxs
            this.setValueOfComboBoxs();

            //Set default value for some components
            this.setDefaultForSomeComponents();
        }

        //Hover for buttons
        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            this.btnSearch.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            this.btnSearch.BackColor = Color.LightSkyBlue;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            this.btnReset.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            this.btnReset.BackColor = Color.LightSkyBlue;
        }

        private void btnAddProduct_MouseEnter(object sender, EventArgs e)
        {
            this.btnAddProduct.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnAddProduct_MouseLeave(object sender, EventArgs e)
        {
            this.btnAddProduct.BackColor = Color.LightSkyBlue;
        }

        private void btnEditProduct_MouseEnter(object sender, EventArgs e)
        {
            this.btnEditProduct.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnEditProduct_MouseLeave(object sender, EventArgs e)
        {
            this.btnEditProduct.BackColor = Color.LightSkyBlue;
        }

        private void btnAddQuantity_MouseEnter(object sender, EventArgs e)
        {
            this.btnAddQuantity.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnAddQuantity_MouseLeave(object sender, EventArgs e)
        {
            this.btnAddQuantity.BackColor = Color.LightSkyBlue;
        }

        private void btnSubQuantity_MouseEnter(object sender, EventArgs e)
        {
            this.btnSubQuantity.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnSubQuantity_MouseLeave(object sender, EventArgs e)
        {
            this.btnSubQuantity.BackColor = Color.LightSkyBlue;
        }

        private void picHome_MouseEnter(object sender, EventArgs e)
        {
            this.picHome.Image = global::GUI.Properties.Resources.icons8_home_page_322;
        }

        private void picHome_MouseLeave(object sender, EventArgs e)
        {
            this.picHome.Image = global::GUI.Properties.Resources.icons8_home_page_32;
        }

        //Xử lý sự kiện khi click pictureBoxProduct.
        private void picProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.picProduct.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn chỉ có thể chèn hình ảnh với định dạng Bitmap, GIF, Icon, JPeg hoặc Png!", "Chèn ảnh không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Hàm xử lý sự kiện khi nhấn vào một row nào đó của datagridview
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                errorProvider.Clear();
                //e.RowIndex sẽ trả về index của hàng được chọn
                //Tạo một đối tượng datagridviewRow tham chiếu tới hàng được chọn
                DataGridViewRow row = dataGridViewProduct.Rows[e.RowIndex];
                //Show thông tin của hàng đó lên các textBox, comboBox,... tương ứng bên vùng chứa thông tin sản phẩm
                this.cBCategory.Texts = row.Cells[0].Value.ToString();
                this.txtProductId.Text = row.Cells[1].Value.ToString();
                this.txtProductName.Text = row.Cells[2].Value.ToString();
                this.cBProductUnit.Texts = row.Cells[3].Value.ToString();
                this.txtImportPrice.Text = row.Cells[4].Value.ToString().Split(' ')[0].Split(',')[0].Replace(".", "");
                this.txtPriceToSell.Text = row.Cells[5].Value.ToString().Split(' ')[0].Split(',')[0].Replace(".", "");
                this.txtQuantity.Text = row.Cells[6].Value.ToString();
                this.picProduct.Image = convertBinaryStringToImage((byte[])row.Cells[7].Value);
                if (row.Cells[8].Value.ToString() == "Bán")
                {
                    this.rbtnTrue.Checked = true;
                }
                else
                {
                    this.rbtnFalse.Checked = true;
                }
                //Khi sự kiện này diễn ra thì set disable cho button thêm và hiện button edit
                this.btnAddProduct.Enabled = false;
                this.btnAddProduct.BackColor = Color.LightGray;

                this.btnEditProduct.Enabled = true;
                this.btnEditProduct.BackColor = Color.LightSkyBlue;
            }
        }

        //Xử lý sự kiện cho nút reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.resetProductInfoUi();
        }

        //Hàm thiết lập lại giá trị mặc định của các ô input và comboBox ở vùng productInfo
        private void resetProductInfoUi()
        {
            //reset các err của errProvider
            errorProvider.Clear();
            //Xét lại các giá trị mặc định cho các components trong vùng chứa thông tin sản phẩm
            this.cBCategory.Texts = "";
            this.cBProductUnit.Texts = "";
            this.txtProductId.Text = productBUS.getNewProductId();
            this.txtProductName.Text = "";
            this.txtImportPrice.Text = "";
            this.txtPriceToSell.Text = "";
            this.txtQuantity.Text = "0";
            this.picProduct.Image = global::GUI.Properties.Resources.ef3_placeholder_image;
            this.imagePlaceHolder = this.picProduct.Image;
            this.rbtnTrue.Checked = true;
            //Hàm remove selection cho ô đang chọn
            this.removeSelectionCurrentRow();
            //Khi sự kiện này diễn ra thì enable cho button thêm, và disable cho button edit
            this.btnAddProduct.Enabled = true;
            this.btnAddProduct.BackColor = Color.LightSkyBlue;

            this.btnEditProduct.Enabled = false;
            this.btnEditProduct.BackColor = Color.LightGray;
        }

        //Sự kiện cho btnAdd
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.errorProvider.Clear();
            bool valid = true;
            double importPrice = 0, priceToSell = 0;

            if (this.cBCategory.Texts == "")
            {
                valid = false;
                this.errorProvider.SetError(this.cBCategory, "Xin hãy chọn một nhóm hàng!");
            }
            if (this.txtProductName.Text == "")
            {
                valid = false;
                this.errorProvider.SetError(this.txtProductName, "Trường này không được để trống!");
            }
            if (this.cBProductUnit.Texts == "")
            {
                valid = false;
                this.errorProvider.SetError(this.cBProductUnit, "Xin hãy chọn một đơn vị tính cho sản phẩm!");
            }

            if (this.txtImportPrice.Text == "")
            {
                valid = false;
                this.errorProvider.SetError(this.txtImportPrice, "Trường này không được để trống!");
            }
            else if (Double.TryParse(this.txtImportPrice.Text.Trim(), out importPrice) == false)
            {
                valid = false;
                this.errorProvider.SetError(this.txtImportPrice, "Giá tiền nhập vào không hợp lệ!");
            }
            else { };

            if (this.txtPriceToSell.Text == "")
            {
                valid = false;
                this.errorProvider.SetError(this.txtPriceToSell, "Trường này không được để trống!");
            }
            else if (Double.TryParse(this.txtPriceToSell.Text.Trim(), out priceToSell) == false)
            {
                valid = false;
                this.errorProvider.SetError(this.txtPriceToSell, "Giá tiền nhập vào không hợp lệ!");
            }
            else if (Double.Parse(this.txtPriceToSell.Text.Trim()) < Double.Parse(this.txtImportPrice.Text.Trim())) {
                valid = false;
                this.errorProvider.SetError(this.txtPriceToSell, "Giá bán phải lớn hơn hoặc bằng giá nhập!");
                this.errorProvider.SetError(this.txtImportPrice, "Giá bán phải lớn hơn hoặc bằng giá nhập!");
            };

            this.resetTxtQuantity();

            if (this.picProduct.Image == this.imagePlaceHolder)
            {
                valid = false;
                this.errorProvider.SetError(this.picProduct, "Xin hãy chọn một tấm ảnh!");
            }

            if (valid)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm này vào database?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    ProductDTO newProduct = new ProductDTO(null,
                                                      this.txtProductName.Text.Trim(),
                                                      this.convertImageToBinaryString(picProduct.Image),
                                                      this.cBProductUnit.Texts,
                                                      int.Parse(this.txtQuantity.Text),
                                                      importPrice,
                                                      priceToSell,
                                                      this.productBUS.getCategoryId(this.cBCategory.Texts),
                                                      this.getStatus());
                    MessageBox.Show(productBUS.insertProduct(newProduct), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetProductInfoUi();
                    this.loadDataGridView();
                    this.removeSelectionCurrentRow();
                }
            }
        }

        //Event for btnEditProduct
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            this.errorProvider.Clear();
            bool valid = true;
            double importPrice = 0, priceToSell = 0;
            if (this.txtProductName.Text == "")
            {
                valid = false;
                this.errorProvider.SetError(this.txtProductName, "Trường này không được để trống!");
            }
            if (this.txtImportPrice.Text == "")
            {
                valid = false;
                this.errorProvider.SetError(this.txtImportPrice, "Trường này không được để trống!");
            }
            else if (Double.TryParse(this.txtImportPrice.Text.Trim(), out importPrice) == false)
            {
                valid = false;
                this.errorProvider.SetError(this.txtImportPrice, "Giá tiền nhập vào không hợp lệ!");
            }
            else { };

            if (this.txtPriceToSell.Text == "")
            {
                valid = false;
                this.errorProvider.SetError(this.txtPriceToSell, "Trường này không được để trống!");
            }
            else if (Double.TryParse(this.txtPriceToSell.Text.Trim(), out priceToSell) == false)
            {
                valid = false;
                this.errorProvider.SetError(this.txtPriceToSell, "Giá tiền nhập vào không hợp lệ!");
            }
            else if (Double.Parse(this.txtPriceToSell.Text.Trim()) < Double.Parse(this.txtImportPrice.Text.Trim()))
            {
                valid = false;
                this.errorProvider.SetError(this.txtPriceToSell, "Giá bán phải lớn hơn hoặc bằng giá nhập!");
                this.errorProvider.SetError(this.txtImportPrice, "Giá bán phải lớn hơn hoặc bằng giá nhập!");
            };

            this.resetTxtQuantity();

            if (valid)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa sản phẩm này trong database?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    ProductDTO product = new ProductDTO(this.txtProductId.Text,
                                                      this.txtProductName.Text.Trim(),
                                                      this.convertImageToBinaryString(picProduct.Image),
                                                      this.cBProductUnit.Texts,
                                                      int.Parse(this.txtQuantity.Text),
                                                      importPrice,
                                                      priceToSell,
                                                      this.productBUS.getCategoryId(this.cBCategory.Texts),
                                                      this.getStatus());
                    MessageBox.Show(productBUS.updateProduct(product), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetProductInfoUi();
                    this.loadDataGridView();
                    this.removeSelectionCurrentRow();
                }
            }
        }

        //Event for btnAddQuantity
        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            this.resetTxtQuantity();
            int newNumber = int.Parse(this.txtQuantity.Text) + 1;
            this.txtQuantity.Text = newNumber.ToString();
        }

        //Event for btnSubQuantity
        private void btnSubQuantity_Click(object sender, EventArgs e)
        {
            this.resetTxtQuantity();
            int nowNumber = int.Parse(this.txtQuantity.Text);
            if (nowNumber != 0)
            {
                int newNumber = nowNumber - 1;
                this.txtQuantity.Text = newNumber.ToString();
            }
        }

        //Event for importPriceInput
        private void txtImportPrice__TextChanged(object sender, EventArgs e)
        {
            this.compareImportPriceWithPriceToSell();
        }

        //Event for PriceToSellInput
        private void txtPriceToSell__TextChanged(object sender, EventArgs e)
        {
            this.compareImportPriceWithPriceToSell();

        }

        //Hàm so sánh giá nhập vào (1) và giá bán ra (2), nếu (1) lớn hơn (2) thì hiện đỏ cảnh báo
        private void compareImportPriceWithPriceToSell()
        {
            double importPrice = 0, priceToSell = 0;
            if (Double.TryParse(this.txtImportPrice.Text, out importPrice) && Double.TryParse(this.txtPriceToSell.Text, out priceToSell))
            {
                if (importPrice > priceToSell)
                {
                    this.txtImportPrice.ForeColor = Color.Red;
                    this.txtPriceToSell.ForeColor = Color.Red;
                }
                else
                {
                    this.txtImportPrice.ForeColor = Color.Black;
                    this.txtPriceToSell.ForeColor = Color.Black;
                }
            } else
            {
                this.txtImportPrice.ForeColor = Color.Black;
                this.txtPriceToSell.ForeColor = Color.Black;
            }
        }

        //Event when txtQuantity TextChanged
        private void txtQuantity__TextChanged(object sender, EventArgs e)
        {
            int quantity;
            string text = txtQuantity.Text;
            if (int.TryParse(text, out quantity) == false && text != "")
            {
                this.txtQuantity.Text = "0";
            }
        }

        //Event for btnSearch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.resetProductInfoUi();
            this.loadProductSearchListToDataGridView();
            this.removeSelectionCurrentRow();
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        //Hàm load datagridView search
        public void loadProductSearchListToDataGridView()
        {
            this.errorProvider.Clear();
            string categodyId = "";
            string unit = "";
            string name = "";
            double priceFrom = -1;
            double priceTo = -1;
            bool valid = true;
            //Check category
            if (this.cBCategorySearch.Texts != "Nhóm Hàng" && this.cBCategorySearch.Texts != "Tất cả")
            {
                categodyId = this.productBUS.getCategoryId(this.cBCategorySearch.Texts);
            }
            //Check unit
            if (this.cbUnitSearch.Texts != "Đơn Vị" && this.cbUnitSearch.Texts != "Tất cả")
            {
                unit = this.cbUnitSearch.Texts;
            }
            //Name
            name = this.txtProductNameSearch.Text.Trim();
            //Check importPrice
            if(this.txtPriceFromSearch.Text.Trim() != "")
            {
                if (Double.TryParse(this.txtPriceFromSearch.Text.Trim(), out priceFrom) == false)
                {
                    valid = false;
                    this.errorProvider.SetError(this.txtPriceFromSearch, "Giá nhập vào không hợp lệ!");
                }
                else if (this.txtPriceToSearch.Text == "")
                {
                    valid = false;
                    this.errorProvider.SetError(this.txtPriceToSearch, "Nếu đã nhập \"Giá Từ\" thì trường này không được trống!");
                }
                else if (Double.TryParse(this.txtPriceToSearch.Text.Trim(), out priceTo) == false)
                {
                    valid = false;
                    this.errorProvider.SetError(this.txtPriceToSearch, "Giá nhập vào không hợp lệ");
                }
                else { };
            }
            //Check priceToSell
            if(this.txtPriceToSearch.Text.Trim() != "")
            {
                if (Double.TryParse(this.txtPriceToSearch.Text, out priceTo) == false)
                {
                    valid = false;
                    this.errorProvider.SetError(this.txtPriceToSearch, "Giá nhập vào không hợp lệ");
                }
                else if (this.txtPriceFromSearch.Text == "")
                {
                    valid = false;
                    this.errorProvider.SetError(this.txtPriceFromSearch, "Nếu đã nhập \"Giá Đến\" thì trường này không được trống!");
                }
                else if (Double.TryParse(this.txtPriceFromSearch.Text, out priceFrom) == false)
                {
                    valid = false;
                    this.errorProvider.SetError(this.txtPriceFromSearch, "Giá nhập vào không hợp lệ");
                }
                else if (priceFrom > priceTo)
                {
                    valid = false;
                    MessageBox.Show("\"Giá Từ\" không được lớn hơn \"Giá Đến\"!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { };
            }
            //Nếu không có bất kì vấn đề nào thì thực hiện tìm kiếm sản phẩm
            if (valid)
            {
                DataTable tableProductSearch = this.productBUS.getProductSearchList(categodyId, unit, name, priceFrom, priceTo);
                this.dataGridViewProduct.DataSource = this.productBUS.formatDataTableToShowUi(tableProductSearch);
                if (dataGridViewProduct.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào theo yêu cầu của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Other function
        //Hàm design some column in datagridview
        public void designSomeColumsOfDataGridView()
        {
            //display vnd money to some column of datagridview
            this.dataGridViewProduct.Columns["productImportPrice"].DefaultCellStyle.Format = "c2";
            this.dataGridViewProduct.Columns["productImportPrice"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
            this.dataGridViewProduct.Columns["productPriceToSell"].DefaultCellStyle.Format = "c2";
            this.dataGridViewProduct.Columns["productPriceToSell"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
        }

        //Hàm lấy danh sách sản phẩm từ lớp BUS và load vào dataGridView
        public void loadDataGridView()
        {
            this.dataGridViewProduct.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridViewProduct.DataSource = this.productBUS.formatDataTableToShowUi(this.ProductBUS.ProductListFull);
            this.dataGridViewProduct.Cursor = System.Windows.Forms.Cursors.Default;
        }

        //Hàm thiết lập giá trị của các comboBox khi loadForm
        public void setValueOfComboBoxs()
        {
            this.cBCategorySearch.Items.Add("Tất cả");
            this.cbUnitSearch.Items.Add("Tất cả");
            foreach (DataRow dr in productBUS.CategoryList.Rows)
            {
                this.cBCategory.Items.Add(dr[1].ToString());
                this.cBCategorySearch.Items.Add(dr[1].ToString());
            }
            foreach (DataRow dr in productBUS.ProductUnitList.Rows)
            {
                this.cBProductUnit.Items.Add(dr[0].ToString());
                this.cbUnitSearch.Items.Add(dr[0].ToString());
            }
        }

        private void setDefaultForSomeComponents()
        {
            //set text = "0" for txtQuantity
            this.txtQuantity.Text = "0";
            //Load newProductId
            this.txtProductId.Text = productBUS.getNewProductId();
            //Check radionbutton Bán
            this.rbtnTrue.Checked = true;
            //Lần đầu khi form được load thì ẩn button edit
            this.btnEditProduct.Enabled = false;
            this.btnEditProduct.BackColor = Color.LightGray;
        }

        //Khi thực hiện một event nào đó, như nhấn nút addProduct, editProduct, addQuantity, subQuantity
        //Nếu txtQuantity == "" thì reset lại là 0
        private void resetTxtQuantity()
        {
            if (this.txtQuantity.Text == "")
            {
                this.txtQuantity.Text = "0";
            }
        }

        //Function support
        //Function convert từ binary string to image to display ui
        private Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            Image img = Image.FromStream(ms);
            return img;
        }

        //Remove selected cell of datagridview when load form
        private void removeSelectionCurrentRow()
        {
            if(this.dataGridViewProduct.Rows.Count != 0)
            {
                this.dataGridViewProduct.CurrentRow.Selected = false;
            }
        }

        //Fucntion convert image to binary string to save database
        private byte[] convertImageToBinaryString(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
            //Or we can input a path, and in function, Image will be created by that path and everything take place normal
            //Or
            /*return File.ReadAllBytes(path);*/
        }

        //Hàm lấy trạng thái true/false từ hai radiobutton Status
        private bool getStatus()
        {
            if (this.rbtnTrue.Checked)
            {
                return true;
            }
            return false;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
