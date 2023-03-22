using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        private string username;
        private string password;
        private string staffID;
        private int permission;
        private bool statusItem;

        public AccountDTO()
        { }

        public AccountDTO(string username, string password, string staffID, int permission, bool statusItem)
        {
            this.username = username;
            this.password = password;
            this.staffID = staffID;
            this.permission = permission;
            this.statusItem = statusItem;
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string StaffID
        {
            get
            {
                return staffID;
            }

            set
            {
                staffID = value;
            }
        }

        public int Permission
        {
            get
            {
                return permission;
            }

            set
            {
                permission = value;
            }
        }

        public bool StatusItem
        {
            get
            {
                return statusItem;
            }

            set
            {
                statusItem = value;
            }
        }
    }
}