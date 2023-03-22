using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InventoryReceivingVoucherDetailDTO
    {
        private string _Re_id;
        private string _Product_ID;
        private int _Quantity;

        public string Re_id { get => _Re_id; set => _Re_id = value; }
        public string Product_ID { get => _Product_ID; set => _Product_ID = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public InventoryReceivingVoucherDetailDTO()
        {
        }

        public InventoryReceivingVoucherDetailDTO(string re_id, string product_ID, int quantity)
        {
            Re_id = re_id;
            Product_ID = product_ID;
            Quantity = quantity;
        }
    }
}
