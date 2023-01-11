using DukkanTek.Application.Service.Inventory.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Features.Inventory.UpdateProduct
{
    public class UpdateProductQueryHandler : IRequestHandler<UpdateProductQuery, Unit>
    {
        private readonly IInventoryService inventoryService;
        public UpdateProductQueryHandler(IInventoryService inventoryService)
        {
            this.inventoryService = inventoryService;
        }

        public async Task<Unit> Handle(UpdateProductQuery request, CancellationToken cancellationToken)
        {
            await this.inventoryService.UpdateProductStock(request);
            return Unit.Value;
        }
    }
}
