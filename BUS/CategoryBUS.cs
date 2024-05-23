using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CategoryBUS
    {
        public CategoryDAO categoryDAO;

        public CategoryBUS()
        {
            categoryDAO = new CategoryDAO();
        }

        //Hàm lấy datatable login account lên từ lớp LoginDAO
        public DataTable getAllCategory()
        {
            DataTable dataTable = new DataTable();
            foreach (DataColumn c in categoryDAO.getAllCategory().Columns)
            {
                dataTable.Columns.Add(c.ColumnName);
            }
            foreach (DataRow r in categoryDAO.getAllCategory().Rows)
            {
                DataRow nr = dataTable.NewRow();
                nr[0] = r[0];
                nr[1] = r[1];
                nr[2] = bool.Parse(r[2].ToString()) ? "Kinh doanh" : "Ngừng kinh doanh";
                dataTable.Rows.Add(nr);
            }
            return dataTable;
        }

        public bool addCategory(string categoryName, bool statusItems)
        {
            return categoryDAO.addCategory(categoryName, statusItems);
        }

        public bool editCategory(string categoryName, bool statusItems, string categoryId)
        {
            return categoryDAO.editCategory(categoryName, statusItems, categoryId);
        }

        public bool checkTrung(string categoryName)
        {
            var flag = false;
            DataTable dataName = categoryDAO.getAllCategoryName();
            foreach (DataRow dr in dataName.Rows)
            {
                if (categoryName == dr[0].ToString())
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        /*public DataTable searchCategory(string str)
        {
            //bool flag = false;
            CategoryBUS categoryBUS = new CategoryBUS();
            DataTable dataCategory = categoryBUS.getAllCategory();
            DataTable newCategory = new DataTable();
            foreach (DataRow dr in dataCategory.Rows)
            {
                if (dr[1].ToString().Contains(str))
                {
                    newCategory.Rows.Add(dr);
                    //flag = true;
                    return newCategory;
                }
            }
            return null;
        }*/
    }
}