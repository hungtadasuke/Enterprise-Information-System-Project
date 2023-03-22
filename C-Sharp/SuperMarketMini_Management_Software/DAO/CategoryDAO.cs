using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoryDAO
    {
        public DataTable getAllCategory()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select CategoryId, CategoryName, StatusItem from Category");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getAllCategoryName()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select CategoryName from Category");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public bool addCategory(string categoryName, bool statusItems)
        {
            try
            {
                SqlConnection con = DatabaseHelper.getConnection();
                con.Open();
                int status = statusItems ? 1 : 0;
                SqlCommand cmd = new SqlCommand($"insert into Category(CategoryName, StatusItem) values (N'{categoryName}', {status})");
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

        public bool editCategory(string categoryName, bool statusItems, string categoryId)
        {
            try
            {
                SqlConnection con = DatabaseHelper.getConnection();
                con.Open();
                int status = statusItems ? 1 : 0;
                SqlCommand cmd = new SqlCommand($"update Category set CategoryName = N'{categoryName}', StatusItem = {status} where CategoryId = '{categoryId}'");
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