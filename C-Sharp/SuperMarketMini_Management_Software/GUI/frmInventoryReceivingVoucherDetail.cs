using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmInventoryReceivingVoucherDetail : Form
    {
        InventoryReceivingVoucherDetailBUS irvdBUS = new InventoryReceivingVoucherDetailBUS();
        InventoryReceivingVoucherBUS irvBUS = new InventoryReceivingVoucherBUS();
        private AccountBUS accountBUS = new AccountBUS();
        StaffBUS staffBUS = new StaffBUS();

        DataTable product =  new ProductBUS().ProductListFull;

        public frmInventoryReceivingVoucherDetail()
        {
            InitializeComponent();
            defaultValueOfSomeComponent();
        }

        public frmInventoryReceivingVoucherDetail(InventoryReceivingVoucherDTO irv, StaffDTO staff)
        {
            InitializeComponent();
            defaultValueOfSomeComponent();
            loadDetail(irv);
            lblUser.Text = staff.StaffID + " - " + staff.StaffName;
        }

        private void frmInventoryReceivingVoucherDetail_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void defaultValueOfSomeComponent()
        {
            btnPay.Visible = false;
            loadTextBoxAutoCompleteCustomSource();
            txtStaff.Text = lblUser.Text;
            comboBoxSupplier.SelectedIndex = -1;
            designAndFillLabel();
        }

        //load chi tiet phieu nhap
        private void loadDetail(InventoryReceivingVoucherDTO irv)
        {
            flowLayoutPanelProduct.Controls.Clear();
            btnPay.Visible = false;
            if ((irv.Total - irv.Paid) > 0)
            {
                btnPay.Visible = true;
            }

            //load danh sách sản phẩm
            DataTable dataTable = irvdBUS.getAllInventoryReceivingVoucherDetailById(irv.Id);
            foreach (DataRow dr in dataTable.Rows)
            {
                panelIRVDProduct newPanel = new panelIRVDProduct(dr[2].ToString(), dr[3].ToString(), int.Parse(dr[1].ToString()), double.Parse(dr[4].ToString()));
                flowLayoutPanelProduct.Controls.Add(newPanel);
                newPanel.btnRemove.Click += delegate
                {
                    this.flowLayoutPanelProduct.Controls.Remove(newPanel);
                    designAndFillLabel();
                };
                newPanel.txtQuantity.TextChanged += delegate
                {
                    designAndFillLabel();
                };
            }

            //load thông tin phiếu nhập
            txtIRVId.Text = irv.Id;
            dateTimePickerDate.Value = irv.Date;
            lblPaidShow.Text = irv.Paid.ToString();

            foreach (string s in txtStaff.AutoCompleteCustomSource)
            {
                if (s.Contains(irv.StafId))
                {
                    txtStaff.Text = s;
                }
            }

            for (int i = 0; i < comboBoxSupplier.Items.Count; i++)
            {
                if (comboBoxSupplier.Items[i].ToString().Contains(irv.SupplierId))
                {
                    comboBoxSupplier.SelectedIndex = i;
                }
            }

            designAndFillLabel();
        }

        public void loadPanelHintProduct(string s)
        {
            flowLayoutPanelHintProduct.Controls.Clear();
            if (s.Equals(""))
            {
                foreach (DataRow row in product.Rows)
                {
                    panelHintProduct newPanel = new panelHintProduct(row["ProductId"].ToString(), row["ProductName"].ToString(), (byte[])row["ProductImg"], double.Parse(row["ImportPrice"].ToString()), row["Quantity"].ToString());
                    flowLayoutPanelHintProduct.Controls.Add(newPanel);
                    //su kien khi click vao 1 panel trong layout hint product
                    newPanel.panelCore.Click += delegate {
                        panelHintProduct_Click(newPanel);
                    };
                    newPanel.pictureBoxProductImg.Click += delegate
                    {
                        panelHintProduct_Click(newPanel);
                    };
                    newPanel.lblPrice.Click += delegate
                    {
                        panelHintProduct_Click(newPanel);
                    };
                    newPanel.lblProductId.Click += delegate
                    {
                        panelHintProduct_Click(newPanel);
                    };
                    newPanel.lblProductName.Click += delegate
                    {
                        panelHintProduct_Click(newPanel);
                    };
                    newPanel.lblQuantity.Click += delegate
                    {
                        panelHintProduct_Click(newPanel);
                    };
                }
            }
            else
            {
                foreach (DataRow row in product.Rows)
                {
                    if (row["ProductId"].ToString().ToLower().Contains(s.ToLower()) || row["ProductName"].ToString().ToLower().Contains(s.ToLower()))
                    {
                        panelHintProduct newPanel = new panelHintProduct(row["ProductId"].ToString(), row["ProductName"].ToString(), (byte[])row["ProductImg"], double.Parse(row["ImportPrice"].ToString()), row["Quantity"].ToString());
                        flowLayoutPanelHintProduct.Controls.Add(newPanel);
                        newPanel.panelCore.Click += delegate {
                            panelHintProduct_Click(newPanel);

                        };
                        newPanel.pictureBoxProductImg.Click += delegate
                        {
                            panelHintProduct_Click(newPanel);
                        };
                        newPanel.lblPrice.Click += delegate
                        {
                            panelHintProduct_Click(newPanel);
                        };
                        newPanel.lblProductId.Click += delegate
                        {
                            panelHintProduct_Click(newPanel);
                        };
                        newPanel.lblProductName.Click += delegate
                        {
                            panelHintProduct_Click(newPanel);
                        };
                        newPanel.lblQuantity.Click += delegate
                        {
                            panelHintProduct_Click(newPanel);
                        };
                    }
                }
            }
            if (flowLayoutPanelHintProduct.Controls.Count > 1)
            {
                flowLayoutPanelHintProduct.Size = new Size(420, 194);
            }
            if (flowLayoutPanelHintProduct.Controls.Count == 1)
            {
                flowLayoutPanelHintProduct.Size = new Size(420, 97);
            }
            if (flowLayoutPanelHintProduct.Controls.Count == 0) 
            {
                flowLayoutPanelHintProduct.Size = new Size(420, 30);
                Label newLabel = new Label();
                newLabel.Size = new Size(400, 25);
                newLabel.Location = new Point(newLabel.Location.X, newLabel.Location.Y - 5) ;
                newLabel.Text = "Không tìm thấy sản phẩm";
                newLabel.Font = new Font("Segoe UI", 10);
                flowLayoutPanelHintProduct.Controls.Add(newLabel);
            }
        }

        public void loadLabelTotalAndOweShow()
        {
            double total = 0;
            for (int i = 0; i < flowLayoutPanelProduct.Controls.Count; i++)
            {
                panelIRVDProduct panel = (panelIRVDProduct)flowLayoutPanelProduct.Controls[i];
                foreach (DataRow row in product.Rows)
                {
                    if (panel.lblProductId.Text.Equals(row["ProductId"]))
                    {
                        total += double.Parse(row["ImportPrice"].ToString()) * int.Parse(panel.txtQuantity.Text);
                    }
                }
            }
            designAndFillLabel();
        }

        private void loadTextBoxAutoCompleteCustomSource()
        {
            AutoCompleteStringCollection supllierData = new AutoCompleteStringCollection();
            DataTable supplier = irvBUS.getAllSupplier();
            foreach (DataRow dr in supplier.Rows)
            {
                supllierData.Add(dr[0] + " - " + dr[1]);
            }
            comboBoxSupplier.DataSource = supllierData;

            AutoCompleteStringCollection staffData = new AutoCompleteStringCollection();
            DataTable staff = irvBUS.getAllStaff();
            foreach (DataRow dr in staff.Rows)
            {
                staffData.Add(dr[0] + " - " + dr[1]);
            }
            txtStaff.AutoCompleteCustomSource = staffData;
        }

        private void designAndFillLabel()
        {
            double total = 0;
            double paid = doubleFromCurrency(lblPaidShow.Text);
            for (int i = 0; i < flowLayoutPanelProduct.Controls.Count; i++)
            {
                panelIRVDProduct irvdP = (panelIRVDProduct)flowLayoutPanelProduct.Controls[i];
                total += doubleFromCurrency(irvdP.txtTotal.Text);
            }
            System.Globalization.CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("vi-VN");
            lblTotalShow.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", total);
            lblPaidShow.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", paid);
            lblOweShow.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", total - paid);
        }

        private void btnComplete_MouseEnter(object sender, EventArgs e)
        {
            btnComplete.BackColor = Color.FromArgb(3, 151, 237);
        }

        private void btnComplete_MouseLeave(object sender, EventArgs e)
        {
            btnComplete.BackColor = Color.LightSkyBlue;
        }

        private void txtSearchProduct_Enter(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "Tìm sản phẩm theo mã hoặc tên")
            {
                txtSearchProduct.Text = "";
                txtSearchProduct.ForeColor = SystemColors.WindowText;
            }
            flowLayoutPanelHintProduct.Visible = true;
        }

        private void txtSearchProduct_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSearchProduct.Text))
            {
                txtSearchProduct.Text = "Tìm sản phẩm theo mã hoặc tên";
                txtSearchProduct.ForeColor = Color.Gray;
            }
            flowLayoutPanelHintProduct.Visible = false;
        }

        private void pictureBoxHome_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHome.Image = GUI.Properties.Resources.home_hover;
        }

        private void pictureBoxHome_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHome.Image = GUI.Properties.Resources.home;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFastPayment newForm = new frmFastPayment(irvBUS.getIRVById(txtIRVId.Text), staffBUS.getStaffById(lblUser.Text.Split('-')[0].Trim()));
            newForm.ShowDialog();
            string result = newForm.irv.Id;
            loadDetail(irvBUS.getIRVById(result));
        }

        private void pictureBoxBackWard_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBackWard.Image = GUI.Properties.Resources.backwards_hover;
        }

        private void pictureBoxBackWard_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBackWard.Image = GUI.Properties.Resources.backwards;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text != "Tìm sản phẩm theo mã hoặc tên")
            {
                loadPanelHintProduct(txtSearchProduct.Text);
            }
        }

        private void flowLayoutPanelProduct_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panelDetail_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void frmInventoryReceivingVoucherDetail_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private double doubleFromCurrency(string price)
        {
            double d;
            string productPrice = "";
            string[] numbers = Regex.Split(price, @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    productPrice += value;
                }
            }
            d = double.Parse(productPrice);
            return d;
        }

        private void panelHintProduct_Click(panelHintProduct newPanel)
        {
            bool existed = false;
            //kiem tra sp da co trong chi tiet chua
            for (int i = 0; i < flowLayoutPanelProduct.Controls.Count; i++)
            {
                panelIRVDProduct irvdP = (panelIRVDProduct)flowLayoutPanelProduct.Controls[i];
                if (irvdP.lblProductId.Text == newPanel.lblProductId.Text)
                {
                    existed = true;
                    irvdP.txtQuantity.Text = Convert.ToString(int.Parse(irvdP.txtQuantity.Text) + 1);
                    break;
                }
            }

            if (existed == false)
            {
                panelIRVDProduct newPanelIRVD = new panelIRVDProduct(newPanel.lblProductId.Text, newPanel.lblProductName.Text, 1, doubleFromCurrency(newPanel.lblPrice.Text));
                flowLayoutPanelProduct.Controls.Add(newPanelIRVD);
                newPanelIRVD.btnRemove.Click += delegate
                {
                    this.flowLayoutPanelProduct.Controls.Remove(newPanelIRVD);
                    loadLabelTotalAndOweShow();
                };
                newPanelIRVD.txtQuantity.TextChanged += delegate
                {
                    designAndFillLabel();
                };
            }
            loadLabelTotalAndOweShow();
            this.ActiveControl = null;
        }

        private bool checkStaffAndSupplier()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            bool staffCondition = false;
            bool supplierCondition = true;
            foreach (string s in txtStaff.AutoCompleteCustomSource)
            {
                if (s.Equals(txtStaff.Text))
                {
                    staffCondition = true;
                }
            }
            if (staffCondition == false)
            {
                errorProvider.SetError(txtStaff, "Nhân viên không hợp lệ");
            }

            if (comboBoxSupplier.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBoxSupplier, "Hãy chọn nhà cung cấp");
                supplierCondition = false;
            }
            return (staffCondition && supplierCondition);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

            //phieu nhap moi
            if (txtIRVId.Text == "")
            {
                if (flowLayoutPanelProduct.Controls.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm sản phẩm trước khi xác nhận", "Phiếu hàng trống");
                }
                else
                {
                    if (checkStaffAndSupplier())
                    {
                        DialogResult result = MessageBox.Show("Thêm phiếu nhập !", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            InventoryReceivingVoucherDTO irv = new InventoryReceivingVoucherDTO();
                            irv.Date = dateTimePickerDate.Value;
                            irv.StafId = txtStaff.Text.Split('-')[0].Trim();
                            irv.SupplierId = comboBoxSupplier.Text.Split('-')[0].Trim();
                            irv.Total = doubleFromCurrency(lblTotalShow.Text);

                            List<InventoryReceivingVoucherDetailDTO> lisIRVD = new List<InventoryReceivingVoucherDetailDTO>();
                            for (int i = 0; i < flowLayoutPanelProduct.Controls.Count; i++)
                            {
                                panelIRVDProduct irvdP = (panelIRVDProduct)flowLayoutPanelProduct.Controls[i];
                                InventoryReceivingVoucherDetailDTO irvd = new InventoryReceivingVoucherDetailDTO();
                                irvd.Product_ID = irvdP.lblProductId.Text;
                                irvd.Quantity = int.Parse(irvdP.txtQuantity.Text);
                                irvd.UnitPrice = double.Parse(irvdP.txtUnitPrice.Text.Split(' ')[0]);
                                lisIRVD.Add(irvd);
                            }

                            if (irvBUS.insertIRV(irv, lisIRVD))
                            {
                                MessageBox.Show("Thêm phiếu nhập thành công", "Thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Thêm phiếu nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            this.Close();
                        }
                    }
                }
            }
            //phieu nhap da ton tai thi sua phieu nhap
            else
            {
                if (flowLayoutPanelProduct.Controls.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Xác nhận xóa phiếu nhập ?", "Phiếu hàng trống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (irvBUS.deleteIRV(txtIRVId.Text) == 1)
                        {
                            MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo");
                        }
                        else if (irvBUS.deleteIRV(txtIRVId.Text) == 2)
                        {
                            MessageBox.Show("Không thể xóa phiếu nhập do xung đột số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else if ((irvBUS.deleteIRV(txtIRVId.Text) == 0))
                        {
                            MessageBox.Show("Đã có lỗi xảy ra ! Vui lòng liên hệ hỗ trợ kĩ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        this.Close();
                    }
                }
                else
                {
                    if (checkStaffAndSupplier())
                    {
                        DialogResult result = MessageBox.Show("Cập nhật lại phiếu nhập", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            InventoryReceivingVoucherDTO irv = new InventoryReceivingVoucherDTO();
                            irv.Id = txtIRVId.Text;
                            irv.Date = dateTimePickerDate.Value;
                            irv.StafId = txtStaff.Text.Split('-')[0].Trim();
                            irv.SupplierId = comboBoxSupplier.Text.Split('-')[0].Trim();
                            irv.Total = doubleFromCurrency(lblTotalShow.Text);

                            List<InventoryReceivingVoucherDetailDTO> lisIRVD = new List<InventoryReceivingVoucherDetailDTO>();
                            for (int i = 0; i < flowLayoutPanelProduct.Controls.Count; i++)
                            {
                                panelIRVDProduct irvdP = (panelIRVDProduct)flowLayoutPanelProduct.Controls[i];
                                InventoryReceivingVoucherDetailDTO irvd = new InventoryReceivingVoucherDetailDTO();
                                irvd.Product_ID = irvdP.lblProductId.Text;
                                irvd.Quantity = int.Parse(irvdP.txtQuantity.Text);
                                lisIRVD.Add(irvd);
                            }

                            if (irvBUS.updateIRV(irv, lisIRVD) == 1)
                            {
                                MessageBox.Show("Cập nhật thành công", "Thông báo");
                            }
                            else if (irvBUS.updateIRV(irv, lisIRVD) == 2)
                            {
                                MessageBox.Show("Không thể sửa phiếu nhập do xung đột số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else if ((irvBUS.updateIRV(irv, lisIRVD) == 0))
                            {
                                MessageBox.Show("Đã có lỗi xảy ra ! Vui lòng liên hệ hỗ trợ kĩ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnPay_MouseEnter(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.Lime;
        }

        private void btnPay_MouseLeave(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.SpringGreen;
        }

        private void pictureBoxBackWard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxAddProduct_Click(object sender, EventArgs e)
        {
            frmProductManagement newFrm = new frmProductManagement();
            newFrm.ShowDialog();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excelAPP;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet;
            Microsoft.Office.Interop.Excel.Range excelRange;

            int excelRow;
            string fileName;

            OpenFileDialog openFD = new OpenFileDialog();

            openFD.Filter = "Excel Office | *.xls; *.xlsx";
            openFD.ShowDialog();
            fileName = openFD.FileName;

            if (fileName != "")
            {
                excelAPP = new Microsoft.Office.Interop.Excel.Application();
                excelWorkbook = excelAPP.Workbooks.Open(fileName);
                excelWorksheet = excelWorkbook.Worksheets["Sheet1"];
                excelRange = excelWorksheet.UsedRange;

                flowLayoutPanelProduct.Controls.Clear();

                for (excelRow = 2; excelRow <= excelRange.Rows.Count; excelRow++)
                {
                    panelIRVDProduct newPanel = new panelIRVDProduct(excelRange.Cells[excelRow, 1].Text, excelRange.Cells[excelRow, 2].Text, int.Parse(excelRange.Cells[excelRow, 3].Text), double.Parse(excelRange.Cells[excelRow, 4].Text));
                    flowLayoutPanelProduct.Controls.Add(newPanel);
                    newPanel.btnRemove.Click += delegate
                    {
                        this.flowLayoutPanelProduct.Controls.Remove(newPanel);
                        designAndFillLabel();
                    };
                    newPanel.txtQuantity.TextChanged += delegate
                    {
                        designAndFillLabel();
                    };
                }

                excelWorkbook.Close();
                excelAPP.Quit();

                loadLabelTotalAndOweShow();
            }
        }
    }
}
