using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCreview.Models;

namespace MVCreview
{
    public class Customer
    {
       
                                      
        public int CustomerID { get; set; }


        public string CustomerName { get; set; }


        public string CustomerAddress { get; set; }


        public string CustomerPhone { get; set; }


        public string CustomerUserName { get; set; }


        public string CustomerPassword { get; set; }


        public bool Del { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
