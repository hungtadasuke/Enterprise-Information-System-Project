using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class InventoryReceivingVoucherBUS
    {

        InventoryReceivingVoucherDAO irvDAO = new InventoryReceivingVoucherDAO();

        public DataTable getAllInventoryReceivingVoucher ()
        {
            return irvDAO.getAllInventoryReceivingVoucher();
        }

        public DataTable getInventoryReceivingVoucherOwed()
        {
            return irvDAO.getInventoryReceivingVoucherOwed();
        }

        public DataTable getIRVSearchLisst(String id, string staffId, string supplierId, int dateOption, DateTime date, DateTime dateFrom, DateTime dateTo, int totalOption, string total, string totalFrom, string totalTo)
        {
            return irvDAO.getIRVSearchLisst(id, staffId, supplierId, dateOption, date, dateFrom, dateTo, totalOption, total, totalFrom, totalTo);
        }

        public DataTable getAllSupplier()
        {
            return irvDAO.getAllSupplier();
        }
        public DataTable getAllStaff()
        {
            return irvDAO.getAllStaff();
        }

        public InventoryReceivingVoucherDTO getIRVById(string id)
        {
            return irvDAO.getIRVById(id);
        }

        public bool insertIRV(InventoryReceivingVoucherDTO irv, List<InventoryReceivingVoucherDetailDTO> listIRVD)
        {
            return irvDAO.insertIRV(irv, listIRVD); 
        }

        public int updateIRV(InventoryReceivingVoucherDTO irv, List<InventoryReceivingVoucherDetailDTO> listIRVD)
        {
            return irvDAO.updateIRV(irv, listIRVD);
        }

        public int deleteIRV(string id)
        {
            return irvDAO.deleteIRV(id);
        }
    }
}
