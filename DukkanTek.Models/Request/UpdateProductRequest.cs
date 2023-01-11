using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Models.Request
{
    public class UpdateProductRequest
    {
        public long ProductId { get; set; }
        public int? AddedStock { get; set; }
        public int? DamagedStock { get; set; }
        public int? SoldStock { get; set; }
    }
}
