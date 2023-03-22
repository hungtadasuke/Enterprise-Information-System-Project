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
    public class StaffBUS
    {
        public StaffDAO staffDAO;
        public StaffDTO staffDTO;

        public StaffBUS()
        {
            staffDAO = new StaffDAO();
        }

        //Hàm lấy datatable staff lên từ lớp StaffDAO
        public DataTable getAllStaff(string position, string gender, string keyWords)
        {
            DataTable dataTable = new DataTable();
            foreach (DataColumn c in staffDAO.getAllStaff().Columns)
            {
                dataTable.Columns.Add(c.ColumnName);
            }
            foreach (DataRow r in staffDAO.getAllStaff().Rows)
            {
                if (position == "Tất cả")
                {
                    DataRow nr = dataTable.NewRow();
                    nr[0] = r[0];
                    nr[1] = r[1];
                    nr[2] = r[2];
                    //nr[3] = r[3];
                    nr[3] = r[3].ToString().Split(' ')[0];
                    nr[4] = r[4];
                    nr[5] = r[5];
                    nr[6] = r[6];
                    nr[7] = bool.Parse(r[7].ToString()) ? "Hoạt động" : "Không hoạt động";
                    dataTable.Rows.Add(nr);
                }
                else if (r[6].Equals(position))
                {
                    DataRow nr = dataTable.NewRow();
                    nr[0] = r[0];
                    nr[1] = r[1];
                    nr[2] = r[2];
                    //nr[3] = r[3];
                    nr[3] = r[3].ToString().Split(' ')[0];
                    nr[4] = r[4];
                    nr[5] = r[5];
                    nr[6] = r[6];
                    nr[7] = bool.Parse(r[7].ToString()) ? "Hoạt động" : "Không hoạt động";
                    dataTable.Rows.Add(nr);
                }
            }
            dataTable.AcceptChanges();

            foreach (DataRow r in dataTable.Rows)
            {
                if (gender != "" || !string.IsNullOrWhiteSpace(keyWords))
                {
                    bool checkKeywords = (!r[1].ToString().ToLower().Contains(keyWords.ToLower()));
                    bool checkGender = (gender != r[2].ToString()) && (gender != "");
                    if (checkKeywords || checkGender)
                    {
                        r.Delete();
                    }
                }
                else
                    break;
            }

            return dataTable;
        }

        //
        public DataTable getAllPosition()
        {
            return staffDAO.getAllPosition();
        }

        public DataTable getAllID()
        {
            return staffDAO.getAllID();
        }

        public bool addStaff(string StaffName, string Gender, string Birthday, string NumberPhone, string AddressNow, string Position, bool StatusItem)
        {
            return staffDAO.addStaff(StaffName, Gender, Birthday, NumberPhone, AddressNow, Position, StatusItem);
        }

        public bool editStaff(string StaffName, string Gender, string Birthday, string NumberPhone, string AddressNow, string Position, bool StatusItem, string StaffID)
        {
            return staffDAO.editStaff(StaffName, Gender, Birthday, NumberPhone, AddressNow, Position, StatusItem, StaffID);
        }

        public StaffDTO GetStaffDTO(string staffId)
        {
            StaffBUS staffBUS = new StaffBUS();
            DataTable staff = staffBUS.getAllStaff("Tất cả", "", "");
            foreach (DataRow dr in staff.Rows)
            {
                if (dr[0].ToString() == staffId)
                {
                    StaffDTO staffDTO = new StaffDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), DateTime.Parse(dr[3].ToString()), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), bool.Parse(dr[7].ToString()));
                    return staffDTO;
                }
            }
            return null;
        }

        public StaffDTO getStaffById(string id)
        {
            return StaffDAO.getStaffById(id);
        }
    }
}