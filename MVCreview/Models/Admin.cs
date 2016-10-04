using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class Admin
    {
        [Key]                                                     
        [Required]
        public string  User{get; set;}
        public string Password{get; set;}            
        public bool Select { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }

    }
}