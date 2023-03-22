using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using DAO;
using DTO;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;

namespace BUS
{
    public class BillBUS
    {
        //Fields
        private DataTable billList;
        private BillDAO billDAO;
        private DataTable billListOfHung;
        private ProductDAO productDAO;

        //Properties
        public DataTable BillList { get => billList; set => billList = value; }
        public BillDAO BillDAO { get => billDAO; set => billDAO = value; }
        public DataTable BillListOfHung { get => billListOfHung; set => billListOfHung = value; }
        public ProductDAO ProductDAO { get => productDAO; set => productDAO = value; }

        //Constructor
        public BillBUS()
        {
            this.billDAO = new BillDAO();
            this.productDAO = new ProductDAO();
            this.billList = billDAO.getAllBill();
            this.billListOfHung = billDAO.getAllBillOfHung();
        }

        //Hàm reset danh sách hóa đơn
        public void resetBillList()
        {
            this.billListOfHung = this.BillDAO.getAllBillOfHung();
            this.billList = this.billDAO.getAllBill();
        }

        //Hàm gọi hàm thêm một bill và các chi tiết bill của bill đó từ lớp DAO
        //Input: BillDTO, List<BillDetailDTO>
        //Output: string notification
        public string insertBill(BillDTO bill, List<BillDetailDTO> billDetailList, int point)
        {
            if(this.billDAO.insertBill(bill, billDetailList, point))
            {
                this.resetBillList();
                return "Hóa đơn này đã được tạo thành công!";
            }
            return "Đã có lỗi xảy ra trong quá trình tạo hóa đơn, vui lòng liên hệ bộ phận kỹ thuật!";
        }

        public DataTable getBill(string dateFrom, string dateTo)
        {
            return billDAO.getBill(dateFrom, dateTo);
        }

        public DataTable getBillDetail(string BillId)
        {
            return BillDAO.getBillDetail(BillId);
        }

        public DataTable getBillSearchList(string billId, double priceFrom, double priceTo, string dateForm, string dateTo)
        {
            return BillDAO.getBillSearchList(billId, priceFrom, priceTo, dateForm, dateTo);
        }

        public string deleteBill(string BillId)
        {
            ProductDAO.updateProductQuantityWhenDeteleBillDetail(this.billDetailListToPrint(BillId));
            if(BillDAO.deleteBill(BillId))
            {
                this.resetBillList();
                return "Xóa hóa đơn và chi tiết hóa đơn trong database thành công!";
            }
            return "Đã có lỗi xảy ra trong quá trình xóa hóa đơn và chi tiết hóa đơn!";
        }

        public BillDTO getBill(String BillId)
        {
            BillDTO bill = null;
            for(int i = 0; i < this.BillListOfHung.Rows.Count; i++)
            {
                DataRow dr = this.BillListOfHung.Rows[i];
                if (dr[0].ToString() == BillId)
                {
                    String billId = dr[0].ToString();
                    DateTime billDate = DateTime.Parse(dr[1].ToString());
                    double discount = double.Parse(dr[2].ToString());
                    double total = double.Parse(dr[3].ToString());
                    String staffId = dr[4].ToString();
                    String customerId = dr[5].ToString();
                    bill = new BillDTO(billId, billDate, total, discount, staffId, customerId);
                    break;
                }
            }
            return bill;
        }

        //getBillDetailToPrint
        public List<BillDetailDTO> billDetailListToPrint (String billId)
        {
            List<BillDetailDTO> billDetailList = null;
            DataTable dtBillDetail = this.BillDAO.getBillDetailToPrint(billId);
            if(dtBillDetail != null)
            {
                billDetailList = new List<BillDetailDTO>();
                for (int i = 0; i < dtBillDetail.Rows.Count; i++)
                {
                    DataRow dr = dtBillDetail.Rows[i];
                    BillDetailDTO billDetailDTO = new BillDetailDTO(dr[0].ToString(), dr[1].ToString(), int.Parse(dr[2].ToString()), double.Parse(dr[3].ToString()));
                    billDetailList.Add(billDetailDTO);
                }
            }
            return billDetailList;
        }
    }
}
