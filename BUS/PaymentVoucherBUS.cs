using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PaymentVoucherBUS
    {
        PaymentVoucherDAO pVoucherDAO = new PaymentVoucherDAO();

        public DataTable getAllPaymentVoucher()
        {
            return pVoucherDAO.getAllPaymentVoucher();
        }

        public DataTable getPVSearchList(string id, string staffId, string irvID, string reason, int dateOption, DateTime date, DateTime dateFrom, DateTime dateTo, int totalOption, string total, string totalFrom, string totalTo)
        {
            return pVoucherDAO.getPVSearchList(id, staffId, irvID, reason, dateOption, date, dateFrom, dateTo, totalOption, total, totalFrom, totalTo);
        }

        public bool insertPV(PaymentVoucherDTO pv)
        {
            return pVoucherDAO.insertPV(pv);
        }

        public bool deletePV(PaymentVoucherDTO pv)
        {
            return pVoucherDAO.deletePV(pv);
        }

        public bool updatePV(PaymentVoucherDTO pv)
        {
            return pVoucherDAO.updatePV(pv);
        }
    }
}
