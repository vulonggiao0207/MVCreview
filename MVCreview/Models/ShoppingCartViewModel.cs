using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class ShoppingCartViewModel
    {
        public int dishID { get; set; }
        public decimal quantity { get; set; }
    }
}