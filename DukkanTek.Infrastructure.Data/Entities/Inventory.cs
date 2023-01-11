using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Infrastructure.Data.Entities
{   
    [Table("Inventory")]
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public decimal MRP { get; set; }
        public decimal Discount { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
        public int Sold { get; set; }
        public int Defective { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public virtual Product Product { get; set; }
    }
}
