using DukkanTek.Models.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Features.Inventory.UpdateProduct
{
    public class UpdateProductQuery : IRequest<Unit>
    {
        public long ProductId { get; set; }
        public int? AddedStock { get; set; }
        public int? DamagedStock { get; set; }
        public int? SoldStock { get; set; }
    }
}
