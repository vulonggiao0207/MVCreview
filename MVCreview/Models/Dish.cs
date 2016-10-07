using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCreview.Models
{
    public class Dish
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DishID { get; set; }
                                           
        public Category Category { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        [StringLength(30,MinimumLength =8)]
        public string DishName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required]
        public string ImageLink { get; set; }

        [Required]              
        public decimal Availability { get; set; }

        [Required]
        public bool Del { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
    public class DishViewModel
    {
        [Key]
        [Required]
        public int DishID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8)]
        public string DishName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required]
        public string ImageLink { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Availability { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal orderNO { get; set; }

    }
}