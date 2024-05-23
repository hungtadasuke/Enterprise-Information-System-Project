using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PaymentVoucherDAO
    {
        public DataTable getAllPaymentVoucher()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from PaymentVoucher");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public bool insertPV(PaymentVoucherDTO pv)
        {
            bool result = true;
            SqlConnection con = DatabaseHelper.getConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction = null;
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Transaction = transaction;

                if (pv.Reason != "Thanh toán phiếu nhập")
                {
                    cmd.CommandText = "insert into PaymentVoucher (Pay_Date, Reason, Pay_Money, StaffId, Note) values  (@Date, @Reason, @Money, @StaffID, ";
                    cmd.Parameters.AddWithValue("@Date", pv.Date.Date);
                    cmd.Parameters.AddWithValue("@Reason", pv.Reason);
                    cmd.Parameters.AddWithValue("@Money", pv.Paymoney);
                    cmd.Parameters.AddWithValue("@StaffID", pv.StaffID);
                    if (pv.Note == "")
                    {
                        cmd.CommandText += " null)";
                    }
                    else
                    {
                        cmd.CommandText += " @Note)";
                        cmd.Parameters.AddWithValue("@Note", pv.Note);
                    }
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = "insert into PaymentVoucher (Pay_Date, Reason, Pay_Money, StaffId, Re_Id, Note) values  (@Date, @Reason, @Money, @StaffID, @Re_Id, ";
                    cmd.Parameters.AddWithValue("@Date", pv.Date.Date);
                    cmd.Parameters.AddWithValue("@Reason", pv.Reason);
                    cmd.Parameters.AddWithValue("@Money", pv.Paymoney);
                    cmd.Parameters.AddWithValue("@StaffID", pv.StaffID);
                    cmd.Parameters.AddWithValue("@Re_Id", pv.ReID);
                    if (pv.Note == "")
                    {
                        cmd.CommandText += " null)";
                    }
                    else
                    {
                        cmd.CommandText += " @Note)";
                        cmd.Parameters.AddWithValue("@Note", pv.Note);
                    }
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update InventoryReceivingVoucher set Paid = Paid +" + pv.Paymoney + " where Re_Id = '" + pv.ReID + "'";
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch 
            {
                transaction.Rollback();
                result = false;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public DataTable getPVSearchList(string id, string staffId, string irvID, string reason, int dateOption, DateTime date, DateTime dateFrom, DateTime dateTo, int totalOption, string total, string totalFrom, string totalTo)
        {
            string querryIRVSearchList = "select * from PaymentVoucher, Staff where PaymentVoucher.StaffId = Staff.StaffId";
            string filterId = " and Pay_Id like '%" + id + "%'";
            string filterReId = " and Re_Id like '%" + irvID + "%'";
            string filterStaffId = " and PaymentVoucher.StaffId like '%" + staffId + "%'";
            string filterReason = " and Reason like N'%" + reason + "%'";
            string filterDate = " and Pay_Date = '" + date.ToString("yyyy-MM-dd") + "'";
            string filterDateFromTo = " and Pay_Date between '" + dateFrom.ToString("yyyy-MM-dd") + "' and '" + dateTo.ToString("yyyy-MM-dd") + "'";
            string filterPayMoney = " and Pay_Money ";

            if (!id.Equals("") && !id.Equals("Tìm kiếm mã phiếu chi"))
            {
                querryIRVSearchList += filterId;
            }
            if (!irvID.Equals(""))
            {
                querryIRVSearchList += filterReId;
            }
            if (!staffId.Equals(""))
            {
                querryIRVSearchList += filterStaffId;
            }
            if (!reason.Equals(""))
            {
                querryIRVSearchList += filterReason;
            }
            if (dateOption == 1)
            {
                querryIRVSearchList += filterDate;
            }
            else if (dateOption == 2)
            {
                querryIRVSearchList += filterDateFromTo;
            }
            if (totalOption == 1 && !total.Equals(""))
            {
                querryIRVSearchList += filterPayMoney + ">= " + total;
            }
            else if (totalOption == 2 && !total.Equals(""))
            {
                querryIRVSearchList += filterPayMoney + "<= " + total;
            }
            else if (totalOption == 3 && !totalFrom.Equals("") && !totalTo.Equals(""))
            {
                querryIRVSearchList += filterPayMoney + "between " + totalFrom + " and " + totalTo;
            }
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querryIRVSearchList, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
            }
            catch (SqlException)
            {
                return null;
            }
            return dt;
        }

        public bool updatePV(PaymentVoucherDTO pv)
        {
            bool result = true;
            SqlConnection con = DatabaseHelper.getConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction = null;
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Transaction = transaction;

                string minus = "update InventoryReceivingVoucher set Paid = Paid - (select Pay_Money from PaymentVoucher where Pay_Id = @Pay_Id) where Re_Id = @Re_ID1";
                string bonus = " update InventoryReceivingVoucher set Paid = (Paid + @Pay) where Re_Id = @Re_ID2";

                //lay ra li do va ma phieu nhap cu cua phieu chi
                cmd.CommandText = "select Reason, Re_Id from PaymentVoucher where Pay_Id = '" + pv.Id + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                string oldReason = "";
                string oldReID = "";
                while (reader.Read())
                {
                    oldReason = reader[0].ToString();
                    oldReID = reader[1].ToString();
                }
                reader.Close();

                // neu ly do moi la thanh toan phieu nhap
                if (pv.Reason == "Thanh toán phiếu nhập")
                {
                    // so sanh voi ly do va ma pn cu, neu cung la thanh toan 1 phieu nhap thi cap nhat gia tri Paid (tru roi cong lai gia tri moi) cua phieu nhap
                    if (pv.Reason.Equals(oldReason) && pv.ReID.Equals(oldReID))
                    {
                        cmd.CommandText = minus + bonus;
                        cmd.Parameters.AddWithValue("@Pay_Id", pv.Id);
                        cmd.Parameters.AddWithValue("@Re_ID1", pv.ReID);
                        cmd.Parameters.AddWithValue("@Pay", pv.Paymoney);
                        cmd.Parameters.AddWithValue("@Re_ID2", pv.ReID);
                        cmd.ExecuteNonQuery();
                    }
                    // doi phieu nhap khac thi tru phieu cu tang phieu moi (Paid)
                    if (pv.Reason.Equals(oldReason) && !pv.ReID.Equals(oldReID))
                    {
                        cmd.CommandText = minus + bonus;
                        cmd.Parameters.AddWithValue("@Pay_Id", pv.Id);
                        cmd.Parameters.AddWithValue("@Re_ID1", oldReID);
                        cmd.Parameters.AddWithValue("@Pay", pv.Paymoney);
                        cmd.Parameters.AddWithValue("@Re_ID2", pv.ReID);
                        cmd.ExecuteNonQuery();
                    }
                    //neu chuyen tu khac qua thi cap nhat gia moi
                    if (!pv.Reason.Equals(oldReason))
                    {
                        cmd.CommandText = bonus;
                        cmd.Parameters.AddWithValue("@Pay", pv.Paymoney);
                        cmd.Parameters.AddWithValue("@Re_ID2", pv.ReID);
                        cmd.ExecuteNonQuery();
                    }

                    cmd.Parameters.Clear();
                    cmd.CommandText = "update PaymentVoucher set Pay_Date = @Pay_Date, Reason = @Reason, Pay_Money = @Pay_Money , StaffId = @StaffId, Re_Id = @Re_Id, Note = @Note where Pay_Id = @Pay_Id";
                    cmd.Parameters.AddWithValue("@Pay_Date", pv.Date.Date);
                    cmd.Parameters.AddWithValue("@Reason", pv.Reason);
                    cmd.Parameters.AddWithValue("@Pay_Money", pv.Paymoney);
                    cmd.Parameters.AddWithValue("@StaffID", pv.StaffID);
                    cmd.Parameters.AddWithValue("@Re_Id", pv.ReID);
                    cmd.Parameters.AddWithValue("@Note", pv.Note);
                    cmd.Parameters.AddWithValue("@Pay_Id", pv.Id);
                    cmd.ExecuteNonQuery();

                }
                // ly do la "khac'"
                else
                {
                    // neu li do cu la thanh toan phieu nhap doi sang khac
                    // thi tru paid cua phieu cu
                    if (!pv.Reason.Equals(oldReason))
                    {
                        cmd.CommandText = minus;
                        cmd.Parameters.AddWithValue("@Re_ID1", oldReID);
                        cmd.Parameters.AddWithValue("@Pay_Id", pv.Id);
                        cmd.ExecuteNonQuery();
                    }

                    cmd.Parameters.Clear();
                    cmd.CommandText = "update PaymentVoucher set Pay_Date = @Pay_Date, Reason = @Reason, Pay_Money = @Pay_Money , StaffId = @StaffId, Re_Id = null, Note = @Note where Pay_Id = @Pay_Id";
                    cmd.Parameters.AddWithValue("@Pay_Date", pv.Date.Date);
                    cmd.Parameters.AddWithValue("@Reason", pv.Reason);
                    cmd.Parameters.AddWithValue("@Pay_Money", pv.Paymoney);
                    cmd.Parameters.AddWithValue("@StaffID", pv.StaffID);
                    cmd.Parameters.AddWithValue("@Note", pv.Note);
                    cmd.Parameters.AddWithValue("@Pay_Id", pv.Id);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                result = false;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool deletePV(PaymentVoucherDTO pv)
        {
            bool result = true;
            SqlConnection con = DatabaseHelper.getConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction = null;
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Transaction = transaction;

                if (pv.Reason == "Thanh toán phiếu nhập")
                {
                    cmd.CommandText = "update InventoryReceivingVoucher set Paid = Paid - @Pay where Re_Id =  @Re_ID";
                    cmd.Parameters.AddWithValue("@Pay", pv.Paymoney);
                    cmd.Parameters.AddWithValue("@Re_ID", pv.ReID);
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = "delete from PaymentVoucher where Pay_Id = '" + pv.Id + "'";
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                result = false;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}
