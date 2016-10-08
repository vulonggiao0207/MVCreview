using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class ShoppingCartViewModel
    {
        public int dishID { get; set; }
        public string dishName { get; set; }
        public decimal dishPrice { get; set; }
        public decimal quantity { get; set; }
    }
}