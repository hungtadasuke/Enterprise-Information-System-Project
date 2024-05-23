using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDTO
    {
        private string categoryID;
        private string categoryName;
        private bool statusItem;

        public CategoryDTO(string categoryID, string categoryName, bool statusItem)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.statusItem = statusItem;
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
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

        public string CategoryID
        {
            get
            {
                return categoryID;
            }

            set
            {
                categoryID = value;
            }
        }
    }
}