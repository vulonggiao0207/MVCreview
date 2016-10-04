using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    
    public class Category   
    {          
        public string CategoryName { get; set; }        

        public bool Del { get; set; }

        public ICollection<Dish> Dishes { get; set; }
    }

}