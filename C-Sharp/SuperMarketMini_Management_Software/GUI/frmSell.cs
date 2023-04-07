using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using AForge.Video.DirectShow;
using BUS;
using DTO;
using ZXing;

namespace GUI
{
    public partial class frmSell : Form
    {
        //Fields
        //Đối tượng productBUS
        private ProductBUS productBUS;
        //Đối tượng customerBUS
        private CustomerBUS customerBUS;
        //Đối tượng BillBUS
        private BillBUS billBUS;
        //Các biến phục vụ phân trang của flowLayout hiển thị sản phẩm
        //Số sản phẩm trên một trang, là hằng số không đổi
        private const int productsPerPage = 15;
        //Tổng số trang
        private int totalPages;
        //Trang hiện tại
        private int currentPage;
        //Mảng lưu trữ các checkBox Category Filter
        private List<CheckBox> chkCategogyList;
        //Đối tuou75ng product
        private ProductDTO productFrBarcode = null;

        string barcode_old;

        //Constructor
        public ProductBUS ProductBUS { get => productBUS; set => productBUS = value; }
        public CustomerBUS CustomerBUS { get => customerBUS; set => customerBUS = value; }
        public static int ProductsPerPage => productsPerPage;
        public int TotalPages { get => totalPages; set => totalPages = value; }
        public int CurrentPage { get => currentPage; set => currentPage = value; }
        public List<CheckBox> ChkCategogyList { get => chkCategogyList; set => chkCategogyList = value; }
        public BillBUS BillBUS { get => billBUS; set => billBUS = value; }

        //Khởi tạo biến cho camera

        FilterInfoCollection filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        VideoCaptureDevice videoCaptureDevice;


        public frmSell()
        {
            //Khởi tạo các biến và đối tượng
            ProductBUS = new ProductBUS();
            CustomerBUS = new CustomerBUS();
            BillBUS = new BillBUS();
            ChkCategogyList = new List<CheckBox>();
            InitializeComponent();
        }

        public frmSell(StaffDTO staff)
        {
            //Khởi tạo các biến và đối tượng
            ProductBUS = new ProductBUS();
            CustomerBUS = new CustomerBUS();
            BillBUS = new BillBUS();
            ChkCategogyList = new List<CheckBox>();
            InitializeComponent();
            lblStaffInfo.Text = staff.StaffID + "_" + staff.StaffName;
        }

        //Event time tick
        private void timer_Tick(object sender, EventArgs e)
        {
            this.setTimeForStatusBar();
        }

        //Set time for statusBar
        private void setTimeForStatusBar()
        {
            String dateNow = DateTime.Now.ToString("dd/MM/yyy");
            String timeNow = DateTime.Now.ToString("hh:mm:ss tt");
            lblDateTimeNowInBar.Text = dateNow + "  " + timeNow;
        }

        //Event when load form
        private void frmSell_Load(object sender, EventArgs e)
        {
            //Thiết lập ngày giờ hiện tại cho satusStrip
            this.setTimeForStatusBar();

            //Thiết lập số trang ban đầu
            this.setPageInfo(this.ProductBUS.ProductSearchListToSell);

            //Hiển thị danh sách sản phẩm có phân trang
            this.devidePages(this.ProductBUS.ProductSearchListToSell);

            //Load product filter ui
            this.loadProductFilterUi();

            //Disable for button left page
            this.btnLeftPage.Enabled = false;

            //Thiết lập một số thuộc tính của scrollBar fpnDetailShow
            this.setScrollBarOfFnShowDetailOrder();

            //Đăng kí sự kiện cho fpnProductFilter khi change visible
            this.fpnProductFilter_ChangeVisible();

            //Đăng kí sự kiện khi textChanged cho phần tiền giảm giá or total thì reset số tiền thanh toán trong pnDisplayItemOrder
            this.lblTotalResult.TextChanged += delegate
            {
                this.resetDiscountedMoney();
                this.displayBtnApplyPoint();
            };
            this.lblDiscountResult.TextChanged += delegate
            {
                this.resetDiscountedMoney();
            };

            //Fill customer List vào AutoCompleteCustomSource
            this.fillCustomerListToAutoCompleteSrcSearch();

            //Remove focus
            this.ActiveControl = this.picHome;
        }

        //Hover cho button thanh toán
        private void btnPayment_MouseEnter(object sender, EventArgs e)
        {
            this.btnPayment.BackColor = Color.FromArgb(41, 72, 224);
        }

        private void btnPayment_MouseLeave(object sender, EventArgs e)
        {
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
        }

        //Hover cho picHome
        private void picHome_MouseEnter(object sender, EventArgs e)
        {
            this.picHome.Image = global::GUI.Properties.Resources.icons8_home_page_322;
        }

        private void picHome_MouseLeave(object sender, EventArgs e)
        {
            this.picHome.Image = global::GUI.Properties.Resources.icons8_home_page_32;
        }

        //Hover cho button "Quy Đổi"
        private void btnApplyPoint_MouseEnter(object sender, EventArgs e)
        {
            this.btnApplyPoint.BackColor = Color.FromArgb(41, 72, 224);
        }

        private void btnApplyPoint_MouseLeave(object sender, EventArgs e)
        {
            this.btnApplyPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
        }

        //Hover cho button "Print"
        private void picPrintBill_MouseEnter(object sender, EventArgs e)
        {
            this.picPrintBill.BackColor = Color.LightGray;
        }

        private void picPrintBill_MouseLeave(object sender, EventArgs e)
        {
            this.picPrintBill.BackColor = Color.FromArgb(24, 136, 232);
        }

        //Convert from binary string to image to display
        private Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            Image img = Image.FromStream(ms);
            return img;
        }

        //Sự kiện cho button right page
        private void btnRightPage_Click(object sender, EventArgs e)
        {
            //Tạo ui phân trang từ các biến thành viên cơ sở đã khai báo
            this.btnRightPage.Cursor = Cursors.WaitCursor;
            this.lblPageInfo.Text = $"{++CurrentPage}/{TotalPages}";
            //Phân trang
            this.devidePages(this.ProductBUS.ProductSearchListToSell);
            this.btnRightPage.Cursor = Cursors.Hand;
        }

        //Sự kiện cho button left page
        private void btnLeftPage_Click(object sender, EventArgs e)
        {
            //Tạo ui phân trang từ các biến thành viên cơ sở đã khai báo
            this.btnLeftPage.Cursor = Cursors.WaitCursor;
            this.lblPageInfo.Text = $"{--CurrentPage}/{TotalPages}";
            //Phan trang
            this.devidePages(this.ProductBUS.ProductSearchListToSell);
            this.btnLeftPage.Cursor = Cursors.Hand;
        }

        //Tạo hàm phân trang
        private void devidePages(DataTable dtProduct)
        {
            //Tạo mảng phân trang
            int[] pages = new int[TotalPages + 1];
            pages[0] = 0;
            pages[TotalPages] = dtProduct.Rows.Count;
            for (int i = 1; i < TotalPages; i++)
            {
                pages[i] = i * ProductsPerPage;
            }
            //Load các sản phẩm thuộc trang đó lên ui
            this.fpnProductInforContainer.Visible = false;
            this.fpnProductInforContainer.Controls.Clear();
            for (int i = pages[CurrentPage - 1]; i < pages[CurrentPage]; i++)
            {
                DataRow dr = dtProduct.Rows[i];
                panelProductInfoToSell p = new panelProductInfoToSell(
                                                               dr["ProductId"].ToString(),
                                                               dr["ProductName"].ToString(),
                                                               Double.Parse(dr["PriceToSell"].ToString()),
                                                               int.Parse(dr["Quantity"].ToString()),
                                                               this.convertBinaryStringToImage((byte[])dr["ProductImg"]));
                p.MouseClick += delegate
                {
                    this.panelProductInfoToSell_EClick(p);
                };
                p.PicProduct.MouseClick += delegate
                {
                    this.panelProductInfoToSell_EClick(p);
                };
                p.LblProductName.MouseClick += delegate
                {
                    this.panelProductInfoToSell_EClick(p);
                };
                p.LblProductPrice.MouseClick += delegate
                {
                    this.panelProductInfoToSell_EClick(p);
                };
                p.LblQuantity.MouseClick += delegate
                {
                    this.panelProductInfoToSell_EClick(p);
                };
                if (int.Parse(dr["Quantity"].ToString()) < 10)
                {
                    p.LblQuantity.ForeColor = Color.Red;
                }
                this.fpnProductInforContainer.Controls.Add(p);
            }
            this.fpnProductInforContainer.Visible = true;
        }

        //Sự kiện click cho button filter
        private void btnProductFilter_Click(object sender, EventArgs e)
        {
            this.fpnProductFilter.Visible = !this.fpnProductFilter.Visible;
        }

        //Hàm tạo một checkBox Category Filter
        private CheckBox createCategoryFilterCheckBox(String text)
        {
            CheckBox chkCategoryFilter = new CheckBox();
            chkCategoryFilter.AutoSize = true;
            chkCategoryFilter.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            chkCategoryFilter.Margin = new Padding(3, 3, 25, 12);
            chkCategoryFilter.Name = "chkCategoryFilter";
            chkCategoryFilter.Size = new Size(60, 20);
            chkCategoryFilter.TabIndex = 0;
            chkCategoryFilter.Text = text;
            chkCategoryFilter.UseVisualStyleBackColor = true;
            chkCategoryFilter.Cursor = Cursors.Hand;
            return chkCategoryFilter;
        }

        //Hàm phục vụ cho sự kiện khi nhấn vào chkAll của ProductFilterUi
        private void chkAll_StateCheck(bool check)
        {
            for (int i = 0; i < ChkCategogyList.Count; i++)
            {
                CheckBox chkCategogy = ChkCategogyList[i];
                chkCategogy.Checked = check;
            }
        }

        //Hàm tạo ui product Filter
        private void loadProductFilterUi()
        {
            this.fpnProductFilter.Controls.Clear();
            CheckBox chkAll = this.createCategoryFilterCheckBox("Tất cả");
            chkAll.MouseClick += delegate
            {
                if(chkAll.Checked)
                {
                    this.chkAll_StateCheck(true);
                } else
                {
                    this.chkAll_StateCheck(false);
                }
            };
            this.fpnProductFilter.Controls.Add(chkAll);
            DataTable dtCategory = this.ProductBUS.CategoryList;
            int count = 1;
            for(int i = 0; i < dtCategory.Rows.Count; i++)
            {
                DataRow dr = dtCategory.Rows[i];
                if (Boolean.Parse(dr[2].ToString()))
                {
                    CheckBox chk = this.createCategoryFilterCheckBox(dr[1].ToString());
                    chk.CheckStateChanged += delegate
                    {
                        this.event_UncheckedCategoryCheckBox(chk, chkAll);
                    };
                    this.fpnProductFilter.Controls.Add(chk);
                    ChkCategogyList.Add(chk);
                    count++;
                }
            }
            this.fpnProductFilter.Controls.Add(this.createButtonFilter());
            int height = (++count) * 43;
            this.fpnProductFilter.Size = new Size(193, height);
        }

        //Khi unchecked một CategoryFilterCheckBox
        //Nếu chkAll là checked thì unchecked
        private void event_UncheckedCategoryCheckBox(CheckBox chk, CheckBox chkAll)
        {
            if(!chk.Checked && chkAll.Checked)
            {
                chkAll.Checked = false;
            }
        }

        //Tạo một button áp dụng bộ lọc
        private Button createButtonFilter()
        {
            Button btnFilter = new Button();
            btnFilter.BackColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnFilter.ForeColor = Color.White;
            btnFilter.Margin = new Padding(17, 3, 3, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(120, 31);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "Áp dụng bộ lọc";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.MouseEnter += delegate
            {
                btnFilter.BackColor = Color.FromArgb(41, 72, 224);
            };
            btnFilter.MouseLeave += delegate
            {
                btnFilter.BackColor = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(136)))), ((int)(((byte)(232)))));
            };
            btnFilter.Click += delegate
            {
                this.fpnProductFilter.Cursor = Cursors.WaitCursor;
                this.ProductBUS.resetProductSearchListToSell(this.getCategoryNameList());
                this.setPageInfo(this.ProductBUS.ProductSearchListToSell);
                this.devidePages(this.ProductBUS.ProductSearchListToSell);
                this.fpnProductFilter.Cursor = Cursors.Hand;
                this.fpnProductFilter.Visible = !this.fpnProductFilter.Visible;
            };
            return btnFilter;
        }

        //Hàm lấy danh sách tên nhóm hàng của các checkBox Category Checked
        private List<string> getCategoryNameList()
        {
            List<string> categoryNameList = new List<string>();
            for(int i = 0; i < ChkCategogyList.Count; i++)
            {
                CheckBox chk = ChkCategogyList[i];
                if(chk.Checked)
                {
                    categoryNameList.Add(chk.Text);
                }
            }
            return categoryNameList;
        }

        //Đăng kí sự kiện textchange for lblPageInfo
        private void lblPageInfo_TextChanged(object sender, EventArgs e)
        {
            int current = int.Parse(this.lblPageInfo.Text.Split('/')[0]);
            if(current == 1)
            {
                this.btnLeftPage.Enabled = false;
            } else
            {
                this.btnLeftPage.Enabled = true;
            }
            if (current == TotalPages)
            {
                this.btnRightPage.Enabled = false;
            }
            else
            {
                this.btnRightPage.Enabled = true;
            }
        }

        //Đăng kí sự kiện textchange for txtProductSearch
        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if(this.txtProductSearch.Text != "Tên Sản Phẩm (Từ Khóa)" && this.txtProductSearch.Text != "")
            {
                DataTable dt = this.ProductBUS.getProductSearchListToSell(this.txtProductSearch.Text.Trim());
                this.setPageInfo(dt);
                this.devidePages(dt);
            } else
            {
                this.setPageInfo(this.ProductBUS.ProductSearchListToSell);
                this.devidePages(this.ProductBUS.ProductSearchListToSell);
            }
        }

        //Hàm set lại một số biến cơ sở để phân trang khi truyền vào một datatable
        private void setPageInfo(DataTable dt)
        {
            this.CurrentPage = 1;
            if(dt.Rows.Count == 0)
            {
                this.TotalPages = 1;
            } else
            {
                this.TotalPages = (int)Math.Ceiling((double)dt.Rows.Count / ProductsPerPage);
            }
            this.lblPageInfo.Text = $"{CurrentPage}/{TotalPages}";
        }

        //Code for Order part
        //Hàm thiết lập một số thông số cho scrollbar của panel chứa chi tiết hóa đơn
        private void setScrollBarOfFnShowDetailOrder()
        {
            this.fpnShowDetailOrder.HorizontalScroll.Enabled = false;
            this.fpnShowDetailOrder.HorizontalScroll.Visible = false;
            this.fpnShowDetailOrder.HorizontalScroll.Maximum = 0;
            this.fpnShowDetailOrder.VerticalScroll.Enabled = true;
            this.fpnShowDetailOrder.AutoScroll = true;
        }

        //Hàm xử lý sự kiện cho panelProductInfoToSell
        private void panelProductInfoToSell_EClick(panelProductInfoToSell panel)
        {
            //Nếu sản phẩm có số lượng tồn khác 0 thì mới hiển thị chi tiết trong fpnShowDetailInfo
            //Ngược lại thì hiển thị MessageBox thông báo sản phẩm không thể kinh doanh
            if(panel.LblQuantity.Text != "sl: 0")
            {
                //*: Panel nào thêm sau thì hiển thị trước thể hiện tính tiện dụng khi nhân viên thao tác
                //Kiểm tra productId của panel được click đã tồn tại trong fpnShowDetailOrder chưa
                for (int i = 0; i < this.fpnShowDetailOrder.Controls.Count; i++)
                {
                    panelDetailInfo currentPanel = (panelDetailInfo)this.fpnShowDetailOrder.Controls[i];
                    //Nếu có thì chỉ cần duyệt list tìm panelDetail có productId trùng và tăng số lượng lên 1 + set lại stt và vị trí của các panel
                    if (currentPanel.LblDetailProductId.Text == panel.Name)
                    {
                        //Nếu detailPanel đang ở trên top thì không cần đẩy nó lên top, ngược lại thì đẩy nó lên top và set lại ordinalNumber của các detail
                        if (i != 0)
                        {
                            panelDetailInfo topPanel = (panelDetailInfo)this.fpnShowDetailOrder.Controls[0];
                            this.fpnShowDetailOrder.Controls.SetChildIndex(currentPanel, 0);
                            this.resetOrdinalNumber();
                        }
                        //Tạo hai biến lưu trữ số lượng của detailQuantity và số lượng sản phẩm tồn kho
                        int detailQuantity = int.Parse(currentPanel.TxtDetailQuantity.Text);
                        int productQuantity = int.Parse(panel.LblQuantity.Text.Split(' ')[1]);
                        //Nếu bằng nhau thì show thông báo và không thực hiện gì cả
                        if (detailQuantity == productQuantity)
                        {
                            MessageBox.Show($"Bạn chỉ được chọn bán tối đa {productQuantity} sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else //Ngược lại thì tăng quantity của detailPanel tìm thấy lên một
                        {
                            currentPanel.TxtDetailQuantity.Text = (int.Parse(currentPanel.TxtDetailQuantity.Text) + 1).ToString();                       
                        }
                        //Sau khi thao tác thì cuộn scrollBar về top
                        this.setFlowLayoutAtTop();
                        //Sau khi thêm vào panel thì remove all focus của form để scrollBar không bị dừng lại khi kéo
                        this.ActiveControl = null;
                        //Nếu đã tìm thấy, xử lý xong thì return hàm
                        return;
                    }
                }
                //Nếu không thì tạo panelDetailInfo and add to above fpnShowDetailOrder
                panelDetailInfo newPanel = new panelDetailInfo(this.fpnShowDetailOrder.Controls.Count + 1,
                                                                    panel.Name,
                                                                    panel.LblProductName.Text,
                                                                    1,
                                                                    Double.Parse(panel.LblProductPrice.Text.Split(' ')[0].Replace(".", "")),
                                                                    int.Parse(panel.LblQuantity.Text.Split(' ')[1]), this);
                //Đăng ký sự kiện khi nhấn vào picTureBox trash icon
                newPanel.PicTrash.Click += delegate
                {
                    this.fpnShowDetailOrder.Controls.Remove(newPanel);
                    //Hàm reset lại ordinalNumber của các detailPanel trong flowLayoutPanel khi xóa một de
                    this.resetOrdinalNumber();
                    //Sau khi xóa một ui detail thì setup lại total của pnDisplayItemOrder
                    this.resetTotalOrderInfo(newPanel, "del");
                    //Reset lại lblPoint và lblDiscount nếu đã chọn customer
                    this.resetPointAndDiscount();
                };
                //Đăng kí sự kiện khi thay đổi detailUnitPrice thì Total của order cũng thay đổi theo
                newPanel.LblDetailUnitPrice.TextChanged += delegate
                {
                    this.resetTotalOrderInfo(newPanel, "update");
                    this.resetPointAndDiscount();
                };
                //Add panelDetailInfo vào flowLayout
                this.fpnShowDetailOrder.Controls.Add(newPanel);
                this.fpnShowDetailOrder.Controls.SetChildIndex(newPanel, 0);
                //Sau khi thêm thì cuộn scrollBar về top
                this.setFlowLayoutAtTop();
                //Sau khi thêm vào panel thì remove all focus của form để scrollBar không bị dừng lại khi kéo
                this.ActiveControl = null;
                //Sau đó set lại total của hóa đơn pnDisplayItemOrder
                this.resetTotalOrderInfo(newPanel, "add");
                //Reset lại lblPoint và lblDiscount nếu đã chọn customer
                this.resetPointAndDiscount();
            }
            else
            {
                MessageBox.Show("Không thể bán sản phẩm có số lượng tồn = 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //Sự kiện khi txtProductSearch được focus
        private void txtProductSearch_Enter(object sender, EventArgs e)
        {
            this.txtProductSearch.Text = "";
            this.txtProductSearch.ForeColor = Color.Black;
        }

        private void txtProductSearch_Leave(object sender, EventArgs e)
        {
            if (this.txtProductSearch.Text == "")
            {
                this.txtProductSearch.ForeColor = Color.Gray;
                this.txtProductSearch.Text = "Tên Sản Phẩm (Từ Khóa)";
            }
        }

        //Sự kiện khi txtCustomerSearch được focus
        private void txtCustomerSearch_Enter(object sender, EventArgs e)
        {
            this.txtCustomerSearch.Text = "";
            this.txtCustomerSearch.ForeColor = Color.Black;
        }

        private void txtCustomerSearch_Leave(object sender, EventArgs e)
        {
            if(this.txtCustomerSearch.Text == "")
            {
                this.txtCustomerSearch.Text = "Số Điện Thoại Khách Hàng";
                this.txtCustomerSearch.ForeColor = Color.Gray;
            }
        }

        //Đăng kí sự kiện khi fpnProductFilter thay đổi trạng thái Visible
        private void fpnProductFilter_ChangeVisible()
        {
            this.fpnProductFilter.VisibleChanged += delegate
            {
                if (this.fpnProductFilter.Visible)
                {
                    this.btnProductFilter.BackColor = Color.LightGray;
                }
                else
                {
                    this.btnProductFilter.BackColor = Color.White;
                }
            };
        }

        //Hàm reset lại ordinalNumber của các detailPanel trong flowLayoutPanel khi xóa một detailPanel
        private void resetOrdinalNumber()
        {
            int ordinalNum = 1;
            for(int i = this.fpnShowDetailOrder.Controls.Count - 1; i >= 0; i--)
            {
                panelDetailInfo currentPanel = (panelDetailInfo)this.fpnShowDetailOrder.Controls[i];
                currentPanel.LblOrdinalNumber.Text = (ordinalNum++).ToString();
            }
        }

        //Hàm set flowLayout at top when scroll
        private void setFlowLayoutAtTop()
        {
            this.fpnShowDetailOrder.AutoScrollPosition = new Point(0, 0);
        }

        //Hàm setup total của hóa đơn pnDisplayItemOrder
        private void resetTotalOrderInfo(panelDetailInfo _currentDetail, string action)
        {
            double newMoney = 0;
            double currentTotal = double.Parse(this.lblTotalResult.Text.Split(' ')[0]);
            double moneyDetailOrder = double.Parse(_currentDetail.LblDetailUnitPrice.Text);
            switch (action)
            {
                case "add":
                    newMoney = currentTotal + moneyDetailOrder;
                    break;
                case "del":
                    newMoney = currentTotal - moneyDetailOrder;
                    break;
                case "update":
                    newMoney = currentTotal - _currentDetail.UndoDetailUnitPrice + moneyDetailOrder;
                    _currentDetail.UndoDetailUnitPrice = moneyDetailOrder;
                    break;
            }
            if (newMoney == 0)
            {
                this.lblTotalResult.Text = "0 đ";
            }
            else
            {
                this.lblTotalResult.Text = String.Format("{0:0,0 đ}", newMoney);
            }
        }

        //Hàm set up lại số tiền cần thanh toán của pnDisplayItemOrder khi TextChanged total hoặc discount
        private void resetDiscountedMoney()
        {
            double totalOrder = double.Parse(this.lblTotalResult.Text.Split(' ')[0]);
            double discount = double.Parse(this.lblDiscountResult.Text.Split(' ')[0]);
            double discountedMoney = totalOrder - discount;
            if(discountedMoney == 0)
            {
                this.lblDiscountedTotalResult.Text = "0 đ";
            }
            else
            {
                this.lblDiscountedTotalResult.Text = String.Format("{0:0,0 đ}", discountedMoney);
            }
        }

        //Hàm fill customer List vào autoCompleteModeSource
        private void fillCustomerListToAutoCompleteSrcSearch()
        {
            var src = new AutoCompleteStringCollection();
            for(int i = 0; i < this.CustomerBUS.CustomerList.Rows.Count; i++)
            {
                DataRow dr = this.CustomerBUS.CustomerList.Rows[i];
                if (Boolean.Parse(dr["StatusItem"].ToString()))
                {
                    string customerInfo = $"{dr["NumberPhone"]}_{dr["CustomerName"]}_Point: {dr["Point"]}_{dr["CustomerId"]}";
                    src.Add(customerInfo);
                }
            }
            this.txtCustomerSearch.AutoCompleteCustomSource = src;
        }

        //Đăng kí sự kiện TextChanged cho txtCustomerSearch
        //Nếu chữ trên textBox bằng với bất kì dòng nào trong autoCompleteSrc thì disable textBox, set lại màu nền + ẩn button addCustomer + hiện button del
        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            string currentText = this.txtCustomerSearch.Text;
            for(int i = 0; i < this.txtCustomerSearch.AutoCompleteCustomSource.Count; i++)
            {
                string currentItem = this.txtCustomerSearch.AutoCompleteCustomSource[i];
                if(currentItem == currentText)
                {
                    this.txtCustomerSearch.Enabled = false;
                    this.pnCustomerSearch.BackColor = Color.FromArgb(239, 242, 245);
                    this.picAddCustomer.Visible = false;
                    this.picDelCustomerSearch.Visible = true;
                    break;
                }
            }
        }

        //Đăng kí sự kiện click cho btnDelCustomerSearch
        //Khi click vào thì xóa text trên txtCustomerSearch, set lại màu nền, đồng thời enable txt + ẩn btn del + hiện btn Add
        private void picDelCustomerSearch_Click(object sender, EventArgs e)
        {
            this.txtCustomerSearch.Text = "";
            this.txtCustomerSearch.Enabled = true;
            this.txtCustomerSearch.Focus();
            this.pnCustomerSearch.BackColor = Color.White;
            this.picAddCustomer.Visible = true;
            this.picDelCustomerSearch.Visible = false;
        }

        //Hàm set event EnableChanged cho txtCustomerSearch
        //Tùy vào enable or disable mà set customer info in pnDisplayItemOrder phù hợp
        private void txtCustomerSearch_EnabledChanged(object sender, EventArgs e)
        {
            if(this.txtCustomerSearch.Enabled)
            {
                this.lblCustomerNameResult.Text = "";
                this.lblNumberPhoneResult.Text = "";
                this.lblPointResult.Text = "";
            }
            else
            {
                string _name = this.txtCustomerSearch.Text.Split('_')[1];
                string _numberPhone = this.txtCustomerSearch.Text.Split('_')[0];
                string _point = this.txtCustomerSearch.Text.Split('_')[2].Split(' ')[1];
                this.lblCustomerNameResult.Text = _name;
                this.lblNumberPhoneResult.Text = _numberPhone;
                this.lblPointResult.Text = _point;
            }
        }

        //Đăng kí sự kiện khi lblPointResult thay đổi giá trị
        //Nếu số điểm == "", 0, hoặc totalOrder = 0 thì ẩn btnQuyDoi
        //Ngược lại thì hiện btnQuyDoi
        private void lblPointResult_TextChanged(object sender, EventArgs e)
        {
            this.displayBtnApplyPoint();
        }

        //Hàm ẩn hiện button Quy Đổi
        private void displayBtnApplyPoint()
        {
            if (this.lblPointResult.Text == "" || this.lblPointResult.Text == "0" || this.lblTotalResult.Text == "0 đ")
            {
                this.lblDiscountResult.Text = "0 đ";
                this.btnApplyPoint.Visible = false;
            }
            else
            {
                this.btnApplyPoint.Enabled = true;
                this.btnApplyPoint.Visible = true;
            }
        }

        //Event khi click vào btnQuyDoi
        //set lại lblDiscountResult và lblPointResult
        private void btnApplyPoint_Click(object sender, EventArgs e)
        {
            Button btnPoint = sender as Button;
            double totalOrder = double.Parse(this.lblTotalResult.Text.Split(' ')[0]);
            double discount = (this.lblPointResult.Text == "") ? 0 : int.Parse(this.lblPointResult.Text) * 1000;
            double discountedTotal = totalOrder - discount;
            if(discountedTotal < 0)
            {
                this.lblPointResult.Text = Math.Ceiling(Math.Abs(discountedTotal)/1000).ToString();
                this.lblDiscountResult.Text = this.lblTotalResult.Text;
                //Xong thì ẩn btnQuyDoi
                btnPoint.Enabled = false;
            }
            else if (discountedTotal > 0)
            {
                this.lblPointResult.Text = "0";
                this.lblDiscountResult.Text = discount.ToString() + " đ";
            }
            else { };
        }

        //Khi del detail, update detail, nếu đã chọn khách hàng thì trả số điểm của khách hàng hiện tại về ban đầu
        //Đồng thời set lblDiscount = "0 đ"
        private void resetPointAndDiscount()
        {
            if(this.txtCustomerSearch.Text != "" && this.txtCustomerSearch.Text != "Số Điện Thoại Khách Hàng")
            {
                this.lblPointResult.Text = this.txtCustomerSearch.Text.Split('_')[2].Split(' ')[1];
                this.lblDiscountResult.Text = "0 đ";
            }
        }

        //Sự kiện khi nhấn btnPayment
        //Tạo đối tượng Bill, list DetailBill, điểm của khách hàng nếu có, sau đó gọi hàm thêm từ lớp BUS
        private void btnPayment_Click(object sender, EventArgs e)
        {
            //Tạo Bill
            DateTime billDate = DateTime.Now;
            double total = double.Parse(this.lblTotalResult.Text.Split(' ')[0]);
            double discount = double.Parse(this.lblDiscountResult.Text.Split(' ')[0]);
            string staffId = this.lblStaffInfo.Text.Split('_')[0];
            string customerId = (this.txtCustomerSearch.Text != "" && this.txtCustomerSearch.Text != "Số Điện Thoại Khách Hàng") ? this.txtCustomerSearch.Text.Split('_')[3] : null;
            BillDTO bill = new BillDTO(null, billDate, total,  discount, staffId, customerId);

            //Tạo detailBillList
            List<BillDetailDTO> billDetailList = new List<BillDetailDTO>();
            
            for(int i = this.fpnShowDetailOrder.Controls.Count - 1; i >= 0 ; i--)
            {
                panelDetailInfo currentDetail = this.fpnShowDetailOrder.Controls[i] as panelDetailInfo;
                BillDetailDTO billDetail = new BillDetailDTO(null, currentDetail.LblDetailProductId.Text, int.Parse(currentDetail.TxtDetailQuantity.Text), double.Parse(currentDetail.LblDetailProductPrice.Text));
                billDetailList.Add(billDetail);
            }

            //Tính điểm
            //Total của hóa đơn 50.000 thì được tích 1 điểm
            //point = -1 khi tạo hóa đơn cho khách vãng lai
            int point = -1;
            //point khác -1 khi tạo hóa đơn cho khách hàng thành viên
            //Cứ 50000 thì tích 1 điểm, 1 điểm có thể quy đổi thành 1000 vnđ
            if(this.lblCustomerNameResult.Text != "")
            {
                point = int.Parse(this.lblPointResult.Text)
                        + (int)Math.Floor(double.Parse(this.lblDiscountedTotalResult.Text.Split(' ')[0])/50000);
            }

            //Gọi hàm thêm từ lớp BUS
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string resultInsert = this.BillBUS.insertBill(bill, billDetailList, point);
                MessageBox.Show(resultInsert, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(resultInsert == "Hóa đơn này đã được tạo thành công!")
                {
                    DialogResult resultPrint = MessageBox.Show("Bạn có muốn in hóa đơn vừa tạo?", "In hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultPrint == DialogResult.Yes)
                    {
                        //Vì id là được sinh tự động trong db, nên để có thể lấy được id của bill vừa tạo để in hóa đơn
                        //Chúng ta phải lấy id của Bill cuối cùng trong BillList để gán vào
                        string nearlyBillId = this.BillBUS.BillListOfHung.Rows[this.BillBUS.BillListOfHung.Rows.Count - 1]["BillId"].ToString();
                        bill.BillId = nearlyBillId;
                        for (int i = 0; i < billDetailList.Count; i++)
                        {
                            billDetailList[i].BillId = nearlyBillId;
                        }
                        //Gọi tới hàm xuất bill ra excel của lớp BUS
                        this.Cursor = Cursors.WaitCursor;
                        bool printSuccess = new ExportExcelSupportBUS().exportBillToExcel(bill, billDetailList);
                        this.Cursor = Cursors.Default;
                        if (printSuccess == false)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra trong quá trình in hóa đơn, vui lòng liên hệ bộ phận kỹ thuật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    this.resetSellUi();
                }
            }
        }

        //Hàm reset lại các ui sau khi tạo một hóa đơn thành công
        private void resetSellUi()
        {
            //Phần search khách hàng
            this.txtCustomerSearch.Text = "Số Điện Thoại Khách Hàng";
            this.txtCustomerSearch.ForeColor = Color.Gray;
            this.txtCustomerSearch.Enabled = true;
            this.pnCustomerSearch.BackColor = Color.White;
            this.picAddCustomer.Visible = true;
            this.picDelCustomerSearch.Visible = false;

            //Phần pnDisplayInfo
            //Customer
            this.lblCustomerNameResult.Text = "";
            this.lblNumberPhoneResult.Text = "";
            this.lblPointResult.Text = "";

            //Order
            this.lblTotalResult.Text = "0 đ";
            this.lblDiscountResult.Text = "0 đ";

            //Reset lại danh sách sản phẩm search
            this.productBUS.resetProductSearchList();
            this.productBUS.resetProductSearchListToSell(this.getCategoryNameList());

            if (this.txtProductSearch.Text != "Tên Sản Phẩm (Từ Khóa)" && this.txtProductSearch.Text != "")
            {
                DataTable dt = this.ProductBUS.getProductSearchListToSell(this.txtProductSearch.Text.Trim());
                this.devidePages(dt);
            }
            else
            {
                this.devidePages(this.ProductBUS.ProductSearchListToSell);
            }

            //remove items of fpnShowOrderItem
            this.fpnShowDetailOrder.Controls.Clear();

            //Reset lại customerList của autoCompleteSrc của txtCustomerSearch
            this.CustomerBUS.resetCustomerList();
            this.fillCustomerListToAutoCompleteSrcSearch();
        }

        //Đăng kí sự kiện cho fpnShowDetailOrder, khi thêm một control
        //Nếu hiện tại chưa có control nào thì enable btnPayment và xét lại backColor cho pnDisplayItem
        private void fpnShowDetailOrder_ControlAdded(object sender, ControlEventArgs e)
        {
            if(fpnShowDetailOrder.Controls.Count == 1)
            {
                //Enable btnPayment
                this.btnPayment.BackColor = Color.FromArgb(24, 136, 232);
                this.btnPayment.Enabled = true;

                //pnDisplayItem
                this.pnDisplayItemOrder.BackColor = Color.LightSkyBlue;
            }
        }

        //Đăng kí sự kiện cho fpnShowDetailOrder, khi remove một control
        //Nếu panel không còn control nào thì ẩn btnPayment
        private void fpnShowDetailOrder_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (fpnShowDetailOrder.Controls.Count == 0)
            {
                //disable btnPayment
                this.btnPayment.Enabled = false;
                this.btnPayment.BackColor = Color.LightGray;

                //pnDisplayItem
                this.pnDisplayItemOrder.BackColor = Color.LightGray;
            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picPrintBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBill frmBill = new frmBill();
            frmBill.ShowDialog();
            this.Show();

            this.resetSellUi();
        }

        private void picAddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
            this.Show();

            this.CustomerBUS.resetCustomerList();
            this.fillCustomerListToAutoCompleteSrcSearch();
        }
        private byte[] convertImageToBinaryString(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
            //Or we can input a path, and in function, Image will be created by that path and everything take place normal
            //Or
            /*return File.ReadAllBytes(path);*/
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();

            reader.Options.PossibleFormats = new List<BarcodeFormat>();
            reader.Options.PossibleFormats.Add(BarcodeFormat.EAN_13);
            reader.Options.TryHarder = true;

            var result = reader.Decode(img);

            if (result != null)
            {
                if(result.ToString() != barcode_old)
                {
                    productFrBarcode = CheckBarcode(result.ToString().Trim());
                    barcode_old = result.ToString();
                }
                
            }
            Camera.Image = img;
        }

        private void btnDisplayCamera_Click(object sender, EventArgs e)
        {
            // ẩn phân trang
            pnDevidePagesContainer.Visible = !pnDevidePagesContainer.Visible;
            // ẩn thanh search sản phẩm
            pnProductSearch.Visible = !pnProductSearch.Visible;
            // ẩn bộ lọc sản phẩm
            btnProductFilter.Visible = !btnProductFilter.Visible;
            // ẩn container chọn sản phẩm
            fpnProductInforContainer.Visible = !pnChoseProductContainer.Visible;

            if(pnDevidePagesContainer.Visible == true)
                this.devidePages(this.ProductBUS.ProductSearchListToSell);

            // hiện panel camera
            PanelBarcode.Visible = !PanelBarcode.Visible;

            // Chạy camera
            if (videoCaptureDevice == null || videoCaptureDevice.IsRunning == false)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
        }

        private void frmSell_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
                if(videoCaptureDevice.IsRunning == true)
                {
                    videoCaptureDevice.Stop();
                }
        }

        private ProductDTO CheckBarcode(string barcode)
        {
            DataTable dt = this.productBUS.ProductListTrue;
            
            foreach(DataRow dr in dt.Rows)
            {
                if (dr[9].ToString().Equals(barcode.ToString().Trim()))
                {
                    ProductDTO productFromBarcode = new ProductDTO(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[6].ToString()), double.Parse( dr[4].ToString()), double.Parse(dr[5].ToString()), dr[9].ToString());
                    // Hiển thị tên sản phẩm và ID
                    lblProductNameBarcode.Invoke(new MethodInvoker(delegate ()
                    {
                        lblProductNameBarcode.Text = dr[2].ToString();
                    }));
                    
                    lblProductIdBarcode.Invoke(new MethodInvoker(delegate (){
                        lblProductIdBarcode.Text = dr[1].ToString();
                    }));

                    tbBarcodeQuantity.Invoke(new MethodInvoker(delegate () {
                        tbBarcodeQuantity.Text = "1";
                        tbBarcodeQuantity.Focus();
                        tbBarcodeQuantity.Enabled = true;
                    }));

                    btnConfirmBarcode.Invoke(new MethodInvoker(delegate () {
                        btnConfirmBarcode.Enabled = true;
                    }));

                    return productFromBarcode;
                }
            }
            return null;
        }

        private void btnConfirmBarcode_Click(object sender, EventArgs e)
        {
            
                int inputQuantity = int.Parse(tbBarcodeQuantity.Text);
                int productQuantity = productFrBarcode.Quantity;
                if (productFrBarcode.Quantity != 0)
                {
                    //*: Panel nào thêm sau thì hiển thị trước thể hiện tính tiện dụng khi nhân viên thao tác
                    //Kiểm tra productId của panel được click đã tồn tại trong fpnShowDetailOrder chưa
                    for (int i = 0; i < this.fpnShowDetailOrder.Controls.Count; i++)
                    {
                        panelDetailInfo currentPanel = (panelDetailInfo)this.fpnShowDetailOrder.Controls[i];
                        //Nếu có thì chỉ cần duyệt list tìm panelDetail có productId trùng và tăng số lượng lên 1 + set lại stt và vị trí của các panel
                        if (currentPanel.LblDetailProductId.Text == productFrBarcode.ProductId)
                        {
                            //Nếu detailPanel đang ở trên top thì không cần đẩy nó lên top, ngược lại thì đẩy nó lên top và set lại ordinalNumber của các detail
                            if (i != 0)
                            {
                                panelDetailInfo topPanel = (panelDetailInfo)this.fpnShowDetailOrder.Controls[0];
                                this.fpnShowDetailOrder.Controls.SetChildIndex(currentPanel, 0);
                                this.resetOrdinalNumber();
                            }
                            //Tạo hai biến lưu trữ số lượng của detailQuantity và số lượng sản phẩm tồn kho
                            int detailQuantity = int.Parse(currentPanel.TxtDetailQuantity.Text);
                            //int productQuantity = productFrBarcode.Quantity;
                            //Nếu bằng nhau thì show thông báo và không thực hiện gì cả
                            if (detailQuantity + inputQuantity > productQuantity)
                            {
                                MessageBox.Show($"Bạn chỉ được chọn bán tối đa {productQuantity} sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else //Ngược lại thì tăng quantity của detailPanel tìm thấy lên 
                            {
                                currentPanel.TxtDetailQuantity.Text = (int.Parse(currentPanel.TxtDetailQuantity.Text) + inputQuantity).ToString();
                            }
                            //Sau khi thao tác thì cuộn scrollBar về top
                            this.setFlowLayoutAtTop();
                            //Sau khi thêm vào panel thì remove all focus của form để scrollBar không bị dừng lại khi kéo
                            this.ActiveControl = null;

                            ClearBarcode();
                            //Nếu đã tìm thấy, xử lý xong thì return hàm

                            return;
                        }
                    }

                    //Nếu không thì tạo panelDetailInfo and add to above fpnShowDetailOrder

                    if (inputQuantity > productQuantity)
                    {
                        MessageBox.Show($"Bạn chỉ được chọn bán tối đa {productQuantity} sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //tạo panelDetailInfo and add to above fpnShowDetailOrder
                        panelDetailInfo newPanel = new panelDetailInfo(this.fpnShowDetailOrder.Controls.Count + 1,
                                                                            productFrBarcode.ProductId,
                                                                            productFrBarcode.ProductName,
                                                                            inputQuantity,
                                                                            productFrBarcode.PriceToSell,
                                                                            productQuantity, this);
                        //Đăng ký sự kiện khi nhấn vào picTureBox trash icon
                        newPanel.PicTrash.Click += delegate
                        {
                            this.fpnShowDetailOrder.Controls.Remove(newPanel);
                            //Hàm reset lại ordinalNumber của các detailPanel trong flowLayoutPanel khi xóa một de
                            this.resetOrdinalNumber();
                            //Sau khi xóa một ui detail thì setup lại total của pnDisplayItemOrder
                            this.resetTotalOrderInfo(newPanel, "del");
                            //Reset lại lblPoint và lblDiscount nếu đã chọn customer
                            this.resetPointAndDiscount();
                        };
                        //Đăng kí sự kiện khi thay đổi detailUnitPrice thì Total của order cũng thay đổi theo
                        newPanel.LblDetailUnitPrice.TextChanged += delegate
                        {
                            this.resetTotalOrderInfo(newPanel, "update");
                            this.resetPointAndDiscount();
                        };
                        //Add panelDetailInfo vào flowLayout
                        this.fpnShowDetailOrder.Controls.Add(newPanel);
                        this.fpnShowDetailOrder.Controls.SetChildIndex(newPanel, 0);
                        //Sau khi thêm thì cuộn scrollBar về top
                        this.setFlowLayoutAtTop();
                        //Sau khi thêm vào panel thì remove all focus của form để scrollBar không bị dừng lại khi kéo
                        this.ActiveControl = null;
                        //Sau đó set lại total của hóa đơn pnDisplayItemOrder
                        this.resetTotalOrderInfo(newPanel, "add");
                        //Reset lại lblPoint và lblDiscount nếu đã chọn customer
                        this.resetPointAndDiscount();

                    }
                }
                else
                {
                    MessageBox.Show("Không thể bán sản phẩm có số lượng tồn = 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearBarcode();

        }

        private void ClearBarcode()
        {
            tbBarcodeQuantity.Text = string.Empty;
            lblProductIdBarcode.Text = string.Empty;
            lblProductNameBarcode.Text = string.Empty;
            tbBarcodeQuantity.Enabled = false;
            btnConfirmBarcode.Enabled = false;
            barcode_old = null;
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }

}
