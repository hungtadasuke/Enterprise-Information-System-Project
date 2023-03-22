using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class ProductBUS
    {
        //Đối tượng productDAO
        private ProductDAO productDAO;
        //DataTable lưu trữ danh sách sản phẩm đầy đủ từ lớp DAO để tối ưu hóa code
        private DataTable productListFull;
        //DataTable lưu trữ danh sách sản phẩm đang kinh doanh từ lớp DAO để tối ưu hóa code
        private DataTable productListTrue;
        //DataTable lưu trữ danh sách nhóm hàng
        private DataTable categoryList;
        //DataTable lưu trữ danh sách đơn vị sản phẩm
        private DataTable productUnitList;
        //DataTable lưu trữ danh sách tìm kiếm sản phẩm để bán theo thể loại
        private DataTable productSearchListToSell;

        //properties
        public ProductDAO ProductDAO { get => productDAO; set => productDAO = value; }
        public DataTable ProductListFull { get => productListFull; set => productListFull = value; }
        public DataTable ProductListTrue { get => productListTrue; set => productListTrue = value; }
        public DataTable CategoryList { get => categoryList; set => categoryList = value; }
        public DataTable ProductUnitList { get => productUnitList; set => productUnitList = value; }
        public DataTable ProductSearchListToSell { get => productSearchListToSell; set => productSearchListToSell = value; }

        public ProductBUS()
        {
            ProductDAO = new ProductDAO();
            ProductListFull = ProductDAO.getAllProduct();
            ProductListTrue = ProductDAO.getAllProductTrue();
            CategoryList = ProductDAO.getAllCategory();
            ProductUnitList = ProductDAO.getAllProductUnit();
            ProductSearchListToSell = ProductListTrue;
        }

        //Hàm format datatable sản phẩm thành một datatable hoàn chỉnh đã format giá tiền
        //Input: datatabse nguyên bản
        //Output: datatable đã format price
        public DataTable formatDataTableToShowUi(DataTable dt)
        {
            DataTable newDataTable = new DataTable();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                DataColumn col = dt.Columns[i];
                newDataTable.Columns.Add(col.ColumnName);
            }
            //DÒNG CODE NÀY LÀ IMPORTANT SET COLUMN "PRODUCTIMG" THÀNH DẠNG CÓ THỂ HIỂN THỊ HÌNH ẢNH RA DATAGRIDVIEW
            newDataTable.Columns["ProductImg"].DataType = System.Type.GetType("System.Byte[]");
            newDataTable.Columns["PriceToSell"].DataType = System.Type.GetType("System.Double");
            newDataTable.Columns["ImportPrice"].DataType = System.Type.GetType("System.Double");
            newDataTable.Columns["Quantity"].DataType = System.Type.GetType("System.Int32");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                DataRow newRow = newDataTable.NewRow();
                newRow[0] = dr[0];
                newRow[1] = dr[1];
                newRow[2] = dr[2];
                newRow[3] = dr[3];
                newRow[4] = dr[4];
                newRow[5] = dr[5];
                newRow[6] = dr[6];
                newRow[7] = dr[7];
                newRow[8] = Boolean.Parse(dr[8].ToString()) ? "Bán" : "Ngừng Bán";
                newDataTable.Rows.Add(newRow);
            }
            return newDataTable;
        }

        //Hàm lấy một newProductId của sản phẩm sắp tạo để hiển thị
        //Input: none
        //Output: newProductId
        public String getNewProductId()
        {
            if(this.ProductListFull.Rows.Count == 0)
            {
                return "PR0001";
            }
            DataRow dr = this.ProductListFull.Rows[this.ProductListFull.Rows.Count - 1];
            int Id = int.Parse(dr[1].ToString().Split('R')[1]) + 1;
            return "PR" + String.Format("000" + Id).Substring(String.Format("000" + Id).Length - 4, 4);
        }

        //Hàm lấy categoryId khi truyền vào categoryName
        //Input: categoryName
        //Output: null/categoryId
        public string getCategoryId(string categoryName)
        {
            for(int i = 0; i < this.CategoryList.Rows.Count; i++)
            {
                DataRow dr = this.CategoryList.Rows[i];
                if (dr[1].ToString() == categoryName)
                {
                    return dr[0].ToString();
                }
            }
            return null;
        }

        //Hàm gọi hàm thêm một product vào database từ DAO
        //Input: ProductDTO lấy từ GUI
        //Output: giá trị bool nhận từ DAO
        public string insertProduct(ProductDTO newProduct)
        {
            if(ProductDAO.insertProduct(newProduct))
            {
                this.resetProductListFull();
                return "Sản phẩm đã được thêm vào database!";
            }
            return "Đã có lỗi xảy ra trong quá trình thêm sản phẩm!";
        }

        //Hàm gọi hàm sửa một sản phẩm trong database từ DAO
        //Input: ProductDTO lấy từ GUI
        //Output: giá trị bool nhận từ DAO
        public string updateProduct(ProductDTO productDTO)
        {
            if(ProductDAO.updateProduct(productDTO))
            {
                this.resetProductListFull();
                return "Sản phẩm đã được sửa vào database!";
            }
            return "Đã có lỗi xảy ra trong quá trình sửa sản phẩm!";
        }

        //Hàm reset lại productListFull
        //Input: none
        //Output: productListFull đã reset
        private void resetProductListFull()
        {
            ProductListFull = ProductDAO.getAllProduct();
        }

        //Hàm gọi đến hàm lấy danh sách search product của lớp DAO từ những thuộc tính truyền vào ở lớp GUI
        //Input: CategoryId, Unit, Name, PriceFrom, PriceTo
        //Output: null/productSearchListResult
        public DataTable getProductSearchList(string categoryId, string unit, string name, double priceFrom, double priceTo)
        {
            return ProductDAO.getProductSearchList(categoryId, unit, name, priceFrom, priceTo);
        }

        //Hàm  reset lại danh sách tìm kiếm sản phẩm để bán phục vụ cho việc tìm kiếm theo keyWord
        //Input: string[] có phần tử
        //Output: null/danh sách sản phẩm search
        public void resetProductSearchListToSell(List<string> categoryNameList)
        {
            if(categoryNameList.Count == this.CategoryList.Rows.Count || categoryNameList.Count == 0)
            {
                this.ProductSearchListToSell = this.ProductListTrue;
            } else
            {
                this.ProductSearchListToSell = this.getProductSearchListToSell(categoryNameList);
            }
        }

        //Hàm trả về danh sách tìm kiếm sản phẩm khi truyền vào productNameKey
        //Tìm kiếm dựa trên danh sách sản phẩm dựa trên danh sách đã lọc theo category
        //Input: productNameKey
        //Output: productSearchList
        public DataTable getProductSearchListToSell(string productNameKey)
        {
            DataTable dtProductSearchListToSell = new DataTable();
            for(int i = 0; i < this.ProductListTrue.Columns.Count; i++)
            {
                dtProductSearchListToSell.Columns.Add(this.ProductListTrue.Columns[i].ColumnName);
            }
            dtProductSearchListToSell.Columns["ProductImg"].DataType = System.Type.GetType("System.Byte[]");
            for (int i = 0; i < this.ProductSearchListToSell.Rows.Count; i++)
            {
                DataRow dr = this.ProductSearchListToSell.Rows[i];
                if (dr[2].ToString().ToLower().Contains(productNameKey.ToLower()))
                {
                    DataRow newRow = dtProductSearchListToSell.NewRow();
                    newRow[0] = dr[0];
                    newRow[1] = dr[1];
                    newRow[2] = dr[2];
                    newRow[3] = dr[3];
                    newRow[4] = dr[4];
                    newRow[5] = dr[5];
                    newRow[6] = dr[6];
                    newRow[7] = dr[7];
                    newRow[8] = dr[8];
                    dtProductSearchListToSell.Rows.Add(newRow);
                }

            }
            return dtProductSearchListToSell;
        }

        //Hàm lấy danh sách sản phẩm search cho trang bán hàng theo các category (sản phẩm đang kinh doanh)
        //Input: string[] category name có phần tử
        //Output: null/danh sách sản phẩm search
        private DataTable getProductSearchListToSell(List<string> categoryNameList)
        {
            DataTable dtProductSearchListToSell = new DataTable();
            for(int i = 0; i < this.ProductListTrue.Columns.Count; i++)
            {
                DataColumn col = this.ProductListTrue.Columns[i];
                dtProductSearchListToSell.Columns.Add(col.ColumnName);
            }
            dtProductSearchListToSell.Columns["ProductImg"].DataType = System.Type.GetType("System.Byte[]");
            for (int i = 0; i < this.ProductListTrue.Rows.Count; i++)
            {
                DataRow dr = this.ProductListTrue.Rows[i];
                if(this.checkCategoryName(categoryNameList, dr[0].ToString()))
                {
                    DataRow newRow = dtProductSearchListToSell.NewRow();
                    newRow[0] = dr[0];
                    newRow[1] = dr[1];
                    newRow[2] = dr[2];
                    newRow[3] = dr[3];
                    newRow[4] = dr[4];
                    newRow[5] = dr[5];
                    newRow[6] = dr[6];
                    newRow[7] = dr[7];
                    newRow[8] = dr[8];
                    dtProductSearchListToSell.Rows.Add(newRow);
                }
                
            }
            return dtProductSearchListToSell;
        }

        //Hàm check sự tồn tại của một categoryName trong một categoryNameList
        private bool checkCategoryName(List<string> categoryNameList, string categoryName)
        {
            for(int i = 0; i < categoryNameList.Count; i++)
            {
                if(categoryNameList[i].Equals(categoryName))
                {
                    return true;
                }
            }
            return false;
        }

        //Hàm reset lại productSearchListTrue
        public void resetProductSearchList()
        {
            this.ProductListTrue = productDAO.getAllProductTrue();
            this.ProductSearchListToSell = this.ProductListTrue;
        }

        //Hàm lấy một product đang kinh doanh khi truyền vào productId
        public ProductDTO getProduct(string productId)
        {
            ProductDTO product = null;
            for(int i = 0; i < this.ProductListTrue.Rows.Count; i++)
            {
                DataRow dr = this.ProductListTrue.Rows[i];
                if (dr[1].ToString().Equals(productId))
                {
                    string productName = dr["ProductName"].ToString();
                    string unit = dr["Unit"].ToString();
                    double importPrice = double.Parse(dr["ImportPrice"].ToString());
                    double priceToSell = double.Parse(dr["PriceToSell"].ToString());
                    int quantity = int.Parse(dr["Quantity"].ToString());
                    byte[] productImg = (byte[]) dr["ProductImg"];
                    bool statusItem = bool.Parse(dr["StatusItem"].ToString());
                    string categoryId = this.getCategoryId(dr["CategoryName"].ToString().Trim());
                    product = new ProductDTO(productId, productName, productImg, unit, quantity, importPrice, priceToSell, categoryId, statusItem);
                    break;
                }
            }
            return product;
        }
    }
}
