using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class InventoryReceivingVoucherDAO
    {
        public DataTable getAllInventoryReceivingVoucher()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select *, irv.Total - irv.Paid as Owe from InventoryReceivingVoucher irv, Supplier s where irv.SupplierId = s.SupplierId");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getInventoryReceivingVoucherOwed()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Re_Id from InventoryReceivingVoucher irv where Total - Paid > 0");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getIRVSearchLisst(String id, string staffId, string supplierId, int dateOption, DateTime date, DateTime dateFrom, DateTime dateTo, int totalOption, string total, string totalFrom, string totalTo) 
        {
            string querryIRVSearchList = "select *, irv.Total - irv.Paid as Owe from InventoryReceivingVoucher irv, Supplier s where irv.SupplierId = s.SupplierId";
            string filterId = " and irv.Re_Id like '%" + id + "%'";
            string filterStaffId = " and irv.StaffId like '%" + staffId + "%'";
            string filterSupplierId = " and irv.SupplierId like'%" + supplierId + "%'";
            string filterDate = " and Re_Date = '" + date.ToString("yyyy-MM-dd") + "'";
            string filterDateFromTo = " and Re_Date between '" + dateFrom.ToString("yyyy-MM-dd") + "' and '" + dateTo.ToString("yyyy-MM-dd") + "'";
            string filterTotal = " and Total ";

            if (!id.Equals("") && !id.Equals("Tìm kiếm mã phiếu nhập"))
            {
                querryIRVSearchList += filterId;
            }
            if (!staffId.Equals(""))
            {
                querryIRVSearchList += filterStaffId;
            }
            if (!supplierId.Equals(""))
            {
                querryIRVSearchList += filterSupplierId;
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
                querryIRVSearchList += filterTotal + ">= " + total;
            }
            else if (totalOption == 2 && !total.Equals(""))
            {
                querryIRVSearchList += filterTotal + "<= " + total;
            }
            else if (totalOption == 3 && !totalFrom.Equals("") && !totalTo.Equals(""))
            {
                querryIRVSearchList += filterTotal + "between " + totalFrom + " and " + totalTo;
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

        public DataTable getAllSupplier()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select SupplierId, SupplierName from Supplier");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getAllStaff()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StaffId, StaffName from Staff");
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            con.Close();
            return dt;
        }

        public InventoryReceivingVoucherDTO getIRVById(string id)
        {
            InventoryReceivingVoucherDTO irv = new InventoryReceivingVoucherDTO();
            SqlConnection con = DatabaseHelper.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.InventoryReceivingVoucher where Re_Id = '" + id + "'";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                irv.Id = reader["Re_Id"].ToString();
                irv.Date = Convert.ToDateTime(reader["Re_Date"]);
                irv.Total = double.Parse(reader["Total"].ToString());
                irv.StafId = reader["StaffId"].ToString();
                irv.SupplierId = reader["SupplierId"].ToString();
                irv.Paid = double.Parse(reader["Paid"].ToString());
            }
            reader.Close();
            con.Close();
            return irv;
        }

        public bool insertIRV(InventoryReceivingVoucherDTO irv, List<InventoryReceivingVoucherDetailDTO> listIRVD)
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

                //Thêm PN
                cmd.CommandText = "insert into InventoryReceivingVoucher (Re_Date, Total, StaffId, SupplierId, Paid) values (@date, @total, @staff, @supplier, 0)";
                cmd.Parameters.AddWithValue("@date", irv.Date);
                cmd.Parameters.AddWithValue("@total", irv.Total);
                cmd.Parameters.AddWithValue("@staff", irv.StafId);
                cmd.Parameters.AddWithValue("@supplier", irv.SupplierId);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "select top(1) Re_Id from InventoryReceivingVoucher order by Id desc";
                SqlDataReader reader = cmd.ExecuteReader();
                string reId = "";
                while (reader.Read())
                {
                    reId = reader[0].ToString();
                }
                reader.Close();

                //Thêm Detail
                cmd.CommandText = "insert into InventoryReceivingVoucherDetail values ";
                for (int i = 0; i < listIRVD.Count; i++)
                {
                    InventoryReceivingVoucherDetailDTO IRVDetail = listIRVD[i];
                    cmd.CommandText += $"('{reId}', '{IRVDetail.Product_ID}', {IRVDetail.Quantity}, {IRVDetail.UnitPrice})";
                    if (i < listIRVD.Count - 1)
                    {
                        cmd.CommandText += ", ";
                    }
                }
                cmd.ExecuteNonQuery();

                //Cập nhật lại số lượng tồn kho của sản phẩm
                for (int i = 0; i < listIRVD.Count; i++)
                {
                    InventoryReceivingVoucherDetailDTO IRVDetail = listIRVD[i];
                    cmd.CommandText = $"update Product set Quantity = Quantity + {IRVDetail.Quantity} where ProductId = '{IRVDetail.Product_ID}'";
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (SqlException)
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

        public int updateIRV(InventoryReceivingVoucherDTO irv, List<InventoryReceivingVoucherDetailDTO> listIRVD)
        {
            int result = 1;
            DataTable irvDetails = new InventoryReceivingVoucherDetailDAO().getAllInventoryReceivingVoucherDetailById(irv.Id);
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

                //cap nhat thong tin phieu nhap
                cmd.CommandText = "update InventoryReceivingVoucher set Re_Date = @Date, Total = @Total, StaffId = @StaffId, SupplierId = @SupplierId where Re_Id = @Id";
                cmd.Parameters.AddWithValue("@Date", irv.Date);
                cmd.Parameters.AddWithValue("@Total", irv.Total);
                cmd.Parameters.AddWithValue("@StaffId", irv.StafId);
                cmd.Parameters.AddWithValue("@SupplierId", irv.SupplierId);
                cmd.Parameters.AddWithValue("@Id", irv.Id);
                cmd.ExecuteNonQuery();

                //cap nhat lai detail (xoa detail cu va them lai detail moi)

                //tru sl sp
                foreach (DataRow row in irvDetails.Rows)
                {
                    cmd.CommandText = "update Product set Quantity = Quantity - " + row["Quantity"].ToString() + " where ProductId = '" + row["ProductId"].ToString() + "'";
                    cmd.ExecuteNonQuery();
                }

                //xoa chi tiet cu
                cmd.CommandText = "delete from InventoryReceivingVoucherDetail where Re_Id = '" + irv.Id + "'";
                cmd.ExecuteNonQuery();


                //them lai chi tiet moi
                cmd.CommandText = "insert into InventoryReceivingVoucherDetail values ";
                for (int i = 0; i < listIRVD.Count; i++)
                {
                    InventoryReceivingVoucherDetailDTO IRVDetail = listIRVD[i];
                    cmd.CommandText += $"('{irv.Id}', '{IRVDetail.Product_ID}', {IRVDetail.Quantity})";
                    if (i < listIRVD.Count - 1)
                    {
                        cmd.CommandText += ", ";
                    }
                }
                cmd.ExecuteNonQuery();

                //Cập nhật lại số lượng tồn kho của sản phẩm
                for (int i = 0; i < listIRVD.Count; i++)
                {
                    InventoryReceivingVoucherDetailDTO IRVDetail = listIRVD[i];
                    cmd.CommandText = $"update Product set Quantity = Quantity + {IRVDetail.Quantity} where ProductId = '{IRVDetail.Product_ID}'";
                    cmd.ExecuteNonQuery();
                }

                //kiem tra sau khi thay doi co sp nao bi am sl khong
                cmd.CommandText = "select COUNT(*) from Product where Quantity < 0";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (int.Parse(reader[0].ToString()) > 0)
                {
                    reader.Close();
                    transaction.Rollback();
                    return 2;
                }
                reader.Close();

                transaction.Commit();
            }
            catch (SqlException)
            {
                transaction.Rollback();
                result = 0;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int deleteIRV(string id)
        {
            int result = 1;
            DataTable irvDetails = new InventoryReceivingVoucherDetailDAO().getAllInventoryReceivingVoucherDetailById(id);
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

                string deleteDetail = "delete from InventoryReceivingVoucherDetail where Re_Id = '" + id + "'";
                string deletePaymentVoucher = " delete from PaymentVoucher where Re_Id = '" + id + "'";
                string deleteIRV = " delete from InventoryReceivingVoucher where Re_Id = '" + id + "'";

                foreach (DataRow row in irvDetails.Rows)
                {
                    cmd.CommandText = "update Product set Quantity = Quantity - " + row["Quantity"].ToString() + " where ProductId = '" + row["ProductId"].ToString() + "'";
                    cmd.ExecuteNonQuery();
                }

                cmd.CommandText = "select COUNT(*) from Product where Quantity < 0";
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (int.Parse(reader[0].ToString()) > 0)
                {
                    reader.Close();
                    transaction.Rollback();
                    return 2;
                }
                reader.Close();

                cmd.CommandText = deleteDetail + deletePaymentVoucher + deleteIRV;
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (SqlException)
            {
                transaction.Rollback();
                result = 0;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}
