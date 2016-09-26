using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class Order
    {
        private int customerId;    
        private string orderDate;
        private int numberOfGuest;
        private string note;
        private decimal paid;
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

        public string OrderDate
        {
            get
            {
                return orderDate;
            }

            set
            {
                orderDate = value;
            }
        }

        public int NumberOfGuest
        {
            get
            {
                return numberOfGuest;
            }

            set
            {
                numberOfGuest = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public decimal Paid
        {
            get
            {
                return paid;
            }

            set
            {
                paid = value;
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