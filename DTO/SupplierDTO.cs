using System;

namespace DTO
{
    public class SupplierDTO
    {
        private string supplierId;
        private string supplierName;
        private string numberPhone;
        private string supplierAddress;
        private bool statusItem;

        //Properties
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public string SupplierAddress { get => supplierAddress; set => supplierAddress = value; }
        public bool StatusItem { get => statusItem; set => statusItem = value; }

        //Constructor
        public SupplierDTO(string supplierId, string supplierName, string supplierAddress, string numberPhone, bool statusItem)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
            NumberPhone = numberPhone;
            SupplierAddress = supplierAddress;
            StatusItem = statusItem;
        }
    }
}
