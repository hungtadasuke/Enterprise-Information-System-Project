using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        public DataTable getAllAccount()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select* from LoginAccount");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        //Hàm lấy danh sách username
        public DataTable getAllUsername()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand command = new SqlCommand("select Username from LoginAccount", con);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        //Hàm lấy danh sách password
        public DataTable getAllPassword()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand command = new SqlCommand("select LoginPassword from LoginAccount", con);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        //Hàm thêm account
        public bool addAccount(string username, string password, string staffId, int permission, bool statusItems)
        {
            try
            {
                SqlConnection con = DatabaseHelper.getConnection();
                con.Open();
                int status = statusItems ? 1 : 0;
                SqlCommand cmd = new SqlCommand($"insert into LoginAccount(Username, LoginPassword, StaffId, Permission, StatusItem) values ('{username}','{password}','{staffId}',{permission}, {status})");
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                con.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //sửa
        public bool editAccount(string password, string staffId, int permission, bool statusItems)
        {
            try
            {
                SqlConnection con = DatabaseHelper.getConnection();
                con.Open();
                int status = statusItems ? 1 : 0;
                SqlCommand cmd = new SqlCommand($"update LoginAccount set LoginPassword = '{password}',Permission = {permission}, StatusItem = {status} where StaffId = '{staffId}'");
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                con.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}