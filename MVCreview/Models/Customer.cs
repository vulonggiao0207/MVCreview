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
        [Display(Name ="ID")]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 6)]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Address")]
        public string CustomerAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string CustomerPhone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }

        [Display(Name = "User Name")]
        [StringLength(12, MinimumLength = 6)]
        public string CustomerUserName { get; set; }

        [Display(Name = "Password")]
        [StringLength(12, MinimumLength = 6)]
        public string CustomerPassword { get; set; }

        [Display(Name = "Delete")]
        public bool Del { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

}
