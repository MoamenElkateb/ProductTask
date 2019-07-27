using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("products", Schema = "dbo")]
    public class Product
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Required]
        [Column("product_name", TypeName = "varchar(50)")]
        public string ProductName { get; set; }
        [Required]
        [Column("photo", TypeName = "varchar(max)")]
        public string Photo { get; set; }
        [Required]
        [Column("price", TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        [Required]
        [Column("last_updated", TypeName = "datetime")]
        public DateTime LastUpdated { get; set; }

    }
}
