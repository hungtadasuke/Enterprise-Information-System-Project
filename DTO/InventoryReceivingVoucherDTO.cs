using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InventoryReceivingVoucherDTO
    {
        private string _Id;
        private DateTime _Date;
        private double _Total;
        private string _StafId;
        private string _SupplierId;
        private double _Paid;

        public string Id { get => _Id; set => _Id = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public double Total { get => _Total; set => _Total = value; }
        public string StafId { get => _StafId; set => _StafId = value; }
        public string SupplierId { get => _SupplierId; set => _SupplierId = value; }
        public double Paid { get => _Paid; set => _Paid = value; }

        public InventoryReceivingVoucherDTO(string id, DateTime date, double toltal, string stafId, string supplierId, double paid)
        {
            Id = id;
            Date = date;
            Total = toltal;
            StafId = stafId;
            SupplierId = supplierId;
            Paid = paid;
        }

        public InventoryReceivingVoucherDTO()
        {
            Paid = 0;
        }
    }
}

