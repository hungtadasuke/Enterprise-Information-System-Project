using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class CustomerBUS
    {
        //Fields
        //DataTable lưu trữ danh sách khách hàng
        private DataTable customerList;
        //CustomerDAO
        private CustomerDAO customerDAO;

        //Properties
        public DataTable CustomerList { set => this.customerList = value; get => this.customerList; }
        public CustomerDAO CustomerDAO { get => customerDAO; set => customerDAO = value; }

        //Constructor
        public CustomerBUS()
        {
            this.customerDAO = new CustomerDAO();
            customerList = this.CustomerDAO.getAllCustomer();
        }

        //Hàm reset customerList
        public void resetCustomerList()
        {
            this.customerList = this.CustomerDAO.getAllCustomer();
        }

        //Hàm truyền vào customerId và trả về một CustomerDTO tương ứng
        public CustomerDTO getCustomer(string customerId)
        {
            CustomerDTO customer = null;
            for(int i = 0; i < this.customerList.Rows.Count; i++)
            {
                DataRow dr = this.customerList.Rows[i];
                if (dr["customerId"].ToString() == customerId)
                {
                    string customerName = dr["CustomerName"].ToString();
                    string gender = dr["Gender"].ToString();
                    string phone = dr["NumberPhone"].ToString();
                    int point = int.Parse(dr["Point"].ToString());
                    bool status = bool.Parse(dr["StatusItem"].ToString());

                    customer = new CustomerDTO(customerId, customerName, gender, phone, point, status);
                    break;
                }
            }
            return customer;
        }
        public DataTable formatDataTableToShowUi(DataTable dtCustomer)
        {
            DataTable newDataTable = new DataTable();
            for (int i = 0; i < dtCustomer.Columns.Count; i++)
            {
                DataColumn col = dtCustomer.Columns[i];
                newDataTable.Columns.Add(col.ColumnName);
            }
            for (int i = 0; i < dtCustomer.Rows.Count; i++)
            {
                DataRow dr = dtCustomer.Rows[i];
                DataRow newRow = newDataTable.NewRow();
                newRow[0] = dr[0];
                newRow[1] = dr[1];
                newRow[2] = dr[2];
                newRow[3] = dr[3];
                newRow[4] = dr[4];
                newRow[5] = Boolean.Parse(dr[5].ToString()) ? "Hoạt động" : "Không hoạt động";
                newDataTable.Rows.Add(newRow);
            }
            return newDataTable;
        }
        public string updateCustomer(CustomerDTO customerDTO)
        {
            if (CustomerDAO.updateCustomer(customerDTO))
            {
                this.resetCustomerList();
                return "Khách hàng đã được sửa vào database!";
            }
            return "Đã có lỗi xảy ra trong quá trình sửa khách hàng!";
        }
        public string insertCustomer(CustomerDTO newCustomer)
        {
            if (CustomerDAO.insertCustomer(newCustomer))
            {
                this.resetCustomerList();
                return "Khách hàng đã được thêm vào database!";
            }
            return "Đã có lỗi xảy ra trong quá trình thêm khách hàng!";
        }
        public DataTable getCustomerSearchList(string gender, string name, string phone)
        {
            return CustomerDAO.getCustomerSearchList(gender, name, phone);
        }
        public bool checkUniquePhoneAdd(string phone)
        {
            if(CustomerDAO.checkPhoneUniqueAdd(phone)=="true")
            {
                return true;
            }
            return false;
        }
        public bool checkUniquePhoneUpdate(string customerId,string phone)
        {
            if (CustomerDAO.checkPhoneUniqueUpdate(customerId ,phone) == "true")
            {
                return true;
            }
            return false;
        }
    }
}
