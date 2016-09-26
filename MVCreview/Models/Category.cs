using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    
    public class Category   
    {
        private string categoryName;
        private bool del;

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

        public bool Del
        {
            get
            {
                return del;
            }

            set
            {
                del = value;
            }
        }
    }
}