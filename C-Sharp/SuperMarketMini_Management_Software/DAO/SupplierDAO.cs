using System;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class SupplierDAO
    {
        public DataTable getAllSupplier()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dtSupplier = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select SupplierId, SupplierName, SupplierAddress, NumberPhone, StatusItem from Supplier", con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dtSupplier);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return dtSupplier;
        }
        public bool insertSupplier(SupplierDTO newSupplierDTO)
        {
            bool commit = false;
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Supplier values (@SupplierName, @SupplierAddress, @NumberPhone, @StatusItem)", con);
                cmd.Parameters.AddWithValue("@SupplierName", newSupplierDTO.SupplierName);
                cmd.Parameters.AddWithValue("@NumberPhone", newSupplierDTO.NumberPhone);
                cmd.Parameters.AddWithValue("@SupplierAddress", newSupplierDTO.SupplierAddress);
                cmd.Parameters.AddWithValue("@StatusItem", newSupplierDTO.StatusItem);
                cmd.ExecuteNonQuery();
                commit = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                commit = false;
            }
            finally
            {
                con.Close();
            }
            return commit;
        }
        public bool updateSupplier(SupplierDTO supplierDTO)
        {
            bool commit = false;
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Supplier set SupplierName = @SupplierName, SupplierAddress = @SupplierAddress, NumberPhone = @NumberPhone, StatusItem = @StatusItem where SupplierId = @SupplierId", con);
                cmd.Parameters.AddWithValue("@SupplierName", supplierDTO.SupplierName);
                cmd.Parameters.AddWithValue("@SupplierAddress", supplierDTO.SupplierAddress);
                cmd.Parameters.AddWithValue("@NumberPhone", supplierDTO.NumberPhone);
                cmd.Parameters.AddWithValue("@StatusItem", supplierDTO.StatusItem);
                cmd.Parameters.AddWithValue("@SupplierId", supplierDTO.SupplierId);
                cmd.ExecuteNonQuery();
                commit = true;
            }
            catch (SqlException)
            {
                commit = false;
            }
            finally
            {
                con.Close();
            }
            return commit;
        }
        public DataTable getSupplierSearchList(string name, string phone)
        {
            int count = 0;
            string querrySupplierSearchList = $"select SupplierId, SupplierName, SupplierAddress, NumberPhone, StatusItem from Supplier where";
            string conditionSupplierName = $" SupplierName like N'%{name}%'";
            string conditionAdd1 = $" and";
            string conditionNumberPhone = $" NumberPhone like N'%{phone}%'";
            if (name != "")
            {
                querrySupplierSearchList += conditionSupplierName;
                count++;
            }
            if (phone != "")
            {
                if (count > 0)
                {
                    querrySupplierSearchList += conditionAdd1;
                }
                querrySupplierSearchList += conditionNumberPhone;
            }
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querrySupplierSearchList, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public string checkPhoneUniqueAdd(string phone)
        {
            string check = null;
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            con.InfoMessage += delegate (object seeder, SqlInfoMessageEventArgs e)
            {
                check = e.Message;
            };
            SqlCommand cmd = new SqlCommand($"if exists (select * from Supplier where NumberPhone = '{phone}') print 'false' else print 'true'", con);
            cmd.ExecuteReader();
            con.Close();

            return check;
        }
        public string checkPhoneUniqueUpdate(string supplierId,string phone)
        {
            string check = null;
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            con.InfoMessage += delegate (object seeder, SqlInfoMessageEventArgs e)
            {
                check = e.Message;
            };
            SqlCommand cmd = new SqlCommand($"if exists (select * from Supplier where NumberPhone = '{phone}' and SupplierId !='{supplierId}') print 'false' else print 'true'", con);
            cmd.ExecuteReader();
            con.Close();
            return check;
        }
    }
}
