using System;

namespace DTO
{
    public class BillDetailDTO
    {
        //Fields
        private string billId;
        private string productId;
        private int quantity;
        private double unitPrice;

        //Properties
        public string BillId { get => billId; set => billId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value;}

        //Constructor
        public BillDetailDTO(string billId, string productId, int quantity, double unitPrice)
        {
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
