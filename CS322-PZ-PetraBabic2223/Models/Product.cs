using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CS322_PZ_PetraBabic2223.Models
{   [Table("Products")]
    public class Product
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        
        public string ProductName { get; set; }

        [Display(Name = "Model")]
        public string ProductModel { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }



    }
}