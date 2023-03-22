using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffDTO
    {
        private string staffID;
        private string staffName;
        private string gender;
        private DateTime birthday;
        private string numberPhone;
        private string addressNow;
        private string position;
        private bool statusItem;

        public StaffDTO()
        { }

        public StaffDTO(string position)
        {
            this.position = position;
        }

        public StaffDTO(string staffId, string staffName, string gender, DateTime birthday, string numberPhone, string addressNow, string position, bool statusItem)
        {
            this.staffID = staffId;
            this.staffName = staffName;
            this.gender = gender;
            this.birthday = birthday;
            this.numberPhone = numberPhone;
            this.addressNow = addressNow;
            this.position = position;
            this.statusItem = statusItem;
        }

        public string StaffName
        {
            get
            {
                return staffName;
            }

            set
            {
                staffName = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public string NumberPhone
        {
            get
            {
                return numberPhone;
            }

            set
            {
                numberPhone = value;
            }
        }

        public string AddressNow
        {
            get
            {
                return addressNow;
            }

            set
            {
                addressNow = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
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
    }
}