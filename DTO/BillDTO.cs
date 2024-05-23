using System;

namespace DTO
{
    public class BillDTO
    {
        //Fields
        private string billId;
        private DateTime billDate;
        private double total;
        private double discount;
        private string staffId;
        private string customerId;

        //Properties
        public string BillId { get => billId; set => billId = value; }
        public DateTime BillDate { get => billDate; set => billDate = value; }
        public double Total { get => total; set => total = value; }
        public double Discount { get => discount; set => discount = value; }
        public string StaffId { get => staffId; set => staffId = value; }
        public string CustomerId { get => customerId; set => customerId = value; }

        //Constructor
        public BillDTO(string billId, DateTime billDate, double total, double discount, string staffId, string customerId)
        {
            BillId = billId;
            BillDate = billDate;
            Total = total;
            Discount = discount;
            StaffId = staffId;
            CustomerId = customerId;
        }

    }
}
