using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Infrastructure.Data.Entities
{
    [Table("Order")]
    public class Order
    {
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int OrderId { get; set; }
        public int OrderStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal GrandTotal { get; set; }
        public string Promo { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
