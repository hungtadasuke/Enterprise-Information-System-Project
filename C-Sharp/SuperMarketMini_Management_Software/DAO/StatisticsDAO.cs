using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StatisticsDAO
    {
        SqlConnection conn;

        public StatisticsDAO()
        {
            conn = DatabaseHelper.getConnection();
        }

        public DataTable getAllProduct()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select C.CategoryName, P.ProductId,  P.ProductName, P.Quantity, BD.UnitPrice, P.StatusItem,SUM(BD.Quantity) as QuantitySold, Sum(BD.UnitPrice * BD.Quantity) as Revenue from Product as P, Category as C, BillDetail as BD where P.CategoryId = C.CategoryId and BD.ProductId = P.ProductId group by P.ProductId, C.CategoryName, P.ProductName, P.Quantity, BD.UnitPrice, P.StatusItem  order by QuantitySold DESC");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn thống kê sản phẩm!!");
                return null;
            }
            finally{
                conn.Close();
            }
            return dt;
        }

        public DataTable getAllCategory()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select C.CategoryId, C.CategoryName from Category as C");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);

            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn Nhóm hàng!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getAllProductByDate(DateTime dfrom ,DateTime dto)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select C.CategoryName, P.ProductId,  P.ProductName, P.Quantity, BD.UnitPrice, P.StatusItem,SUM(BD.Quantity) as QuantitySold, Sum(BD.UnitPrice * BD.Quantity) as Revenue from Product as P, Category as C, BillDetail as BD, Bill as B where P.CategoryId = C.CategoryId and BD.ProductId = P.ProductId and B.BillId = BD.BillId and b.BillDate between '{dfrom.Date.ToString("yyyy-MM-dd")}' and '{dto.Date.ToString("yyyy-MM-dd")}' group by P.ProductId, C.CategoryName, P.ProductName, P.Quantity, BD.UnitPrice, P.StatusItem order by QuantitySold DESC");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn thống kê sản phẩm!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getAllBill()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select B.BillDate, B.BillId, B.Discount, B.Total, B.CustomerId from Bill as B");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn thống kê doanh thu!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getAllBillByDate()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select B.BillDate, SUM(B.Total) as Total from Bill as B group by B.BillDate");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn thống kê doanh thu!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getAllStaff()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select ST.StaffId, ST.StaffName, ST.NumberPhone, SUM(B.Total) AS Revenue from Bill as B, Staff as ST where B.StaffId = ST.StaffId group by ST.StaffId, ST.StaffName, ST.NumberPhone");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn thống kê nhân viên!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getAllStaffByDate(string dfrom, string dto)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select ST.StaffId, ST.StaffName, ST.NumberPhone, SUM(B.Total) AS Revenue from Bill as B, Staff as ST where B.StaffId = ST.StaffId and B.BillDate between '{dfrom}' and '{dto}'  group by ST.StaffId, ST.StaffName, ST.NumberPhone");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn thống kê nhân viên!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getAllCustomer()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select CS.CustomerId, CS.CustomerName, CS.NumberPhone, Count(B.BillId) as BillCount, SUM(B.Total) AS Revenue from Bill as B, Customer as CS where B.CustomerId = CS.CustomerId\r\ngroup by CS.CustomerId, CS.CustomerName, CS.NumberPhone Order by Revenue desc");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn thống kê khách hàng!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getAllCustomerByDate(string dfrom, string dto)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"select CS.CustomerId, CS.CustomerName, CS.NumberPhone, Count(B.BillId) as BillCount, SUM(B.Total) AS Revenue from Bill as B, Customer as CS where B.CustomerId = CS.CustomerId and B.BillDate between '{dfrom}' and '{dto}'  group by CS.CustomerId, CS.CustomerName, CS.NumberPhone");
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra Lỗi truy vấn thống kê khách hàng!!");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
