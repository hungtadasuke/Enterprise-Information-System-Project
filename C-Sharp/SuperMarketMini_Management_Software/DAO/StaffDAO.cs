using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class StaffDAO
    {
        public DataTable getAllStaff()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StaffId, StaffName, Gender, Birthday, NumberPhone, AddressNow, Position, StatusItem from Staff");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getAllPosition()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Position from Staff");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getAllID()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StaffId from Staff");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public bool addStaff(string StaffName, string Gender, string Birthday, string NumberPhone, string AddressNow, string Position, bool StatusItem)
        {
            try
            {
                SqlConnection con = DatabaseHelper.getConnection();
                con.Open();
                int status = StatusItem ? 1 : 0;
                SqlCommand cmd = new SqlCommand($"insert into Staff(StaffName, Gender, Birthday, NumberPhone, AddressNow, Position, StatusItem) Values (N'{StaffName}', N'{Gender}', '{Birthday}', '{NumberPhone}',N'{AddressNow}',N'{Position}', {status})");
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

        public bool editStaff(string StaffName, string Gender, string Birthday, string NumberPhone, string AddressNow, string Position, bool StatusItem, string StaffID)
        {
            try
            {
                SqlConnection con = DatabaseHelper.getConnection();
                con.Open();
                int status = StatusItem ? 1 : 0;
                SqlCommand cmd = new SqlCommand($"update Staff set StaffName = N'{StaffName}', Gender = N'{Gender}', Birthday = '{Birthday}', NumberPhone = '{NumberPhone}', AddressNow = N'{AddressNow}', Position = N'{Position}', StatusItem = {status} where StaffId = '{StaffID}'");
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

        public static StaffDTO getStaffById(string id)
        {
            StaffDTO staff = new StaffDTO();
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StaffId, StaffName, Gender, Birthday, NumberPhone, AddressNow, Position, StatusItem from Staff where StaffId like '" + id + "'");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            staff.StaffID = reader[0].ToString();
            staff.StaffName = reader[1].ToString();
            reader.Close();
            return staff;
        }
    }
}