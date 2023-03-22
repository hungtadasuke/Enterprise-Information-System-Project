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

namespace GUI
{
    public partial class frmBill : Form
    {
        string billId = null;
        private BillBUS billBUS;
        private ErrorProvider errorProvider;
        public BillBUS BillBUS { get => billBUS; set => billBUS = value; }
        public ErrorProvider ErrorProvider { get => errorProvider; set => errorProvider = value; }

        public frmBill()
        {
            this.billBUS = new BillBUS();
            this.errorProvider = new ErrorProvider();
            InitializeComponent();
        }

        public frmBill(CustomerDTO customer)
        {
            this.billBUS = new BillBUS();
            this.errorProvider = new ErrorProvider();
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            this.DateFrom.Value = DateTime.Now;
            this.DateTo.Value = DateTime.Now;
            SupportUI.DoubleBuffered(this.dataGridViewBill, true);
            SupportUI.DoubleBuffered(this.dataGridViewBillDetail, true);
            this.loadDataGridView();
            this.removeSelectionCurrentRow();
            this.resetBillInfoUi();

        }
        public void loadDataGridView()
        {
            this.dataGridViewBill.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridViewBill.DataSource = this.BillBUS.getBill(this.DateFrom.Value.ToString("yyyy-MM-dd"), this.DateTo.Value.ToString("yyyy-MM-dd"));
            this.dataGridViewBill.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void removeSelectionCurrentRow()
        {
            if(this.dataGridViewBill.Rows.Count != 0)
            {
                this.dataGridViewBill.CurrentRow.Selected = false;
            }
        }
        private void removeSelectionCurrentRowBillDetail()
        {
            if (this.dataGridViewBillDetail.Rows.Count != 0)
            {
                this.dataGridViewBillDetail.CurrentRow.Selected = false;
            }
        }
        private void resetBillInfoUi()
        {
            errorProvider.Clear();
            this.txtBillID.Text = "";
            this.txtPriceFrom.Text = "";
            this.txtPriceTo.Text = "";
            this.DateFrom.Value = DateTime.Now;
            this.DateTo.Value = DateTime.Now;
            this.removeSelectionCurrentRow();
            this.dataGridViewBillDetail.DataSource = null;

            this.btnPrint.Enabled = false;
            this.btnPrint.BackColor = Color.LightGray;

            this.btnDelete.Enabled = false;
            this.btnDelete.BackColor = Color.LightGray;
        }
        public void loadBillSearchListToDataGridView()
        {
            this.errorProvider.Clear();
            bool check = true;
            string billId = "";
            double priceFrom = -1;
            double priceTo = -1;
            string dateForm = this.DateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = this.DateTo.Value.ToString("yyyy-MM-dd");
            billId = this.txtBillID.Text.Trim();
            if ((this.txtPriceFrom.Text.Trim() != "") && ((double.TryParse(this.txtPriceFrom.Text.Trim(), out priceFrom)) == false || int.Parse(this.txtPriceFrom.Text) < 0))
            {
                check = false;
                this.errorProvider.SetError(this.txtPriceFrom, "Giá tiền không hợp lệ!");
            }
            else if (this.txtPriceFrom.Text.Trim() != "")
            {
                priceFrom = double.Parse(this.txtPriceFrom.Text.Trim());
            }
            if ((this.txtPriceTo.Text.Trim() != "") && ((double.TryParse(this.txtPriceTo.Text.Trim(), out priceTo)) == false || int.Parse(this.txtPriceTo.Text) < 0))
            {
                check = false;
                this.errorProvider.SetError(this.txtPriceTo, "Giá tiền không hợp lệ!");
            }
            else if (this.txtPriceTo.Text.Trim() != "")
            {
                priceTo = double.Parse(this.txtPriceTo.Text);
            }

            if ((this.txtPriceFrom.Text.Trim() != "") && (this.txtPriceTo.Text.Trim() != "") && priceFrom > priceTo)
            {
                check = false;
                MessageBox.Show("\"Giá Từ\" không được lớn hơn \"Giá Đến\"!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(DateFrom.Value>DateTo.Value)
            {
                check = false;
                MessageBox.Show("\"Ngày Từ\" không được sau \"Ngày đến\"!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (check==true)
                {
                    DataTable tableBillSearch = this.billBUS.getBillSearchList(billId, priceFrom, priceTo, dateForm, dateTo);
                    this.dataGridViewBill.DataSource = tableBillSearch;
                    if (dataGridViewBill.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm nào theo yêu cầu của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        public void deleteListToDataGridView()
        {
            this.errorProvider.Clear();
            bool check = true;
            string billId = "";
            double priceFrom = -1;
            double priceTo = -1;
            string dateForm = this.DateFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = this.DateTo.Value.ToString("yyyy-MM-dd");
            billId = this.txtBillID.Text.Trim();
            if (this.txtPriceFrom.Text.Trim() != "")
            {
                priceFrom = double.Parse(this.txtPriceFrom.Text.Trim());
            }
            if (this.txtPriceTo.Text.Trim() != "")
            {
                priceTo = double.Parse(this.txtPriceTo.Text);
            }
            if (check == true)
            {
                DataTable tableBillSearch = this.billBUS.getBillSearchList(billId, priceFrom, priceTo, dateForm, dateTo);
                this.dataGridViewBill.DataSource = tableBillSearch;
            }
        }
        //hàm click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridViewBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                errorProvider.Clear();
                DataGridViewRow row = dataGridViewBill.Rows[e.RowIndex];
                DataTable tableCustomerSearch = this.billBUS.getBillDetail(row.Cells[0].Value.ToString());
                this.dataGridViewBillDetail.DataSource = tableCustomerSearch;
                this.billId=row.Cells[0].Value.ToString();
                this.removeSelectionCurrentRowBillDetail();
            }
            this.btnPrint.Enabled = true;
            this.btnPrint.BackColor = Color.LightSkyBlue;

            this.btnDelete.Enabled = true;
            this.btnDelete.BackColor = Color.LightSkyBlue;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.resetBillInfoUi();
            this.loadDataGridView();
            this.removeSelectionCurrentRow();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridViewBillDetail.DataSource=null;
            this.loadBillSearchListToDataGridView();
            this.removeSelectionCurrentRow();
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn và chi tiết hóa đơn này trong database?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                MessageBox.Show(billBUS.deleteBill(billId), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridViewBillDetail.DataSource = null;
                this.deleteListToDataGridView();
                this.removeSelectionCurrentRow();
            }
        }
        //hàm đổi màu
        private void txtBillID__TextChanged(object sender, EventArgs e)
        {
            this.txtBillID.ForeColor = Color.Black;
        }

        private void txtPriceForm__TextChanged(object sender, EventArgs e)
        {
            this.txtPriceFrom.ForeColor = Color.Black;
        }
        private void txtPriceTo__TextChanged(object sender, EventArgs e)
        {
            this.txtPriceTo.ForeColor = Color.Black;
        }
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.Image = GUI.Properties.Resources.icons8_home_page_322;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.Image = GUI.Properties.Resources.icons8_home_page_32;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn in hóa đơn này!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                String billId = this.dataGridViewBill.SelectedRows[0].Cells[0].Value.ToString();
                BillDTO currentBill = this.BillBUS.getBill(billId);
                if(currentBill.CustomerId == "")
                {
                    currentBill.CustomerId = null;
                }
                List<BillDetailDTO> billDetailList = this.BillBUS.billDetailListToPrint(billId);
                new ExportExcelSupportBUS().exportBillToExcel(currentBill, billDetailList);
            }

        }
    }
}
