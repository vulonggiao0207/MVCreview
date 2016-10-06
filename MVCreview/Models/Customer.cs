using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using MVCreview.Models;

namespace MVCreview
{
    public class Customer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 6)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string CustomerAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string CustomerPhone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

       
        public string CustomerUserName { get; set; }

        
        public string CustomerPassword { get; set; }


        public bool Del { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

}
