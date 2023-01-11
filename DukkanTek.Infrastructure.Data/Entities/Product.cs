using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Infrastructure.Data.Entities
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            this.Inventory = new HashSet<Inventory>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string BarCodeText { get; set; }
        public bool IsWeighted { get; set; }
        public int CategoryId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public virtual Category Category { get; set; }  
        public virtual ICollection <Inventory> Inventory { get; set; }
    }
}
