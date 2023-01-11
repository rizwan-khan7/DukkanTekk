using DukkanTek.Application.Service.Inventory.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Features.Inventory.GetProductDetails
{
    public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailsQuery, GetProductDetailsQueryResult>
    {
        private readonly IInventoryService inventoryService;
        public GetProductDetailsQueryHandler(IInventoryService inventoryService)
        {
            this.inventoryService = inventoryService;
        }

        public async Task<GetProductDetailsQueryResult> Handle(GetProductDetailsQuery request, CancellationToken cancellationToken)
        {
            var result =  await this.inventoryService.GetInventoryDetails(request.ProductId);
            return new GetProductDetailsQueryResult { ProductsDetailsList = result };
        }
    }
}
