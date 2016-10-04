using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class Dish
    {             
        public int DishID { get; set; }
                                           
        public Category Category { get; set; }

        public string CategoryName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ImageLink { get; set; }


        public decimal Availability { get; set; }



        public bool Del { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}