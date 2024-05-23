namespace DTO
{
    public class ProductDTO
    {
        private string productId;
        private string productName;
        private byte[] productImg;
        private string unit;
        private int quantity;
        private double importPrice;
        private double priceToSell;
        private bool statusItem;
        private string categoryId;
        private string barcode;

        //constructor
        public ProductDTO(string productId, string productName, byte[] productImg, string unit, int quantity, double importPrice, double priceToSell, string categoryId, bool statusItem)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductImg = productImg;
            this.Unit = unit;
            this.Quantity = quantity;
            this.ImportPrice = importPrice;
            this.PriceToSell = priceToSell;
            this.CategoryId = categoryId;
            this.StatusItem = statusItem;
        }

        public ProductDTO(string productId, string productName, string unit, int quantity, double importPrice, double priceToSell, string barcode)
        {
            this.productId = productId;
            this.productName = productName;
            this.unit = unit;
            this.quantity = quantity;
            this.importPrice = importPrice;
            this.priceToSell = priceToSell;
            this.barcode = barcode;
        }

        //setter and getter
        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public byte[] ProductImg { get => productImg; set => productImg = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double ImportPrice { get => importPrice; set => importPrice = value; }
        public double PriceToSell { get => priceToSell; set => priceToSell = value; }
        public bool StatusItem { get => statusItem; set => statusItem = value; }
        public string CategoryId { get => categoryId; set => categoryId = value; }
        public string Barcode { get => barcode; set => barcode = value; }
    }
}
