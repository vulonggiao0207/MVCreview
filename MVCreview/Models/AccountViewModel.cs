using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class LoginViewModel
    {
        [StringLength(12, MinimumLength = 6)]
        [Display(Name = "User Name:")]
        public string CustomerUserName{get;set;}

        [StringLength(12, MinimumLength = 6)]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string CustomerPassword { get; set; }     
    }
    public class RegisterViewModel
    {
        [Required]
        [StringLength(12, MinimumLength = 6)]
        [Display(Name = "Full Name:")]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Address:")]
        public string CustomerAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone:")]
        public string CustomerPhone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:")]
        public string CustomerEmail { get; set; }   
                                                       
        [StringLength(12, MinimumLength = 6)]
        [Display(Name = "UserName:")]
        public string CustomerUserName { get; set; }       
        [DataType(DataType.Password)]
        [StringLength(12, MinimumLength = 6)]
        [Display(Name = "Password:")]
        public string CustomerPassword { get; set; }
        [StringLength(12, MinimumLength = 6)]
        [Display(Name ="Confirm Password:")]
        [DataType(DataType.Password)]
        [Compare("CustomerUserName", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}