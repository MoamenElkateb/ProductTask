using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumAPiProduct.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
