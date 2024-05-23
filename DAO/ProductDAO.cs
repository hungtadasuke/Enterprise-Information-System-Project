using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ProductDAO
    {
        //Hàm lấy danh sách sản phẩm từ database
        //Input: none
        //Output: null/một đối tượng datatable lưu trữ danh sách sản phẩm.
        public DataTable getAllProduct()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("getProductList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            } catch (SqlException)
            {
                return null;
            } finally
            {
                con.Close();
            }
            return dt;
        }

        //Hàm lấy danh sách nhóm hàng từ database
        //Input: none
        //Output: null/datable lưu trữ danh sách nhóm hàng
        public DataTable getAllCategory()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select CategoryId, CategoryName, StatusItem from Category", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            } catch (SqlException)
            {
                return null;
            } finally
            {
                con.Close();
            }
            return dt;
        }

        //Hàm lấy danh sách đơn vị sản phẩm lên từ database
        //Input: none
        //Output: null/datatable lưu trữ danh sách đơn vị sản phẩm
        public DataTable getAllProductUnit()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct Unit from Product", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            } catch (SqlException)
            {
                return null;
            } finally
            {
                con.Close();
            }
            return dt;
        }

        //Hàm thêm một sản phẩm mới vào database
        //Input: ProductDTO truyền từ ProductBUS
        //Output: true/false
        public bool insertProduct(ProductDTO newProductDTO)
        {
            bool commit = false;
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("insertProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductImg", newProductDTO.ProductImg);
                cmd.Parameters.AddWithValue("@ProductName", newProductDTO.ProductName);
                cmd.Parameters.AddWithValue("@ImportPrice", newProductDTO.ImportPrice);
                cmd.Parameters.AddWithValue("@PriceToSell", newProductDTO.PriceToSell);
                cmd.Parameters.AddWithValue("@Unit", newProductDTO.Unit);
                cmd.Parameters.AddWithValue("@Quantity", newProductDTO.Quantity);
                cmd.Parameters.AddWithValue("@StatusItem", newProductDTO.StatusItem);
                cmd.Parameters.AddWithValue("@CategoryId", newProductDTO.CategoryId);
                con.Open();
                cmd.ExecuteNonQuery();
                commit = true;
            } catch (SqlException e)
            {
                Console.WriteLine(e);
                commit = false;
            } finally
            {
                con.Close();
            }
            return commit;
        }

        //Hàm sửa sản phẩm vào database
        //Input: ProductDTO
        //Output: true/false
        public bool updateProduct(ProductDTO productDTO)
        {
            bool commit = false;
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("updateProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", productDTO.ProductName);
                cmd.Parameters.AddWithValue("@ProductImg", productDTO.ProductImg);
                cmd.Parameters.AddWithValue("@ImportPrice", productDTO.ImportPrice);
                cmd.Parameters.AddWithValue("@PriceToSell", productDTO.PriceToSell);
                cmd.Parameters.AddWithValue("@Unit", productDTO.Unit);
                cmd.Parameters.AddWithValue("@Quantity", productDTO.Quantity);
                cmd.Parameters.AddWithValue("@StatusItem", productDTO.StatusItem);
                cmd.Parameters.AddWithValue("@CategoryId",  productDTO.CategoryId);
                cmd.Parameters.AddWithValue("@ProductId", productDTO.ProductId);
                con.Open();
                cmd.ExecuteNonQuery();
                commit = true;
            } catch(SqlException)
            {
                commit = false;
            } finally
            {
                con.Close();
            }
            return commit;
        }

        //Hàm search Product
        //Input: CategoryId, Unit, Name, PriceFrom, PriceTo
        //Output: null/productSearchListResult
        public DataTable getProductSearchList(string categoryId, string unit, string name, double priceFrom, double priceTo)
        {
            string querryProductSearchList = $"select C.CategoryName, P.ProductId,  P.ProductName, P.Unit, P.ImportPrice, P.PriceToSell, P.Quantity, P.ProductImg, P.StatusItem from Product as P, Category as C where P.CategoryId = C.CategoryId";
            string conditionCategoryId = $" and  P.CategoryId = '{categoryId}'";
            string conditionUnit = $" and P.Unit = N'{unit}'";
            string conditionProductName = $" and P.ProductName like N'%{name}%'";
            string conditionPriceToSell = $" and P.PriceToSell between {priceFrom} and {priceTo}";

            if(categoryId != "")
            {
                querryProductSearchList += conditionCategoryId;
            }
            if(unit != "")
            {
                querryProductSearchList += conditionUnit;
            }
            if(name != "")
            {
                querryProductSearchList += conditionProductName;
            }
            //Trường hợp priceTo và priceFrom người dùng có nhập vào số hợp lệ
            if(priceFrom != -1 && priceTo != -1)
            {
                querryProductSearchList += conditionPriceToSell;
            }
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querryProductSearchList, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            } catch (SqlException)
            {
                return null;
            } finally
            {
                con.Close();
            }
            return dt;
        }

        //Hàm lấy danh sách sản phẩm đang kinh doanh từ database
        //Input: none
        //Output: null/ột đối tượng datatable lưu trữ danh sách sản phẩm đang kinh doanh
        public DataTable getAllProductTrue()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select C.CategoryName, P.ProductId,  P.ProductName, P.Unit, P.ImportPrice, P.PriceToSell, P.Quantity, P.ProductImg, P.StatusItem, P.Barcode from Product as P, Category as C where P.CategoryId = C.CategoryId and P.StatusItem = 1;", con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            } catch (SqlException)
            {
                return null;
            } finally
            {
                con.Close();
            }
            return dt;
        }

        //Hàm cập nhật số tượng sản phẩm tồn kho khi xóa một chi tiết bill
        //Input: danh sách chi tiết Bill
        //Output: true/false
        public bool updateProductQuantityWhenDeteleBillDetail(List<BillDetailDTO> listBillDetail)
        {
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                foreach(BillDetailDTO detail in listBillDetail)
                {
                    cmd.CommandText = $"update Product set Quantity = Quantity + {detail.Quantity} where ProductId = '{detail.ProductId}'";
                    cmd.ExecuteNonQuery();
                }
            } catch (SqlException)
            {
                return false;
            } finally
            {
                con.Close();
            }
            return true;
        }

        //Hàm lấy danh sách sản phẩm search cho trang bán hàng theo các category (sản phẩm đang kinh doanh)
        //Input: string[] có phần tử
        //Output: null/danh sách sản phẩm search
       /* public DataTable getProductSearchListForSell(List<string> categoryNameList)
        {
            string querryProductSearchPrimary = "select C.CategoryName, P.ProductId,  P.ProductName, P.Unit, P.ImportPrice, P.PriceToSell, P.Quantity, P.ProductImg, P.StatusItem from Product as P, Category as C where P.CategoryId = C.CategoryId and P.StatusItem = 1";
            querryProductSearchPrimary += " and (";
            for(int i = 0; i < categoryNameList.Count;)
            {
                querryProductSearchPrimary += $"C.CategoryName = N\'{categoryNameList[i]}\'";
                if(i == categoryNameList.Count - 1)
                {
                    querryProductSearchPrimary += ");";
                    break;
                } else
                {
                    querryProductSearchPrimary += " or ";
                    i++;
                }
            }
            SqlConnection con = DatabaseHelper.getConnection();
            DataTable dtProductSearchList = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querryProductSearchPrimary, con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dtProductSearchList);
            } catch (SqlException)
            {
                return null;
            } finally
            {
                con.Close();
            }
            con.Close();
            return dtProductSearchList;
        }*/
    }
}
