using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int OrderID { get; set; }

        public Customer Customer { get; set; }
        public int CustomerID { get; set; }           

        public string OrderDate { get; set; }                   

        public int NumberOfGuest { get; set; }


        public string Note { get; set; }


        public decimal Paid { get; set; }


        public bool Del { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}