using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentVoucherDTO
    {
        private string _Id;
        private DateTime _Date;
        private double _Paymoney;
        private string _Reason;
        private string _StaffID;
        private string _ReID;
        private string _Note;

        public string Id { get => _Id; set => _Id = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public double Paymoney { get => _Paymoney; set => _Paymoney = value; }
        public string Reason { get => _Reason; set => _Reason = value; }
        public string StaffID { get => _StaffID; set => _StaffID = value; }
        public string ReID { get => _ReID; set => _ReID = value; }
        public string Note { get => _Note; set => _Note = value; }

        public PaymentVoucherDTO(string id, DateTime date, double paymoney, string reason, string staffID, string reID, string note)
        {
            Id = id;
            Date = date;
            Paymoney = paymoney;
            Reason = reason;
            StaffID = staffID;
            ReID = reID;
            Note = note;
        }

        public PaymentVoucherDTO()
        {
        }
    }
}
