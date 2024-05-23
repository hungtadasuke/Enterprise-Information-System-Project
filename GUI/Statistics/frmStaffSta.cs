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
    public partial class frmStaffSta : Form
    {
        StatisticsBUS statisticsBUS = new StatisticsBUS();
        public frmStaffSta()
        {
            InitializeComponent();

            //set data cbDate
            cbDate.Items.Add("Hôm nay");
            cbDate.Items.Add("Tháng này");
            cbDate.Items.Add("Năm nay");

        }

        private void LoadDateToDataGridView()
        {
            DataTable dt = new DataTable();

            // Nếu: user chọn tìm kiếm theo khoảng NGÀY TÙY CHỌN (DateTimePicker) thì gán vào dtFrom, dtTo
            // Ngược lại: gán bằng DateTime.MinValue

            DateTime dtFrom = rbtnDatePicker.Checked ? DateTime.ParseExact(dtpDateFrom.Text.ToString(), "dd/MM/yyyy", null) : DateTime.MinValue;
            DateTime dtTo = rbtnDatePicker.Checked ? DateTime.ParseExact(dtpDateTo.Text.ToString(), "dd/MM/yyyy", null) : DateTime.MinValue; 

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

            // Nếu check vào ComboBox(Hôm nay, tháng này, năm nay) sẽ lấy datatable theo comboBox(Hôm nay, tháng này, năm nay) 
            if (rbtnDate.Checked)
                switch (cbDate.Text)
                {
                    case "Hôm nay":
                        dt = statisticsBUS.getAllStaffbyFilter(txtSearch.Texts.Trim(), DateTime.Today, DateTime.Today, from, to);
                        break;
                    case "Tháng này":
                        dt = statisticsBUS.getAllStaffbyFilter(txtSearch.Texts.Trim(), new DateTime(DateTime.Today.Year,DateTime.Today.Month,1), new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)), from, to);
                        break;
                    case "Năm nay":
                        dt = statisticsBUS.getAllStaffbyFilter(txtSearch.Texts.Trim(), new DateTime(DateTime.Today.Year,1,1), new DateTime(DateTime.Today.Year, 12, 31), from, to);
                        break;
                    default:
                        dt = statisticsBUS.getAllStaffbyFilter(txtSearch.Texts.Trim(), dtFrom, dtTo, from, to);
                        break;
                }
            else
                dt = statisticsBUS.getAllStaffbyFilter(txtSearch.Texts.Trim(), dtFrom, dtTo, from, to);
            
            if (dt != null)
                this.tbStaff.DataSource = dt;

            if(tbStaff.CurrentRow != null)
                tbStaff.CurrentRow.Selected = false;
        }

        private void SetCurrencyFormat()
        {
            // Set currency format trong Datagridview VD 10.000,00 đ
            var provider = (CultureInfo)CultureInfo.GetCultureInfo("vi-VN");

            this.tbStaff.Columns[3].DefaultCellStyle.FormatProvider = provider;

            this.tbStaff.Columns[3].DefaultCellStyle.Format = "c";

            tbStaff.Font = new Font(tbStaff.Font.Name, 12, FontStyle.Regular);

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
            if (tbStaff.CurrentRow != null)
                tbStaff.CurrentRow.Selected = false;
        }

        private void frmProductSta_Load(object sender, EventArgs e)
        {
            LoadDateToDataGridView();
            SetCurrencyFormat();
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

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDateToDataGridView();
        }

        private void tbProduct_Paint(object sender, PaintEventArgs e)
        {
            if (tbStaff.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "Không tìm thấy dữ liệu !!!",
                    tbStaff.Font, tbStaff.ClientRectangle,
                    tbStaff.ForeColor, tbStaff.BackgroundColor,
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
            DataTable dt = (DataTable)tbStaff.DataSource;

            // Mởi SaveFileDialog và thiết lập một số cài đặt
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string dateTimeFormat = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");
            saveFileDialog.Filter = "All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "Thống kê nhân viên " + dateTimeFormat;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (statisticsBUS.ExportStaff(dt, saveFileDialog.FileName))
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
