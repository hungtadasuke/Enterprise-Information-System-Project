using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace BUS
{
    public class ExportExcelSupportBUS
    {
        /*Đầu tiên hãy import EPPlus to project BUS*/

        //Hàm xuất hóa đơn ra file excel
        //Input: BillDTO, List<BillDetailDTO>
        //Output: exported file
        public bool exportBillToExcel(BillDTO bill, List<BillDetailDTO> billDetailList)
        {   
            //Thiết lập properties cho LicenseContext ExcelPakage là NonCommercial là sử dụng ExcelPakage với mục đích phi thương mại, nếu không set thì nó báo lối
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
                excelPackage.Workbook.Properties.Title = "Hóa Đơn Bán Hàng";

                //Thêm một sheet tên "Hóa đơn bán hàng" vào workBook của excelPackage để thao tác
                excelPackage.Workbook.Worksheets.Add("Hóa Đơn Bán Hàng");

                //Tạo một biến kiểu ExcelWorksheet tham chiếu tới sheet vừa add
                ExcelWorksheet ws = excelPackage.Workbook.Worksheets[0];

                //FontSize and fontFamily mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 12;
                ws.Cells.Style.Font.Name = "Calibri";

                //
                //Thao tác export data trên sheet vừa add
                //
                //Heading billId
                //merge cell from rowStart 1, colStart 1, rowEnd 1, colEnd 10.
                ws.Cells[1, 1, 1, 10].Merge = true;
                //size
                ws.Cells[1, 1, 1, 10].Style.Font.Size = 13;
                //font style
                ws.Cells[1, 1, 1, 10].Style.Font.Bold = true;
                //text alignment
                ws.Cells[1, 1, 1, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                //value of cells merged
                ws.Cells[1, 1, 1, 10].Value = $"Số Hóa Đơn {bill.BillId}";

                //Heading superMarket name
                ws.Cells[2, 1, 3, 10].Merge = true;
                ws.Cells[2, 1, 3, 10].Style.Font.Size = 16;
                ws.Cells[2, 1, 3, 10].Style.Font.Bold = true;
                ws.Cells[2, 1, 3, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells[2, 1, 3, 10].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[2, 1, 3, 10].Value = "FIVECHIP MART";

                //Heading address
                ws.Cells[4, 1, 4, 10].Merge = true;
                ws.Cells[4, 1, 4, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells[4, 1, 4, 10].Value = "CMT8";

                ws.Cells[5, 1, 5, 10].Merge = true;
                ws.Cells[5, 1, 5, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells[5, 1, 5, 10].Value = "770 Cách Mạng Tháng Tám, Phường 13, Quận 10";

                ws.Cells[6, 1, 6, 10].Merge = true;
                ws.Cells[6, 1, 6, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells[6, 1, 6, 10].Value = "Thành Phố Hồ Chí Minh";

                //Common Info ngày, tên nhân viên, khách hàng (tên, điểm) (nếu có)
                ws.Cells[7, 1, 7, 2].Merge = true;
                ws.Cells[7, 1, 7, 2].Value = "    Ngày:";
                ws.Cells[7, 1, 7, 2].Style.Font.Bold = true;

                ws.Cells[8, 1, 8, 2].Merge = true;
                ws.Cells[8, 1, 8, 2].Value = "    Nhân Viên:";
                ws.Cells[8, 1, 8, 2].Style.Font.Bold = true;

                ws.Cells[7, 3, 7, 6].Merge = true;
                ws.Cells[7, 3, 7, 6].Value = bill.BillDate.ToString("dd/MM/yyyy");

                ws.Cells[8, 3, 8, 6].Merge = true;
                ws.Cells[8, 3, 8, 6].Value = "Võ Quang Đăng Khoa";

                int indexRow = 9;
                if (bill.CustomerId != null)
                {
                    CustomerDTO customer = new CustomerBUS().getCustomer(bill.CustomerId);

                    ws.Cells[indexRow, 1, indexRow, 2].Merge = true;
                    ws.Cells[indexRow, 1, indexRow, 2].Value = "    Khách Hàng:";
                    ws.Cells[indexRow, 1, indexRow, 2].Style.Font.Bold = true;

                    ws.Cells[indexRow, 3, indexRow, 6].Merge = true;
                    ws.Cells[indexRow, 3, indexRow, 6].Value = customer.CustomerName;

                    indexRow++;

                    ws.Cells[indexRow, 1, indexRow, 2].Merge = true;
                    ws.Cells[indexRow, 1, indexRow, 2].Value = "    Số Điểm:";
                    ws.Cells[indexRow, 1, indexRow, 2].Style.Font.Bold = true;

                    ws.Cells[indexRow, 3, indexRow, 6].Merge = true;
                    ws.Cells[indexRow, 3, indexRow, 6].Value = customer.Point;
                    ws.Cells[indexRow, 3, indexRow, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;

                    indexRow++;
                }

                //Merge một row trống để ngăn cách
                ws.Cells[indexRow, 1, indexRow, 10].Merge = true;

                indexRow++;

                //Details gồm ordinal, productName, unit, number, price, UnitPrice
                //Details header
                ws.Cells[indexRow, 1].Value = "STT";
                ws.Cells[indexRow, 1].Style.Font.Bold = true;
                ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 2, indexRow, 6].Merge = true;
                ws.Cells[indexRow, 2, indexRow, 6].Value = "Tên Sản Phẩm";
                ws.Cells[indexRow, 2, indexRow, 6].Style.Font.Bold = true;
                ws.Cells[indexRow, 2, indexRow, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 7].Value = "SL";
                ws.Cells[indexRow, 7].Style.Font.Bold = true;
                ws.Cells[indexRow, 7].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 8].Value = "Giá";
                ws.Cells[indexRow, 8].Style.Font.Bold = true;
                ws.Cells[indexRow, 8].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                ws.Cells[indexRow, 9, indexRow, 10].Merge = true;
                ws.Cells[indexRow, 9, indexRow, 10].Value = "Thành Tiền";
                ws.Cells[indexRow, 9, indexRow, 10].Style.Font.Bold = true;
                ws.Cells[indexRow, 9, indexRow, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                //Details body
                for (int i = 0; i < billDetailList.Count; i++)
                {
                    BillDetailDTO _currentDetail = billDetailList[i];
                    ProductDTO _currentProduct = new ProductBUS().getProduct(_currentDetail.ProductId);

                    ws.Cells[indexRow, 1].Value = i + 1;
                    ws.Cells[indexRow, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    ws.Cells[indexRow, 2, indexRow, 6].Merge = true;
                    ws.Cells[indexRow, 2, indexRow, 6].Value = _currentProduct.ProductName;

                    ws.Cells[indexRow, 7].Value = _currentDetail.Quantity;
                    ws.Cells[indexRow, 7].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    ws.Cells[indexRow, 8].Value = $"{SupportBUS.formatPrice(_currentDetail.UnitPrice.ToString())}";
                    ws.Cells[indexRow, 8].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    ws.Cells[indexRow, 9, indexRow, 10].Merge = true;
                    ws.Cells[indexRow, 9, indexRow, 10].Value = $"{SupportBUS.formatPrice((_currentDetail.UnitPrice*_currentDetail.Quantity).ToString())}      ";
                    ws.Cells[indexRow, 9, indexRow, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    indexRow++;
                }

                //Merge một row trống để ngăn cách
                ws.Cells[indexRow, 1, indexRow, 10].Merge = true;

                indexRow++;

                //Total info (total, discount, discountedMoney)
                ws.Cells[indexRow, 7, indexRow, 8].Merge = true;
                ws.Cells[indexRow, 7, indexRow, 8].Value = "Tổng Cộng:";
                ws.Cells[indexRow, 7, indexRow, 8].Style.Font.Bold = true;

                ws.Cells[indexRow, 9, indexRow, 10].Merge = true;
                ws.Cells[indexRow, 9, indexRow, 10].Value = $"{SupportBUS.formatPrice(bill.Total.ToString())}      ";
                ws.Cells[indexRow, 9, indexRow, 10].Style.Font.Bold = true;
                ws.Cells[indexRow, 9, indexRow, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                indexRow++;

                ws.Cells[indexRow, 7, indexRow, 8].Merge = true;
                ws.Cells[indexRow, 7, indexRow, 8].Value = "Giảm Giá:";
                ws.Cells[indexRow, 7, indexRow, 8].Style.Font.Bold = true;

                ws.Cells[indexRow, 9, indexRow, 10].Merge = true;
                ws.Cells[indexRow, 9, indexRow, 10].Value = (bill.Discount == 0) ? "0 đ      " : $"{SupportBUS.formatPrice(bill.Discount.ToString())}      ";
                ws.Cells[indexRow, 9, indexRow, 10].Style.Font.Bold = true;
                ws.Cells[indexRow, 9, indexRow, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                indexRow++;

                ws.Cells[indexRow, 7, indexRow, 8].Merge = true;
                ws.Cells[indexRow, 7, indexRow, 8].Value = "Thanh Toán:";
                ws.Cells[indexRow, 7, indexRow, 8].Style.Font.Bold = true;

                ws.Cells[indexRow, 9, indexRow, 10].Merge = true;
                ws.Cells[indexRow, 9, indexRow, 10].Value = $"{SupportBUS.formatPrice((bill.Total - bill.Discount).ToString())}      ";
                ws.Cells[indexRow, 9, indexRow, 10].Style.Font.Bold = true;
                ws.Cells[indexRow, 9, indexRow, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                indexRow++;

                //Merge một row trống để ngăn cách
                ws.Cells[indexRow, 1, indexRow, 10].Merge = true;

                indexRow++;

                //Note tích điểm
                ws.Cells[indexRow, 1, indexRow, 10].Merge = true;
                ws.Cells[indexRow, 1, indexRow, 10].Value = "Cứ 50,000 đ trên một hóa đơn, bạn sẽ được tích 1 điểm.";
                ws.Cells[indexRow, 1, indexRow, 10].Style.Font.Italic = true;
                ws.Cells[indexRow, 1, indexRow, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                ws.Cells[indexRow, 1, indexRow, 10].Merge = true;
                ws.Cells[indexRow, 1, indexRow, 10].Value = "Với 1 điểm sẽ được quy đổi thành 1,000 đ trong phiên mua hàng kế tiếp.";
                ws.Cells[indexRow, 1, indexRow, 10].Style.Font.Italic = true;
                ws.Cells[indexRow, 1, indexRow, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                //Merge một row trống để ngăn cách
                ws.Cells[indexRow, 1, indexRow, 10].Merge = true;

                indexRow++;

                //Hotline and slogan
                ws.Cells[indexRow, 4, indexRow, 7].Merge = true;
                ws.Cells[indexRow, 4, indexRow, 7].Value = "Hotline: 19009029";
                ws.Cells[indexRow, 4, indexRow, 7].Style.Font.Bold = true;
                ws.Cells[indexRow, 4, indexRow, 7].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                ws.Cells[indexRow, 2, indexRow, 9].Merge = true;
                ws.Cells[indexRow, 2, indexRow, 9].Value = "Cảm Ơn Quý Khách Và Hẹn Gặp lại!";
                ws.Cells[indexRow, 2, indexRow, 9].Style.Font.Bold = true;
                ws.Cells[indexRow, 2, indexRow, 9].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                indexRow++;

                //Format lại border, lines, và backColor của hóa đơn
                //Set border
                ExcelRange mainRange = ws.Cells[1, 1, indexRow, 10];
                mainRange.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                //Ẩn các đường grid
                ws.View.ShowGridLines = false;

                //set background
                mainRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                mainRange.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(179, 192, 217));

                //Lưu excel Pakage vào thư mục ExcelBill trong thư mục gốc, sử dụng đường dẫn tương đối.
                string dateTimeFormat = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");
                excelPackage.SaveAs(new System.IO.FileInfo($@"..\..\..\ExcelBill\{bill.BillId} {dateTimeFormat}.xlsx"));

                //Sau  khi lưu thì mở file excel vừa lưu lên
                FileInfo fi = new FileInfo($@"..\..\..\ExcelBill\{bill.BillId} {dateTimeFormat}.xlsx");
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start($@"..\..\..\ExcelBill\{bill.BillId} {dateTimeFormat}.xlsx");
                }
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
    }
}
