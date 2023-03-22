using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmRevenueSta : Form
    {
        StatisticsBUS statisticsBUS = new StatisticsBUS();
        public frmRevenueSta()
        {
            InitializeComponent();

            // thêm panel chart vào panel chính 
            this.pnBody.Controls.Add(pnContentChart);
            this.pnContentChart.Dock = DockStyle.Fill;
            this.pnContentChart.BringToFront();

            //set data cbDate
            cbDate.Items.Add("Hôm nay");
            cbDate.Items.Add("Tháng này");
            cbDate.Items.Add("Năm nay");

            //set data cbCustomer
            cbCustomer.Items.Add("Tất cả");
            cbCustomer.Items.Add("Khách hàng");
            cbCustomer.Items.Add("Khách vãng lai");

            cbCustomer.SelectedIndex = 0;

        }

        private void getTotalRevenue()
        {
            double totalRevenue = 0;
            if (tbRevenue.Rows.Count > 0)
            {
                for (int i = 0; i < tbRevenue.Rows.Count; i++)
                {
                    totalRevenue += double.Parse(tbRevenue.Rows[i].Cells[3].Value.ToString());
                }
            }

            lblTotal.Text = SupportBUS.formatPrice(totalRevenue.ToString());

        }

        private void LoadDateToDataGridView()
        {
            DataTable dt = new DataTable();


            // Nếu: user chọn tìm kiếm theo khoảng NGÀY TÙY CHỌN (DateTimePicker) thì gán vào dtFrom, dtTo
            // Ngược lại: gán bằng DateTime.MinValue

            DateTime dtFrom = rbtnDatePicker.Checked ? DateTime.ParseExact(dtpDateFrom.Text.ToString(), "dd/MM/yyyy", null) : DateTime.MinValue;
            DateTime dtTo = rbtnDatePicker.Checked ? DateTime.ParseExact(dtpDateTo.Text.ToString(), "dd/MM/yyyy", null) : DateTime.MaxValue;

            // Nếu: user chọn tìm kiếm theo khoảng DOANH THU TÙY CHỌN (TextBox) thì gán vào from, to
            // Ngược lại: gán bằng -1 
            int from = string.IsNullOrWhiteSpace(txtFrom.Texts) ? -1 : int.Parse(txtFrom.Texts);
            int to = string.IsNullOrWhiteSpace(txtTo.Texts) ? -1 : int.Parse(txtTo.Texts);

            //Nếu: user chọn tìm kiếm thêm TRÊN, DƯỚI TÙY CHỌN (TextBox) thì gán vào from, to
            if (rbtnMoreThan.Checked)
            {
                from = string.IsNullOrWhiteSpace(txtMoreThan.Texts) ? -1 : int.Parse(txtMoreThan.Texts);
                to = string.IsNullOrWhiteSpace(txtMoreThan.Texts) ? -1 : int.MaxValue;
            }
            else if (rbtnLessThan.Checked)
            {
                from = string.IsNullOrWhiteSpace(txtLessThan.Texts) ? -1 : 0;
                to = string.IsNullOrWhiteSpace(txtLessThan.Texts) ? -1 : int.Parse(txtLessThan.Texts);
            }

            int customer = cbCustomer.SelectedIndex;

            // Nếu check vào ComboBox(Hôm nay, tháng này, năm nay) sẽ lấy datatable theo comboBox(Hôm nay, tháng này, năm nay) 
            if (rbtnDate.Checked)
                switch (cbDate.Text)
                {
                    case "Hôm nay":
                        dt = statisticsBUS.getAllBillByFilter(txtSearch.Texts.Trim(), DateTime.Today, DateTime.Today, from, to, customer);
                        break;
                    case "Tháng này":
                        dt = statisticsBUS.getAllBillByFilter(txtSearch.Texts.Trim(), new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1), new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)), from, to, customer);
                        break;
                    case "Năm nay":
                        dt = statisticsBUS.getAllBillByFilter(txtSearch.Texts.Trim(), new DateTime(DateTime.Today.Year, 1, 1), new DateTime(DateTime.Today.Year, 12, 31), from, to, customer);
                        break;
                    default:
                        dt = statisticsBUS.getAllBillByFilter(txtSearch.Texts.Trim(), dtFrom, dtTo, from, to, customer);
                        break;
                }
            else
                dt = statisticsBUS.getAllBillByFilter(txtSearch.Texts.Trim(), dtFrom, dtTo, from, to, customer);

            if (dt != null)
                this.tbRevenue.DataSource = dt;
            getTotalRevenue();

            if (tbRevenue.CurrentRow != null)
                tbRevenue.CurrentRow.Selected = false;
        }

        private void LoadDataToChart()
        {
            // set chart

            chart1.DataSource = statisticsBUS.getAllBillByDate();

            chart1.Series[0].XValueMember = "BillDate";
            chart1.Series[0].XValueType = ChartValueType.DateTime;

            chart1.Series[0].YValueMembers = "Total";
            chart1.Series[0].YValueType = ChartValueType.Double;


            /*            chart1.Series[0].Points.AddXY(1, 2);
                        chart1.Series[0].Points.AddXY(2, 5);
                        chart1.Series[0].Points.AddXY(3, 2);
                        chart1.Series[0].Points.AddXY(4, 1);*/

            //chart1.Series[0].ToolTip = "#VAL";

            chart1.Series[0].ToolTip = "Y Value: #VALY";

            chart1.Series[0].ToolTip = "#SERIESNAME : #VALY{F2}";


            chart1.ChartAreas[0].CursorX.AutoScroll = true;

            //chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 4);

            //chart1.ChartAreas[0].AxisX.Maximum = Double.NaN;
            //chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            //chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll; // set scrollbar ngang ko cho xem all
            chart1.ChartAreas[0].AxisX.ScrollBar.Size = 14;
            chart1.ChartAreas[0].AxisX.ScrollBar.BackColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.FromArgb(185, 185, 185);

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 8;
            //chart1.ChartAreas[0].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Number;

            chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 8;

        }

        private void SetCurrencyFormat()
        {
            // Set currency format trong Datagridview VD 10.000,00 đ
            var provider = (CultureInfo)CultureInfo.GetCultureInfo("vi-VN");

            this.tbRevenue.Columns[2].DefaultCellStyle.FormatProvider = provider;

            this.tbRevenue.Columns[2].DefaultCellStyle.Format = "c";

            this.tbRevenue.Columns[3].DefaultCellStyle.FormatProvider = provider;

            this.tbRevenue.Columns[3].DefaultCellStyle.Format = "c";

            tbRevenue.Font = new Font(tbRevenue.Font.Name, 12, FontStyle.Regular);

        }

        private void Refresh()
        {
            rbtnDate.Checked = false;
            cbDate.SelectedIndex = -1;

            rbtnDatePicker.Checked = false;

            rbtnMoreThan.Checked = false;
            txtMoreThan.Texts = string.Empty;

            rbtnLessThan.Checked = false;
            txtLessThan.Texts = string.Empty;

            rbtbFromTo.Checked = false;
            txtFrom.Texts = string.Empty;
            txtTo.Texts = string.Empty;

            // search
            txtSearch.Texts = string.Empty;

            // xóa focus DataGridview
            if (tbRevenue.CurrentRow != null)
                tbRevenue.CurrentRow.Selected = false;
        }

        private void frmProductSta_Load(object sender, EventArgs e)
        {
            LoadDateToDataGridView();
            SetCurrencyFormat();



            LoadDataToChart();

        }

        private void rbtnDate_CheckedChanged(object sender, EventArgs e)
        {
            cbDate.Enabled = !cbDate.Enabled;

            //set data back to default
            cbDate.SelectedIndex = -1;
        }

        private void rbtnDatePicker_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateFrom.Enabled = !dtpDateFrom.Enabled;
            dtpDateTo.Enabled = !dtpDateTo.Enabled;

            //set data back to default
            if(rbtnDatePicker.Checked == false)
            {
                dtpDateFrom.Text = DateTime.Today.ToString();
                dtpDateTo.Text = DateTime.Today.ToString();
            }
        }

        private void rbtnMoreThan_CheckedChanged(object sender, EventArgs e)
        {
            txtMoreThan.Enabled = !txtMoreThan.Enabled;

            //set data back to default
            txtMoreThan.Texts = string.Empty;
        }

        private void rbtnLessThan_CheckedChanged(object sender, EventArgs e)
        {
            txtLessThan.Enabled = !txtLessThan.Enabled;

            //set data back to default
            txtLessThan.Texts = string.Empty;
        }

        private void rbtbFromTo_CheckedChanged(object sender, EventArgs e)
        {
            txtFrom.Enabled = !txtFrom.Enabled;
            txtTo.Enabled = !txtTo.Enabled;

            //set data back to default
            txtFrom.Texts = string.Empty;
            txtTo.Texts = string.Empty;
        }

        private void btnChartView_Click(object sender, EventArgs e)
        {
            this.pnContent.Visible = false;
            this.pnFilter.Visible = false;
            this.txtSearch.Visible = false;
            this.pnContentChart.Visible = true;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDateToDataGridView();
        }

        private void tbProduct_Paint(object sender, PaintEventArgs e)
        {
            if (tbRevenue.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "Không tìm thấy dữ liệu !!!",
                    tbRevenue.Font, tbRevenue.ClientRectangle,
                    tbRevenue.ForeColor, tbRevenue.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void pbHome_MouseEnter(object sender, EventArgs e)
        {
            this.pbHome.Image = global::GUI.Properties.Resources.icons8_reply_arrow_322;
        }

        private void pbHome_MouseLeave(object sender, EventArgs e)
        {
            this.pbHome.Image = global::GUI.Properties.Resources.icons8_reply_arrow_32;
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            this.pnContent.Visible = true;
            this.pnFilter.Visible = true;
            this.txtSearch.Visible = true;
            this.pnContentChart.Visible = false;

        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadDateToDataGridView();
        }

        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            LoadDateToDataGridView();
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // lấy datatable đang show trên GUI
            DataTable dt = (DataTable)tbRevenue.DataSource;

            // Mở SaveFileDialog và thiết lập một số cài đặt cho SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string dateTimeFormat = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");
            saveFileDialog.Filter = "All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "Thống kê doanh thu " + dateTimeFormat;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (statisticsBUS.ExportRevenue(dt, saveFileDialog.FileName))
                {
                    MessageBox.Show("Xuất file thành công");
                }
                else
                {
                    MessageBox.Show("Xuất file thất bại");
                }
            }
        }
    }
}
