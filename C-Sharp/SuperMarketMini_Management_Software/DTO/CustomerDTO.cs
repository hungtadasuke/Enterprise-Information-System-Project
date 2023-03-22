namespace DTO
{
    public class CustomerDTO
    {
        //Fields
        private string customerId;
        private string customerName;
        private string gender;
        private string numberPhone;
        private int point;
        private bool statusItem;

        //Properties
        public string CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public int Point { get => point; set => point = value; }
        public bool StatusItem { get => statusItem; set => statusItem = value; }

        //Constructor
        public CustomerDTO(string customerId, string customerName, string gender, string numberPhone, int point, bool statusItem)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Gender = gender;
            NumberPhone = numberPhone;
            Point = point;
            StatusItem = statusItem;
        }
    }
}
