using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview
{
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string customerAddress;
        private string customerPhone;
        private string customerUserName;
        private string customerPassword;
        private bool del;
                                      
        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }

            set
            {
                customerAddress = value;
            }
        }

        public string CustomerPhone
        {
            get
            {
                return customerPhone;
            }

            set
            {
                customerPhone = value;
            }
        }

        public string CustomerUserName
        {
            get
            {
                return customerUserName;
            }

            set
            {
                customerUserName = value;
            }
        }

        public string CustomerPassword
        {
            get
            {
                return customerPassword;
            }

            set
            {
                customerPassword = value;
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
