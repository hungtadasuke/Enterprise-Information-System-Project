using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class BillDAO
    {
        //Hàm lấy danh sách bill lên từ database
        //Input: none
        //Output: null/datatable
        public DataTable getAllBill()
        {
            DataTable dtAllBill = new DataTable();
            SqlConnection con = DatabaseHelper.getConnection();
            SqlCommand cmd = new SqlCommand($"select BillId, isnull(CustomerName,'') as CustomerName ,StaffId, BillDate, Discount, Total from Bill  left join Customer on Bill.CustomerId = Customer.CustomerId", con);
            try
            {
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dtAllBill);
            }
            catch (SqlException)
            {
                dtAllBill = null;
            }
            finally
            {
                con.Close();
            }
            return dtAllBill;
        }
        public DataTable getBill(string dateForm, string dateTo)
        {
            DataTable dtAllBill = new DataTable();
            SqlConnection con = DatabaseHelper.getConnection();
            SqlCommand cmd = new SqlCommand($"select BillId, isnull(CustomerName,'') as CustomerName ,StaffId, BillDate, Discount, Total from Bill  left join Customer on Bill.CustomerId = Customer.CustomerId where BillDate between '{dateForm}' and '{dateTo}'", con);
            try
            {
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dtAllBill);
            }
            catch (SqlException)
            {
                dtAllBill = null;
            }
            finally
            {
                con.Close();
            }
            return dtAllBill;
        }
        public DataTable getAllBillOfHung()
        {
            DataTable dtAllBill = new DataTable();
            SqlConnection con = DatabaseHelper.getConnection();
            SqlCommand cmd = new SqlCommand("select BillId, BillDate, Discount, Total, StaffId, CustomerId from Bill", con);
            try
            {
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dtAllBill);
            }
            catch (SqlException)
            {
                dtAllBill = null;
            }
            finally
            {
                con.Close();
            }
            return dtAllBill;
        }
        //Hàm lấy danh sách billdetail lên từ database
        //Input: none
        //Output: null/datatable
        public DataTable getBillDetail(string BillId)
        {
            DataTable dtBillDetail = new DataTable();
            SqlConnection con = DatabaseHelper.getConnection();
            SqlCommand cmd = new SqlCommand($"select bd.ProductID,p.ProductName,bd.Quantity,p.PriceToSell,p.PriceToSell*bd.Quantity as Total from BillDetail bd, Product p where bd.ProductID=p.ProductID AND BillId = '{BillId}'", con);
            try
            {
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dtBillDetail);
            }
            catch (SqlException)
            {
                dtBillDetail = null;
            }
            finally
            {
                con.Close();
            }
            return dtBillDetail;
        }

        //Hàm thêm một hóa đơn + list<chi tiết hóa đơn> vào cơ sở dữ liệu, đồng thời cập nhật lại số điểm của khách hàng (nếu có) và số lượng tồn kho của sản phẩm
        //Input: BillDTO, List<BillDetailDTO>, point of customer
        //Output: true/false
        public bool insertBill(BillDTO bill, List<BillDetailDTO> billDetailList, int point)
        {
            var success = true;
            //Tạo kết nối
            SqlConnection con = DatabaseHelper.getConnection();
            //Tạo đối tượng thực thi câu lệnh
            SqlCommand cmd = new SqlCommand();
            //Tạo đối tượng transaction
            SqlTransaction transaction = null;
            try
            {
                //Mở kết nối
                con.Open();
                //tạo đối tượng begin transaction
                transaction = con.BeginTransaction();

                //Khai báo những thông số cơ bản của đối tượng SqlCommand
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Transaction = transaction;

                //Thêm bill
                cmd.CommandText = (bill.CustomerId == null) ?
                                $"insert into Bill values (@billDate, @discount, @total, @staffId, null)"
                                : $"insert into Bill values (@billDate, @discount, @total, @staffId, '{bill.CustomerId}')";
                cmd.Parameters.AddWithValue("@billDate", bill.BillDate);
                cmd.Parameters.AddWithValue("@discount", bill.Discount);
                cmd.Parameters.AddWithValue("@total", bill.Total);
                cmd.Parameters.AddWithValue("@staffId", bill.StaffId);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "select top(1) billId from Bill order by Id desc";
                SqlDataReader reader = cmd.ExecuteReader();
                string billId = "";
                while(reader.Read()) 
                {
                    billId = reader[0].ToString();
                }
                reader.Close();


                //Thêm billDetail
                /*cmd.CommandText = "insert into BillDetail values ";*/
                for (int i = 0; i < billDetailList.Count; i++)
                {
                    BillDetailDTO billDetail = billDetailList[i];
                    cmd.CommandText = $"insert into BillDetail values ('{billId}', '{billDetail.ProductId}', {billDetail.Quantity}, {billDetail.UnitPrice});";
                    /*if (i < billDetailList.Count - 1)
                    {
                        cmd.CommandText += ", ";
                    }*/
                    cmd.ExecuteNonQuery();
                }

                //Cập nhật lại số lượng tồn kho của sản phẩm
               /* for (int i = 0; i < billDetailList.Count; i++)
                {
                    BillDetailDTO detailBill = billDetailList[i];
                    cmd.CommandText = $"update Product set Quantity = Quantity - {detailBill.Quantity} where ProductId = '{detailBill.ProductId}'";
                    cmd.ExecuteNonQuery();
                }*/

                //Nếu point khác -1 (tức đây là bill của khách hàng thành viên) thì cập nhập lại điểm số của khách hàng dựa vào customerId của bill truyền vào
                if (point != -1)
                {
                    cmd.CommandText = $"update Customer set point = {point} where CustomerId = '{bill.CustomerId}'";
                    cmd.ExecuteNonQuery();
                }

                //Nếu thành công thì commit tran
                transaction.Commit();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                //Nếu thất bại thì rollback tran
                transaction.Rollback();
                //Xét lại biến success = false
                success = false;
            }
            finally
            {
                //Đóng kết nối
                con.Close();
            }
            return success;
        }
        public DataTable getBillSearchList(string billId, double priceFrom, double priceTo,string dateForm,string dateTo)
        {
            string querryBillSearchList = $"select BillId, isnull(CustomerName,'') as CustomerName ,StaffId, BillDate, Discount, Total from Bill  left join Customer on Bill.CustomerId = Customer.CustomerId where BillDate between '{dateForm}' and '{dateTo}'";
            string conditionBillId = $" and BillId like N'%{billId}%'";
            string conditionTotal = $" and Total between {priceFrom} and {priceTo}";
            string conditionFrom = $" and Total > {priceFrom}";
            string conditionTo = $" and Total < {priceTo}";
            if (billId != "")
            {
                querryBillSearchList += conditionBillId;
            }
            if (priceFrom != -1 && priceTo != -1)
            {
                querryBillSearchList += conditionTotal;
            }
            if (priceFrom != -1 && priceTo == -1)
            {
                querryBillSearchList += conditionFrom;
            }
            if (priceFrom == -1 && priceTo != -1)
            {
                querryBillSearchList += conditionTo;
            }
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dtBill = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querryBillSearchList, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtBill);
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return dtBill;
        }
        public bool deleteBill(string BillId)
        {
            bool commit = false;
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"delete from Bill where BillId ='{BillId}'", con);
                SqlCommand cmd1 = new SqlCommand($"delete from BillDetail where BillId ='{BillId}'", con);
                con.Open();
                cmd1.ExecuteNonQuery();
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

        //getDetailBillToPrint Of Hung
        public DataTable getBillDetailToPrint(String billId)
        {
            DataTable dtBillDetail = new DataTable();
            SqlConnection con = DatabaseHelper.getConnection();
            SqlCommand cmd = new SqlCommand($"select * from BillDetail where BillId = '{billId}'", con);
            try
            {
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dtBillDetail);
            } catch (SqlException)
            {
                dtBillDetail = null;
            } finally
            {
                con.Close();
            }
            return dtBillDetail;
        }

    }
}
