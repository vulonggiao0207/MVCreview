using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class OrderDetail
    {
        private int dishID;
        private int orderID;
        private Decimal quantity;
        private Decimal price;
        private string note;
        private int printStatus;
        private bool del;

        public int DishID
        {
            get
            {
                return dishID;
            }

            set
            {
                dishID = value;
            }
        }

        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }

        public decimal Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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

        public int PrintStatus
        {
            get
            {
                return printStatus;
            }

            set
            {
                printStatus = value;
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