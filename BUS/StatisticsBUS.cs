using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using DAO;
using DTO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;

namespace BUS
{
    public class StatisticsBUS
    {
        private DataTable dtCategory;
        private DataTable dtProduct;
        private DataTable dtRevenue;
        private DataTable dtStaff;
        private DataTable dtCustomer;

        private StatisticsDAO statisticsDAO = new StatisticsDAO();

        public StatisticsBUS()
        {
            dtProduct = statisticsDAO.getAllProduct();
            dtCategory = statisticsDAO.getAllCategory();
            dtRevenue = statisticsDAO.getAllBill();
            dtStaff = statisticsDAO.getAllStaff();
            dtCustomer = statisticsDAO.getAllCustomer();
        }

        public DataTable DtCategory { get => dtCategory; set => dtCategory = value; }
        public DataTable DtProduct { get => dtProduct; set => dtProduct = value; }
        public DataTable DtRevenue { get => dtRevenue; set => dtRevenue = value; }
        public DataTable DtStaff { get => dtStaff; set => dtStaff = value; }
        public DataTable DtCustomer { get => dtCustomer; set => dtCustomer = value; }

        public DataTable getAllProductByFilter(string keyword, string category, DateTime dateFrom, DateTime dateTo, int from, int to)
        {
            // Khởi tạo 1 dt kết quả
            DataTable result = new DataTable();
            // gọi phương thức lấy dt product từ lớp DAO (theo ngày tùy chọn, tất cả)
            //dtProduct = dateFrom != DateTime.MinValue ? statisticsDAO.getAllProductByDate(dateFrom.ToString(), dateTo.ToString()) : statisticsDAO.getAllProduct();
            dtProduct = dateFrom != DateTime.MinValue ? statisticsDAO.getAllProductByDate(dateFrom, dateTo) : statisticsDAO.getAllProduct();

            if (dtProduct == null) { return result; }

            for (int i = 1; i < dtProduct.Columns.Count; i++)
            {
                result.Columns.Add(dtProduct.Columns[i].ColumnName);
            }

            // Chỉnh sửa định dạng các cột thành double

            result.Columns[2].DataType = typeof(double); // tồn kho
            result.Columns[3].DataType = typeof(double); // giá bán
            result.Columns[5].DataType = typeof(double); // đã bán
            result.Columns[6].DataType = typeof(double); // Doanh thu

            foreach (DataRow dr in dtProduct.Rows)
            {
                if (category == "Tất cả")
                {
                    DataRow ndr = result.NewRow();
                    ndr[0] = dr[1];
                    ndr[1] = dr[2];
                    ndr[2] = dr[3];
                    ndr[3] = double.Parse(dr[4].ToString());
                    ndr[4] = (Boolean.Parse(dr[5].ToString())) ? "Bán" : "Ngừng bán";
                    ndr[5] = dr[6];
                    ndr[6] = double.Parse(dr[7].ToString());
                    result.Rows.Add(ndr);
                }
                else if (dr[0].Equals(category))
                {
                    DataRow ndr = result.NewRow();
                    ndr[0] = dr[1];
                    ndr[1] = dr[2];
                    ndr[2] = dr[3];
                    ndr[3] = double.Parse(dr[4].ToString());
                    ndr[4] = (Boolean.Parse(dr[5].ToString())) ? "Bán" : "Ngừng bán";
                    ndr[5] = dr[6];
                    ndr[6] = double.Parse(dr[7].ToString());
                    result.Rows.Add(ndr);
                }
            } 
            result.AcceptChanges(); //!string.IsNullOrWhiteSpace(keyword) 

            if (from != -1 || keyword !="" )
                foreach (DataRow dr in result.Rows)
                {
                    bool Quantity = ( (from != -1 && int.Parse(dr[6].ToString()) < from ) || ( to !=-1 && int.Parse(dr[6].ToString()) > to) );
                    bool search = (!dr[0].ToString().ToLower().Contains(keyword.ToLower()) && !dr[1].ToString().ToLower().Contains(keyword.ToLower()));
                    if (Quantity || search)
                    {
                        dr.Delete();
                    }
                }
            result.AcceptChanges();

            return result;
        }

        public DataTable getAllBillByFilter(string keyword, DateTime dateFrom, DateTime dateTo, double from, double to, int customer)
        {
            DataTable result = new DataTable();

            dtRevenue = statisticsDAO.getAllBill();

            if(dtRevenue == null) { return result; }

            for (int i = 0; i < dtRevenue.Columns.Count-1; i++)
            {
                result.Columns.Add(dtRevenue.Columns[i].ColumnName);
            }

            result.Columns[0].DataType = typeof(DateTime);
            result.Columns[2].DataType = typeof(double);
            result.Columns[3].DataType = typeof(double);

            foreach (DataRow dr in dtRevenue.Rows)
            {
                if (dateFrom <= DateTime.Parse(dr[0].ToString()) && DateTime.Parse(dr[0].ToString()) <= dateTo)
                {
                    if (customer == 0)
                    {
                        DataRow ndr = result.NewRow();
                        ndr[0] = dr[0];
                        ndr[1] = dr[1];
                        ndr[2] = dr[2];
                        ndr[3] = dr[3];
                        result.Rows.Add(ndr);
                    }
                    else if ( customer == 1 && !string.IsNullOrWhiteSpace(dr[4].ToString()))
                    {
                        DataRow ndr = result.NewRow();
                        ndr[0] = dr[0];
                        ndr[1] = dr[1];
                        ndr[2] = dr[2];
                        ndr[3] = dr[3];
                        result.Rows.Add(ndr);
                    }
                    else if (customer == 2 && string.IsNullOrWhiteSpace(dr[4].ToString()))
                    {
                        DataRow ndr = result.NewRow();
                        ndr[0] = dr[0];
                        ndr[1] = dr[1];
                        ndr[2] = dr[2];
                        ndr[3] = dr[3];
                        result.Rows.Add(ndr);
                    }
                }
            }
            result.AcceptChanges();

            if (from != -1 || keyword !="")
            {
                foreach (DataRow dr in result.Rows)
                {
                    bool Revenue = ((from != -1 && int.Parse(dr[3].ToString()) < from) || (to != -1 && int.Parse(dr[3].ToString()) > to));
                    bool search = !dr[1].ToString().ToLower().Contains(keyword.ToLower());
                    if (Revenue || search)
                    {
                        dr.Delete();
                    }
                }
            }
            result.AcceptChanges();

            return result;
        }

        public DataTable getAllStaffbyFilter(string keyword, DateTime dateFrom, DateTime dateTo, double from, double to)
        {
            DataTable result = new DataTable();

            dtStaff = dateFrom != DateTime.MinValue ? statisticsDAO.getAllStaffByDate(dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd")) : statisticsDAO.getAllStaff();

            if (dtStaff == null) { return result; }

            for (int i = 0; i < dtStaff.Columns.Count; i++)
            {
                result.Columns.Add(dtStaff.Columns[i].ColumnName);
            }

            // Chỉnh sửa định dạng các cột thành double

            result.Columns[3].DataType = typeof(double); 
 

            foreach (DataRow dr in dtStaff.Rows)
            {
                DataRow ndr = result.NewRow();
                ndr[0] = dr[0];
                ndr[1] = dr[1];
                ndr[2] = dr[2];
                ndr[3] = dr[3];
                result.Rows.Add(ndr);
            }
            result.AcceptChanges();

            if (from != -1 || keyword != "")
                foreach (DataRow dr in result.Rows)
                {
                    bool Revenue = ((from != -1 && int.Parse(dr[3].ToString()) < from) || (to != -1 && int.Parse(dr[3].ToString()) > to));
                    bool search = (!dr[0].ToString().ToLower().Contains(keyword.ToLower()) && !dr[1].ToString().ToLower().Contains(keyword.ToLower()));
                    if (Revenue || search)
                    {
                        dr.Delete();
                    }
                }
            result.AcceptChanges();

            return result;
        }

        public DataTable getAllCustomerByFilter(string keyword, DateTime dateFrom, DateTime dateTo, double from, double to)
        {
            DataTable result = new DataTable();

            dtCustomer = dateFrom != DateTime.MinValue ? statisticsDAO.getAllCustomerByDate(dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd")) : statisticsDAO.getAllCustomer();

            if (dtCustomer == null) { return result; }

            for (int i = 0; i < dtCustomer.Columns.Count; i++)
            {
                result.Columns.Add(dtCustomer.Columns[i].ColumnName);
            }

            // Chỉnh sửa định dạng các cột thành double

            result.Columns[3].DataType = typeof(double); // BillCount
            result.Columns[4].DataType = typeof(double); // Đã mua hàng


            foreach (DataRow dr in dtCustomer.Rows)
            {
                DataRow ndr = result.NewRow();
                ndr[0] = dr[0];
                ndr[1] = dr[1];
                ndr[2] = dr[2];
                ndr[3] = dr[3];
                ndr[4] = dr[4];
                result.Rows.Add(ndr);
            }
            result.AcceptChanges();

            if (from != -1 || keyword != "")
                foreach (DataRow dr in result.Rows)
                {
                    bool Revenue = ((from != -1 && int.Parse(dr[4].ToString()) < from) || (to != -1 && int.Parse(dr[4].ToString()) > to));
                    bool search = (!dr[0].ToString().ToLower().Contains(keyword.ToLower()) && !dr[1].ToString().ToLower().Contains(keyword.ToLower()));
                    if (Revenue || search)
                    {
                        dr.Delete();
                    }
                }
            result.AcceptChanges();

            return result;
        }

        public DataTable getAllBillByDate()
        {
            return statisticsDAO.getAllBillByDate();
        }

        //
        //  Export Excel
        //

        public bool ExportProduct(DataTable tbProduct,string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                //Tạo một pakage excel
                ExcelPackage excelPackage = new ExcelPackage();

                //
                //Thiết lập các thông số cơ bản cho workBook
                //

                //Tác giả của workBook
                excelPackage.Workbook.Properties.Author = "Võ Quang Đăng Khoa";

                //Title của workBook
                excelPackage.Workbook.Properties.Title = "Báo cáo thống kê hàng hóa";

                //Thêm một sheet tên "Báo cáo thống kê hàng hóa" vào workBook của excelPackage để thao tác
                excelPackage.Workbook.Worksheets.Add("Báo cáo thống kê hàng hóa");

                //Tạo một biến kiểu ExcelWorksheet tham chiếu tới sheet vừa add
                ExcelWorksheet ws = excelPackage.Workbook.Worksheets[0];

                //FontSize and fontFamily mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 12;
                ws.Cells.Style.Font.Name = "Calibri";

                //
                //Thao tác export data trên sheet vừa add
                //

                ws.Cells[1, 1, 2, 8].Merge = true;
                //size
                ws.Cells[1, 1, 2, 8].Style.Font.Size = 20;
                //font style
                ws.Cells[1, 1, 2, 8].Style.Font.Bold = true;
                //text alignment
                ws.Cells[1, 1, 2, 8].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[1, 1, 2, 8].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                //Heading superMarket name
                ws.Cells[1, 1, 2, 8].Value = "FIVECHIP MART";

                //Heading Báo cáo thống kê
                ws.Cells[3, 1, 4, 8].Merge = true;
                ws.Cells[3, 1, 4, 8].Style.Font.Size = 16;
                ws.Cells[3, 1, 4, 8].Style.Font.Bold = true;
                ws.Cells[3, 1, 4, 8].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells[3, 1, 4, 8].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[3, 1, 4, 8].Value = "BÁO CÁO THỐNG KÊ HÀNG HÓA";

                // Thiết lập độ rộng cột cho STT, Mã hàng hóa, Tên hàng hóa, Tồn kho, Giá bán, Trạng thái, Đã bán, Doanh thu
                ws.Columns[1].Width = 8;    
                ws.Columns[2].Width = 17.5;
                ws.Columns[3].Width = 47;
                ws.Columns[4].Width = 15;
                ws.Columns[5].Width = 23;
                ws.Columns[6].Width = 19;
                ws.Columns[7].Width = 15;
                ws.Columns[8].Width = 26;

                int indexRow = 5;

                //Báo cáo thống kê gồm STT, Mã hàng hóa, Tên hàng hóa, Tồn kho, Giá bán, Trạng thái, Đã bán, Doanh thu
                //Báo cáo thống kê header
                ws.Cells[indexRow, 1].Value = "STT";
                ws.Cells[indexRow, 1].Style.Font.Bold = true;
                ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 2].Value = "Mã hàng hóa";
                ws.Cells[indexRow, 2].Style.Font.Bold = true;
                ws.Cells[indexRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 3].Value = "Tên hàng hóa";
                ws.Cells[indexRow, 3].Style.Font.Bold = true;
                ws.Cells[indexRow, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 4].Value = "Tồn kho";
                ws.Cells[indexRow, 4].Style.Font.Bold = true;
                ws.Cells[indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 5].Value = "Giá bán";
                ws.Cells[indexRow, 5].Style.Font.Bold = true;
                ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 6].Value = "Trạng thái";
                ws.Cells[indexRow, 6].Style.Font.Bold = true;
                ws.Cells[indexRow, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 7].Value = "Đã bán";
                ws.Cells[indexRow, 7].Style.Font.Bold = true;
                ws.Cells[indexRow, 7].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 8].Value = "Doanh thu";
                ws.Cells[indexRow, 8].Style.Font.Bold = true;
                ws.Cells[indexRow, 8].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                //Báo cáo thông kê body
                for (int i = 0; i < tbProduct.Rows.Count; i++)
                {
                    // STT
                    ws.Cells[indexRow, 1].Value = i + 1;
                    ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    
                    // Mã hàng hóa
                    ws.Cells[indexRow, 2].Value = tbProduct.Rows[i][0].ToString();
                    ws.Cells[indexRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    
                    // Tên hàng hóa
                    ws.Cells[indexRow, 3].Value = tbProduct.Rows[i][1].ToString();

                    // Tồn kho
                    ws.Cells[indexRow, 4].Value = tbProduct.Rows[i][2].ToString();
                    ws.Cells[indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    
                    // Giá bán
                    ws.Cells[indexRow, 5].Value = SupportBUS.formatPrice(tbProduct.Rows[i][3].ToString());
                    ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Trạng thái
                    ws.Cells[indexRow, 6].Value = tbProduct.Rows[i][4].ToString();
                    ws.Cells[indexRow, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Đã bán
                    ws.Cells[indexRow, 7].Value = tbProduct.Rows[i][5].ToString();
                    ws.Cells[indexRow, 7].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Doanh thu
                    ws.Cells[indexRow, 8].Value = SupportBUS.formatPrice(tbProduct.Rows[i][6].ToString());
                    ws.Cells[indexRow, 8].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    indexRow++;
                }

                //Total info 
                ws.Cells[indexRow, 1, indexRow, 6].Merge = true;
                ws.Cells[indexRow, 1, indexRow, 6].Value = "Tổng Cộng:";
                ws.Cells[indexRow, 1, indexRow, 6].Style.Font.Bold = true;
                ws.Cells[indexRow, 1, indexRow, 6].Style.Font.Size = 14;
                ws.Cells[indexRow, 1, indexRow, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Tính tổng cộng Doanh Thu
                double Sum = 0;
                foreach(DataRow dr in tbProduct.Rows)
                {
                    Sum += Double.Parse(dr[6].ToString());
                }

                ws.Cells[indexRow, 8].Value = SupportBUS.formatPrice(Sum.ToString());
                ws.Cells[indexRow, 8].Style.Font.Bold = true;
                ws.Cells[indexRow, 8].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                ExcelRange rng = ws.Cells[indexRow, 1, indexRow, 8];
                rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                //Set table
                ExcelRange mainRange = ws.Cells[5, 1, indexRow-1, 8];

                ExcelTable tb = ws.Tables.Add(mainRange, "Table1");

                tb.TableStyle = TableStyles.Medium9;

                // save as
                excelPackage.SaveAs(new System.IO.FileInfo($@"{path}.xlsx"));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        
        public bool ExportRevenue(DataTable tbRevenue, string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                //Tạo một pakage excel
                ExcelPackage excelPackage = new ExcelPackage();

                //
                //Thiết lập các thông số cơ bản cho workBook
                //

                //Tác giả của workBook
                excelPackage.Workbook.Properties.Author = "Võ Quang Đăng Khoa";

                //Title của workBook
                excelPackage.Workbook.Properties.Title = "Báo cáo thống kê doanh thu";

                //Thêm một sheet tên "Báo cáo thống kê hàng hóa" vào workBook của excelPackage để thao tác
                excelPackage.Workbook.Worksheets.Add("Báo cáo thống kê doanh thu");

                //Tạo một biến kiểu ExcelWorksheet tham chiếu tới sheet vừa add
                ExcelWorksheet ws = excelPackage.Workbook.Worksheets[0];

                //FontSize and fontFamily mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 12;
                ws.Cells.Style.Font.Name = "Calibri";

                //
                //Thao tác export data trên sheet vừa add
                //

                ws.Cells[1, 1, 2, 5].Merge = true;
                //size
                ws.Cells[1, 1, 2, 5].Style.Font.Size = 20;
                //font style
                ws.Cells[1, 1, 2, 5].Style.Font.Bold = true;
                //text alignment
                ws.Cells[1, 1, 2, 5].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[1, 1, 2, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                //Heading superMarket name
                ws.Cells[1, 1, 2, 5].Value = "FIVECHIP MART";

                //Heading Báo cáo thống kê
                ws.Cells[3, 1, 4, 5].Merge = true;
                ws.Cells[3, 1, 4, 5].Style.Font.Size = 16;
                ws.Cells[3, 1, 4, 5].Style.Font.Bold = true;
                ws.Cells[3, 1, 4, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells[3, 1, 4, 5].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[3, 1, 4, 5].Value = "BÁO CÁO THỐNG KÊ DOANH THU";

                // Thiết lập độ rộng cột cho STT, Mã hàng hóa, Tên hàng hóa, Tồn kho, Giá bán, Giá nhập, Trạng thái, Đã bán, Doanh thu
                ws.Columns[1].Width = 8;
                ws.Columns[2].Width = 18;
                ws.Columns[3].Width = 20;
                ws.Columns[4].Width = 21;
                ws.Columns[5].Width = 25;

                int indexRow = 5;

                //Báo cáo thống kê gồm STT, Mã hàng hóa, Tên hàng hóa, Tồn kho, Giá bán, Giá nhập, Trạng thái, Đã bán, Doanh thu
                //Báo cáo thống kê header
                ws.Cells[indexRow, 1].Value = "STT";
                ws.Cells[indexRow, 1].Style.Font.Bold = true;
                ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 2].Value = "Ngày";
                ws.Cells[indexRow, 2].Style.Font.Bold = true;
                ws.Cells[indexRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 3].Value = "Mã hóa đơn";
                ws.Cells[indexRow, 3].Style.Font.Bold = true;
                ws.Cells[indexRow, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 4].Value = "Khuyến mãi";
                ws.Cells[indexRow, 4].Style.Font.Bold = true;
                ws.Cells[indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 5].Value = "Doanh thu";
                ws.Cells[indexRow, 5].Style.Font.Bold = true;
                ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                //Báo cáo thông kê body
                for (int i = 0; i < tbRevenue.Rows.Count; i++)
                {
                    // STT
                    ws.Cells[indexRow, 1].Value = i + 1;
                    ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Ngày
                    ws.Cells[indexRow, 2].Value = tbRevenue.Rows[i][0].ToString().Split(' ')[0];
                    ws.Cells[indexRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Mã hóa đơn
                    ws.Cells[indexRow, 3].Value = tbRevenue.Rows[i][1].ToString();
                    ws.Cells[indexRow, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Khuyến mãi
                    ws.Cells[indexRow, 4].Value = SupportBUS.formatPrice(tbRevenue.Rows[i][2].ToString());
                    ws.Cells[indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Doanh thu
                    ws.Cells[indexRow, 5].Value = SupportBUS.formatPrice(tbRevenue.Rows[i][3].ToString());
                    ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    indexRow++;
                }

                //Total info 
                ws.Cells[indexRow, 1, indexRow, 3].Merge = true;
                ws.Cells[indexRow, 1, indexRow, 3].Value = "Tổng Cộng:";
                ws.Cells[indexRow, 1, indexRow, 3].Style.Font.Bold = true;
                ws.Cells[indexRow, 1, indexRow, 3].Style.Font.Size = 14;
                ws.Cells[indexRow, 1, indexRow, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Tính tổng cộng Doanh Thu
                double Sum = 0;
                foreach (DataRow dr in tbRevenue.Rows)
                {
                    Sum += Double.Parse(dr[3].ToString());
                }

                ws.Cells[indexRow, 5].Value = SupportBUS.formatPrice(Sum.ToString());
                ws.Cells[indexRow, 5].Style.Font.Bold = true;
                ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                ExcelRange rng = ws.Cells[indexRow, 1, indexRow, 5];
                rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                //Set table
                ExcelRange mainRange = ws.Cells[5, 1, indexRow - 1, 5];

                ExcelTable tb = ws.Tables.Add(mainRange, "Table1");

                tb.TableStyle = TableStyles.Medium9;

                // save as
                excelPackage.SaveAs(new System.IO.FileInfo($@"{path}.xlsx"));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool ExportStaff(DataTable tbStaff, string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                //Tạo một pakage excel
                ExcelPackage excelPackage = new ExcelPackage();

                //
                //Thiết lập các thông số cơ bản cho workBook
                //

                //Tác giả của workBook
                excelPackage.Workbook.Properties.Author = "Võ Quang Đăng Khoa";

                //Title của workBook
                excelPackage.Workbook.Properties.Title = "Báo cáo thống kê nhân viên";

                //Thêm một sheet tên "Báo cáo thống kê hàng hóa" vào workBook của excelPackage để thao tác
                excelPackage.Workbook.Worksheets.Add("Báo cáo thống kê nhân viên");

                //Tạo một biến kiểu ExcelWorksheet tham chiếu tới sheet vừa add
                ExcelWorksheet ws = excelPackage.Workbook.Worksheets[0];

                //FontSize and fontFamily mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 12;
                ws.Cells.Style.Font.Name = "Calibri";

                //
                //Thao tác export data trên sheet vừa add
                //

                ws.Cells[1, 1, 2, 5].Merge = true;
                //size
                ws.Cells[1, 1, 2, 5].Style.Font.Size = 20;
                //font style
                ws.Cells[1, 1, 2, 5].Style.Font.Bold = true;
                //text alignment
                ws.Cells[1, 1, 2, 5].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[1, 1, 2, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                //Heading superMarket name
                ws.Cells[1, 1, 2, 5].Value = "FIVECHIP MART";

                //Heading Báo cáo thống kê
                ws.Cells[3, 1, 4, 5].Merge = true;
                ws.Cells[3, 1, 4, 5].Style.Font.Size = 16;
                ws.Cells[3, 1, 4, 5].Style.Font.Bold = true;
                ws.Cells[3, 1, 4, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells[3, 1, 4, 5].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[3, 1, 4, 5].Value = "BÁO CÁO THỐNG KÊ NHÂN VIÊN";

                // Thiết lập độ rộng cột cho STT, Mã hàng hóa, Tên hàng hóa, Tồn kho, Giá bán, Giá nhập, Trạng thái, Đã bán, Doanh thu
                ws.Columns[1].Width = 8;
                ws.Columns[2].Width = 18;
                ws.Columns[3].Width = 26;
                ws.Columns[4].Width = 19;
                ws.Columns[5].Width = 26;

                int indexRow = 5;

                //Báo cáo thống kê gồm STT, Mã hàng hóa, Tên hàng hóa, Tồn kho, Giá bán, Giá nhập, Trạng thái, Đã bán, Doanh thu
                //Báo cáo thống kê header
                ws.Cells[indexRow, 1].Value = "STT";
                ws.Cells[indexRow, 1].Style.Font.Bold = true;
                ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 2].Value = "Mã nhân viên";
                ws.Cells[indexRow, 2].Style.Font.Bold = true;
                ws.Cells[indexRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 3].Value = "Tên nhân viên";
                ws.Cells[indexRow, 3].Style.Font.Bold = true;
                ws.Cells[indexRow, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 4].Value = "Số điện thoại";
                ws.Cells[indexRow, 4].Style.Font.Bold = true;
                ws.Cells[indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 5].Value = "Doanh thu";
                ws.Cells[indexRow, 5].Style.Font.Bold = true;
                ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                //Báo cáo thông kê body
                for (int i = 0; i < tbStaff.Rows.Count; i++)
                {
                    // STT
                    ws.Cells[indexRow, 1].Value = i + 1;
                    ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Ngày
                    ws.Cells[indexRow, 2].Value = tbStaff.Rows[i][0].ToString();
                    ws.Cells[indexRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;

                    // Mã hóa đơn
                    ws.Cells[indexRow, 3].Value = tbStaff.Rows[i][1].ToString();
                    ws.Cells[indexRow, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Khuyến mãi
                    ws.Cells[indexRow, 4].Value = tbStaff.Rows[i][2].ToString();
                    ws.Cells[indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Doanh thu
                    ws.Cells[indexRow, 5].Value = SupportBUS.formatPrice(tbStaff.Rows[i][3].ToString());
                    ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    indexRow++;
                }

                //Total info 
                ws.Cells[indexRow, 1, indexRow, 4].Merge = true;
                ws.Cells[indexRow, 1, indexRow, 4].Value = "Tổng Cộng:";
                ws.Cells[indexRow, 1, indexRow, 4].Style.Font.Bold = true;
                ws.Cells[indexRow, 1, indexRow, 4].Style.Font.Size = 14;
                ws.Cells[indexRow, 1, indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Tính tổng cộng Doanh Thu
                double Sum = 0;
                foreach (DataRow dr in tbStaff.Rows)
                {
                    Sum += Double.Parse(dr[3].ToString());
                }

                ws.Cells[indexRow, 5].Value = SupportBUS.formatPrice(Sum.ToString());
                ws.Cells[indexRow, 5].Style.Font.Bold = true;
                ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                ExcelRange rng = ws.Cells[indexRow, 1, indexRow, 5];
                rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                //Set table
                ExcelRange mainRange = ws.Cells[5, 1, indexRow - 1, 5];

                ExcelTable tb = ws.Tables.Add(mainRange, "Table1");

                tb.TableStyle = TableStyles.Medium9;

                // save as
                excelPackage.SaveAs(new System.IO.FileInfo($@"{path}.xlsx"));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool ExportCustomer(DataTable tbCustomer, string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                //Tạo một pakage excel
                ExcelPackage excelPackage = new ExcelPackage();

                //
                //Thiết lập các thông số cơ bản cho workBook
                //

                //Tác giả của workBook
                excelPackage.Workbook.Properties.Author = "Võ Quang Đăng Khoa";

                //Title của workBook
                excelPackage.Workbook.Properties.Title = "Báo cáo thống kê khách hàng";

                //Thêm một sheet tên "Báo cáo thống kê hàng hóa" vào workBook của excelPackage để thao tác
                excelPackage.Workbook.Worksheets.Add("Báo cáo thống kê khách hàng");

                //Tạo một biến kiểu ExcelWorksheet tham chiếu tới sheet vừa add
                ExcelWorksheet ws = excelPackage.Workbook.Worksheets[0];

                //FontSize and fontFamily mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 12;
                ws.Cells.Style.Font.Name = "Calibri";

                //
                //Thao tác export data trên sheet vừa add
                //

                ws.Cells[1, 1, 2, 6].Merge = true;
                //size
                ws.Cells[1, 1, 2, 6].Style.Font.Size = 20;
                //font style
                ws.Cells[1, 1, 2, 6].Style.Font.Bold = true;
                //text alignment
                ws.Cells[1, 1, 2, 6].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[1, 1, 2, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                //Heading superMarket name
                ws.Cells[1, 1, 2, 6].Value = "FIVECHIP MART";

                //Heading Báo cáo thống kê
                ws.Cells[3, 1, 4, 6].Merge = true;
                ws.Cells[3, 1, 4, 6].Style.Font.Size = 16;
                ws.Cells[3, 1, 4, 6].Style.Font.Bold = true;
                ws.Cells[3, 1, 4, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells[3, 1, 4, 6].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[3, 1, 4, 6].Value = "BÁO CÁO THỐNG KÊ KHÁCH HÀNG";

                // Thiết lập độ rộng cột cho STT, Mã hàng hóa, Tên hàng hóa, Tồn kho, Giá bán, Giá nhập, Trạng thái, Đã bán, Doanh thu
                ws.Columns[1].Width = 8;
                ws.Columns[2].Width = 18;
                ws.Columns[3].Width = 26;
                ws.Columns[4].Width = 19;
                ws.Columns[5].Width = 15;
                ws.Columns[6].Width = 26;

                int indexRow = 5;

                //Báo cáo thống kê gồm STT, Mã hàng hóa, Tên hàng hóa, Tồn kho, Giá bán, Giá nhập, Trạng thái, Đã bán, Doanh thu
                //Báo cáo thống kê header
                ws.Cells[indexRow, 1].Value = "STT";
                ws.Cells[indexRow, 1].Style.Font.Bold = true;
                ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 2].Value = "Mã khách hàng";
                ws.Cells[indexRow, 2].Style.Font.Bold = true;
                ws.Cells[indexRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 3].Value = "Tên khách hàng";
                ws.Cells[indexRow, 3].Style.Font.Bold = true;
                ws.Cells[indexRow, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 4].Value = "Số điện thoại";
                ws.Cells[indexRow, 4].Style.Font.Bold = true;
                ws.Cells[indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 5].Value = "Số hóa đơn";
                ws.Cells[indexRow, 5].Style.Font.Bold = true;
                ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 6].Value = "Doanh thu";
                ws.Cells[indexRow, 6].Style.Font.Bold = true;
                ws.Cells[indexRow, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                //Báo cáo thông kê body
                for (int i = 0; i < tbCustomer.Rows.Count; i++)
                {
                    // STT
                    ws.Cells[indexRow, 1].Value = i + 1;
                    ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Mã khách hàng
                    ws.Cells[indexRow, 2].Value = tbCustomer.Rows[i][0].ToString();
                    ws.Cells[indexRow, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Tên khách hàng
                    ws.Cells[indexRow, 3].Value = tbCustomer.Rows[i][1].ToString();
                    ws.Cells[indexRow, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;

                    // Số điện thoại
                    ws.Cells[indexRow, 4].Value = tbCustomer.Rows[i][2].ToString();
                    ws.Cells[indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Số hóa đơn
                    ws.Cells[indexRow, 5].Value = tbCustomer.Rows[i][3].ToString();
                    ws.Cells[indexRow, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    // Doanh thu
                    ws.Cells[indexRow, 6].Value = SupportBUS.formatPrice(tbCustomer.Rows[i][4].ToString());
                    ws.Cells[indexRow, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    indexRow++;
                }

                //Total info 
                ws.Cells[indexRow, 1, indexRow, 4].Merge = true;
                ws.Cells[indexRow, 1, indexRow, 4].Value = "Tổng Cộng:";
                ws.Cells[indexRow, 1, indexRow, 4].Style.Font.Bold = true;
                ws.Cells[indexRow, 1, indexRow, 4].Style.Font.Size = 14;
                ws.Cells[indexRow, 1, indexRow, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Tính tổng cộng Doanh Thu
                double Sum = 0;
                foreach (DataRow dr in tbCustomer.Rows)
                {
                    Sum += Double.Parse(dr[4].ToString());
                }

                ws.Cells[indexRow, 6].Value = SupportBUS.formatPrice(Sum.ToString());
                ws.Cells[indexRow, 6].Style.Font.Bold = true;
                ws.Cells[indexRow, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                ExcelRange rng = ws.Cells[indexRow, 1, indexRow, 6];
                rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                //Set table
                ExcelRange mainRange = ws.Cells[5, 1, indexRow - 1, 6];

                ExcelTable tb = ws.Tables.Add(mainRange, "Table1");

                tb.TableStyle = TableStyles.Medium9;

                // save as
                excelPackage.SaveAs(new System.IO.FileInfo($@"{path}.xlsx"));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
