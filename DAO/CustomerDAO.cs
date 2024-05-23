using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class CustomerDAO
    {
        //Hàm lấy danh sách khách hàng lên từ database
        //Input: none
        //Output: dataTableCustomer
        public DataTable getAllCustomer()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dtCustomer = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select CustomerId, CustomerName, Gender, NumberPhone, Point, StatusItem from Customer", con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dtCustomer);
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return dtCustomer;
        }
        public bool insertCustomer(CustomerDTO newCustomerDTO)
        {
            bool commit = false;
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Customer values (@CustomerName, @Gender, @NumberPhone, @Point, @StatusItem)", con);
                cmd.Parameters.AddWithValue("@CustomerName", newCustomerDTO.CustomerName);
                cmd.Parameters.AddWithValue("@Gender", newCustomerDTO.Gender);
                cmd.Parameters.AddWithValue("@NumberPhone", newCustomerDTO.NumberPhone);
                cmd.Parameters.AddWithValue("@Point", newCustomerDTO.Point);
                cmd.Parameters.AddWithValue("@StatusItem", newCustomerDTO.StatusItem);
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
        public bool updateCustomer(CustomerDTO customerDTO)
        {
            bool commit = false;
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Customer set CustomerName = @CustomerName, Gender = @Gender, NumberPhone = @NumberPhone, Point = @Point, StatusItem = @StatusItem where CustomerId = @CustomerId", con);
                cmd.Parameters.AddWithValue("@CustomerName", customerDTO.CustomerName);
                cmd.Parameters.AddWithValue("@Gender", customerDTO.Gender);
                cmd.Parameters.AddWithValue("@NumberPhone", customerDTO.NumberPhone);
                cmd.Parameters.AddWithValue("@Point", customerDTO.Point);
                cmd.Parameters.AddWithValue("@StatusItem", customerDTO.StatusItem);
                cmd.Parameters.AddWithValue("@CustomerId", customerDTO.CustomerId);
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
        public DataTable getCustomerSearchList(string gender, string name, string phone)
        {
            int count = 0;
            string querryCustomerSearchList = $"select CustomerId, CustomerName, Gender, NumberPhone, Point, StatusItem from Customer where";
            string conditionGender = $" Gender = N'{gender}'";
            string conditionAdd1 = $" and";
            string conditionCustomerName = $" CustomerName like N'%{name}%'";
            string conditionAdd2 = $" and";
            string conditionNumberPhone = $" NumberPhone like N'%{phone}%'";
            if (gender != "")
            {
                querryCustomerSearchList += conditionGender;
                count++;
            }

            if (name != "")
            {
                if(count > 0)
                {
                    querryCustomerSearchList += conditionAdd1;
                }
                querryCustomerSearchList += conditionCustomerName;
                count++;
            }
            if (phone != "")
            {
                if (count > 0)
                {
                    querryCustomerSearchList += conditionAdd2;
                }
                querryCustomerSearchList += conditionNumberPhone;
            }
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dtCustomer = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querryCustomerSearchList, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtCustomer);
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return dtCustomer;
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
            SqlCommand cmd = new SqlCommand($"if exists (select * from Customer where NumberPhone = '{phone}') print 'false' else print 'true'", con);
            cmd.ExecuteReader();
            con.Close();
            return check;
        }
        public string checkPhoneUniqueUpdate(string customerId,string phone)
        {
            string check = null;
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            con.InfoMessage += delegate (object seeder, SqlInfoMessageEventArgs e)
            {
                check = e.Message;
            };
            SqlCommand cmd = new SqlCommand($"if exists (select * from Customer where NumberPhone = '{phone}' and CustomerId!='{customerId}') print 'false' else print 'true'", con);
            cmd.ExecuteReader();
            con.Close();
            return check;
        }
    }
}
