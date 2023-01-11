using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Infrastructure.Data.DomainEntities
{
    public class ProductsDetails
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Sold { get; set; }
        public int Damaged { get; set; }
        public int Quantity { get; set; }
    }
}
