using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class OrderDetail
    {                       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int OrderDetailID { get; set; }          
        public Dish Dish { get; set; }
        [Required]
        public int DishID { get; set; }                
        public Order order { get; set; }
        [Required]
        public int OrderID { get; set; }                      
        public decimal Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Paid { get; set; }
        [Required]
        public string Note { get; set; }
        [Required]
        public int PrintStatus { get; set; }
        [Required]
        public bool Del { get; set; }
    }
}