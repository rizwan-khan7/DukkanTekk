using DukkanTek.Models.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Features.Inventory.OrderInventory
{
    public class OrderInventoryQuery : IRequest<OrderInventoryQueryResult>
    {
        public OrderRequest orderRequest { get; set; }
    }
}
