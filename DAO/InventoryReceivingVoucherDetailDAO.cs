using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class InventoryReceivingVoucherDetailDAO
    {
        public DataTable getAllInventoryReceivingVoucherDetailById(string id)
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select irvd.Re_Id, irvd.Quantity, irvd.ProductId, p.ProductName, irvd.UnitPrice from dbo.InventoryReceivingVoucherDetail irvd, dbo.Product p where Re_Id = '" + id + "' and p.ProductId = irvd.ProductId");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
