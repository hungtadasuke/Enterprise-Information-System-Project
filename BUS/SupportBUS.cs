using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SupportBUS
    {
        public static String formatPrice(String value)
        {
            //Cách này sẽ trả về dạng 1.200.333
            /* CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
             return double.Parse(value).ToString("#,###", cul.NumberFormat);*/

            //Cách này sẽ trả về dạng 21.233,00đ
            /*var newValue = Decimal.Parse(value);
            var info = CultureInfo.GetCultureInfo("vi-VN");
            return String.Format(info, "{0:c}", newValue);*/

            //Cách này trả về trạng 20,000đ, nếu truyền vào vnđ sẽ là vnđ hoặc khác tùy mình
            return String.Format("{0:0,0 đ}", Double.Parse(value));
        }
    }
}
