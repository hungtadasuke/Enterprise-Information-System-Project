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
    public partial class frmCustomerSta : Form
    {
        StatisticsBUS statisticsBUS = new StatisticsBUS();
        public frmCustomerSta()
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

        }

        private void LoadDateToDataGridView()
        {
            DataTable dt = new DataTable();

            //DateTime.ParseExact(dtpDateFrom.Text.ToString(), "dd/MM/yyyy", null);

            // Nếu: user chọn tìm kiếm theo khoảng NGÀY TÙY CHỌN (DateTimePicker) thì gán vào dtFrom, dtTo
            // Ngược lại: gán bằng DateTime.MinValue

            DateTime dtFrom = rbtnDatePicker.Checked ? DateTime.ParseExact(dtpDateFrom.Text.ToString(), "dd/MM/yyyy", null) : DateTime.MinValue;
            DateTime dtTo = rbtnDatePicker.Checked ? DateTime.ParseExact(dtpDateTo.Text.ToString(), "dd/MM/yyyy", null) : DateTime.MinValue; 

            // Nếu: user chọn tìm kiếm theo khoảng ĐÃ MUA HÀNG TÙY CHỌN (TextBox) thì gán vào from, to
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

            // Nếu check vào ComboBox(Hôm nay, tháng này, năm nay) sẽ lấy datatable theo comboBox(Hôm nay, tháng này, năm nay) 
            if (rbtnDate.Checked)
                switch (cbDate.Text)
                {
                    case "Hôm nay":
                        dt = statisticsBUS.getAllCustomerByFilter(txtSearch.Texts.Trim(), DateTime.Today, DateTime.Today, from, to);
                        break;
                    case "Tháng này":
                        dt = statisticsBUS.getAllCustomerByFilter(txtSearch.Texts.Trim(), new DateTime(DateTime.Today.Year,DateTime.Today.Month,1), new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)), from, to);
                        break;
                    case "Năm nay":
                        dt = statisticsBUS.getAllCustomerByFilter(txtSearch.Texts.Trim(), new DateTime(DateTime.Today.Year,1,1), new DateTime(DateTime.Today.Year, 12, 31), from, to);
                        break;
                    default:
                        dt = statisticsBUS.getAllCustomerByFilter(txtSearch.Texts.Trim(), dtFrom, dtTo, from, to);
                        break;
                }
            else
                dt = statisticsBUS.getAllCustomerByFilter(txtSearch.Texts.Trim(), dtFrom, dtTo, from, to);
            
            if(dt != null)
                this.tbProduct.DataSource = dt;
            
            if(tbProduct.CurrentRow != null)
                tbProduct.CurrentRow.Selected = false;
        }

        private void LoadDataToChart()
        {
            DataTable dt = statisticsBUS.getAllCustomerByFilter("", DateTime.MinValue, DateTime.MinValue, -1, -1);

            // set pie chart
            for (int i = 0; i < 5; i++)
            {
                DataPoint dp = new DataPoint(1, double.Parse(dt.Rows[i][4].ToString()));

                chart2.Series[0].Points.Add(dp);

                chart2.Series[0].Points[i].LegendText = dt.Rows[i][1].ToString();

                chart2.Series[0].Points[i].LegendToolTip = dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString();
            }

            // set tooltip  VD: 20,4%
            chart2.Series[0].ToolTip = "#PERCENT";


            // set chart

            chart1.DataSource = dt;

            chart1.Series[0].XValueMember = "CustomerName";
            chart1.Series[0].XValueType = ChartValueType.String;

            chart1.Series[0].YValueMembers = "Revenue";
            chart1.Series[0].YValueType = ChartValueType.Double;

            chart1.Series[0].ToolTip = "Tổng chi tiêu: #VAL";

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 4); // fix lag scrollbar

            chart1.ChartAreas[0].CursorX.AutoScroll = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll; // set scrollbar ngang ko cho xem all
            chart1.ChartAreas[0].AxisX.ScrollBar.Size = 14;
            chart1.ChartAreas[0].AxisX.ScrollBar.BackColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.FromArgb(185, 185, 185);

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 4;
            chart1.ChartAreas[0].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Number;
            chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 4;

        }

        private void SetCurrencyFormat()
        {
            // Set currency format trong Datagridview VD 10.000,00 đ
            var provider = (CultureInfo)CultureInfo.GetCultureInfo("vi-VN");

            this.tbProduct.Columns[4].DefaultCellStyle.FormatProvider = provider;

            this.tbProduct.Columns[4].DefaultCellStyle.Format = "c";

            tbProduct.Font = new Font(tbProduct.Font.Name, 12, FontStyle.Regular);

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
            if (tbProduct.CurrentRow != null)
                tbProduct.CurrentRow.Selected = false;
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
            if (tbProduct.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "Không tìm thấy dữ liệu !!!",
                    tbProduct.Font, tbProduct.ClientRectangle,
                    tbProduct.ForeColor, tbProduct.BackgroundColor,
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
            DataTable dt = (DataTable)tbProduct.DataSource;

            // Mởi SaveFileDialog và thiết lập một số cài đặt
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string dateTimeFormat = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");
            saveFileDialog.Filter = "All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "Thống kê khách hàng " + dateTimeFormat;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (statisticsBUS.ExportCustomer(dt, saveFileDialog.FileName))
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
