using System;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class SupplierBUS
    {
        private DataTable supplierList;
        private SupplierDAO supplierDAO;
        public DataTable SupplierList { set => this.supplierList = value; get => this.supplierList; }
        public SupplierDAO SupplierDAO { get => supplierDAO; set => supplierDAO = value; }
        public SupplierBUS()
        {
            this.supplierDAO = new SupplierDAO();
            supplierList = this.SupplierDAO.getAllSupplier();
        }
        public void resetSupplierList()
        {
            this.supplierList = this.SupplierDAO.getAllSupplier();
        }
        public SupplierDTO getSupplier(string supplierId)
        {
            SupplierDTO supplier = null;
            for (int i = 0; i < this.supplierList.Rows.Count; i++)
            {
                DataRow dr = this.supplierList.Rows[i];
                if (dr["supplierId"].ToString() == supplierId)
                {
                    string supplierName = dr["SupplierName"].ToString();
                    string gender = dr["Gender"].ToString();
                    string phone = dr["NumberPhone"].ToString();
                    string address = dr["SupplierAddress"].ToString();
                    bool status = bool.Parse(dr["StatusItem"].ToString());

                    supplier = new SupplierDTO(supplierId, supplierName, address, phone, status);
                    break;
                }
            }
            return supplier;
        }
        public DataTable formatDataTableToShowUi(DataTable dtSupplier)
        {
            DataTable newDataTable = new DataTable();
            for (int i = 0; i < dtSupplier.Columns.Count; i++)
            {
                DataColumn col = dtSupplier.Columns[i];
                newDataTable.Columns.Add(col.ColumnName);
            }
            for (int i = 0; i < dtSupplier.Rows.Count; i++)
            {
                DataRow dr = dtSupplier.Rows[i];
                DataRow newRow = newDataTable.NewRow();
                newRow[0] = dr[0];
                newRow[1] = dr[1];
                newRow[2] = dr[2];
                newRow[3] = dr[3];
                newRow[4] = Boolean.Parse(dr[4].ToString()) ? "Hoạt động" : "Không hoạt động";
                newDataTable.Rows.Add(newRow);
            }
            return newDataTable;
        }
        public string updateSupplier(SupplierDTO supplierDTO)
        {
            if (SupplierDAO.updateSupplier(supplierDTO))
            {
                this.resetSupplierList();
                return "Nhà cung cấp đã được sửa vào database!";
            }
            return "Đã có lỗi xảy ra trong quá trình sửa nhà cung cấp!";
        }
        public string insertSupplier(SupplierDTO newSupplier)
        {
            if (SupplierDAO.insertSupplier(newSupplier))
            {
                this.resetSupplierList();
                return "Nhà cung cấp đã được thêm vào database!";
            }
            return "Đã có lỗi xảy ra trong quá trình thêm nhà cung cấp!";
        }
        public DataTable getSupplierSearchList(string name, string phone)
        {
            return SupplierDAO.getSupplierSearchList(name, phone);
        }
        public bool checkUniquePhoneAdd(string phone)
        {
            if (SupplierDAO.checkPhoneUniqueAdd(phone) == "true")
            {
                return true;
            }
            return false;
        }
        public bool checkUniquePhoneUpdate(string supplierId,string phone)
        {
            if (SupplierDAO.checkPhoneUniqueUpdate(supplierId, phone) == "true")
            {
                return true;
            }
            return false;
        }
    }
}
