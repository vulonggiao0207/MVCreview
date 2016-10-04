using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class LoginViewModel
    {
        public string CustomerUserName{get;set;}
        public string CustomerPassword { get; set; }

}
    public class RegisterViewModel
    {
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

        [Required]
        [StringLength(12, MinimumLength = 6)]
        public string CustomerUserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string CustomerPassword { get; set; }
    }
}