using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class InventoryReceivingVoucherDetailBUS
    {
        InventoryReceivingVoucherDetailDAO IRVDDAO = new InventoryReceivingVoucherDetailDAO();

        public DataTable getAllInventoryReceivingVoucherDetailById(string id)
        {
            return IRVDDAO.getAllInventoryReceivingVoucherDetailById(id);
        }
    }
}
