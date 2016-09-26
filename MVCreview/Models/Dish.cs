using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class Dish
    {
        private int dishID;
        private string categoryName;
        private decimal price;
        private string description;
        private string imageLink;
        private decimal availability;
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public decimal Availability
        {
            get
            {
                return availability;
            }

            set
            {
                availability = value;
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

        public int DishID1
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
    }
}