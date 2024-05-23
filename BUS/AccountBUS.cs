using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class AccountBUS
    {
        public AccountDAO loginDAO;

        public AccountBUS()
        {
            loginDAO = new AccountDAO();
        }

        //Hàm lấy datatable login account lên từ lớp LoginDAO
        public DataTable getAllAccount()
        {
            return loginDAO.getAllAccount();
        }

        //Hàm lấy danh sách username từ DAO
        public DataTable getAllUsername()
        {
            return loginDAO.getAllUsername();
        }

        //Hàm lấy danh sách password từ DAO
        public DataTable getAllPassword()
        {
            return loginDAO.getAllPassword();
        }

        //check account
        public bool checkAccount(string username, string password)
        {
            bool flag = false;
            foreach (DataRow dtr in getAllAccount().Rows)
            {
                if (username == dtr.Field<string>(0) && password == dtr.Field<string>(1))
                    flag = true;
            }
            return flag;
        }

        public AccountDTO GetAccountDTO(string staffId)
        {
            AccountBUS accountBUS = new AccountBUS();
            DataTable accounts = accountBUS.getAllAccount();
            foreach (DataRow dr in accounts.Rows)
            {
                if (dr[2].ToString() == staffId)
                {
                    AccountDTO acc = new AccountDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), int.Parse(dr[3].ToString()), bool.Parse(dr[4].ToString()));
                    return acc;
                }
            }
            return null;
        }

        public AccountDTO GetAccountDTOByUserName(string userName)
        {
            DataTable accounts = this.getAllAccount();
            foreach (DataRow dr in accounts.Rows)
            {
                if (dr[0].ToString() == userName)
                {
                    AccountDTO acc = new AccountDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), int.Parse(dr[3].ToString()), bool.Parse(dr[4].ToString()));
                    return acc;
                }
            }
            return null;
        }

        public bool addAccount(string username, string password, string staffId, int permission, bool statusItems)
        {
            return loginDAO.addAccount(username, password, staffId, permission, statusItems);
        }

        public bool editAccount(string password, string staffId, int permission, bool statusItems)
        {
            return loginDAO.editAccount(password, staffId, permission, statusItems);
        }

        public bool hasUsername(string newUsername)
        {
            DataTable usernames = loginDAO.getAllUsername();
            foreach (DataRow dr in usernames.Rows)
            {
                if (dr[0].ToString() == newUsername)
                {
                    return false;
                }
            }
            return true;
        }
    }
}