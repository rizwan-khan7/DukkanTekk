using DukkanTek.Application.Service.Inventory.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Features.Inventory.OrderInventory
{
    public class GetProductDetailsQueryHandler : IRequestHandler<OrderInventoryQuery, OrderInventoryQueryResult>
    {
        private readonly IInventoryService inventoryService;
        public GetProductDetailsQueryHandler(IInventoryService inventoryService)
        {
            this.inventoryService = inventoryService;
        }

        public async Task<OrderInventoryQueryResult> Handle(OrderInventoryQuery request, CancellationToken cancellationToken)
        {
            var result =  await this.inventoryService.OrderInventory(request);
            return new OrderInventoryQueryResult { orderDetails = result };
        }
    }
}
