
using AutoMapper;
using DukkanTek.Application.Features.Inventory.GetProductDetails;
using DukkanTek.Application.Features.Inventory.OrderInventory;
using DukkanTek.Application.Features.Inventory.UpdateProduct;
using DukkanTek.Infrastructure.Data.Contracts;
using DukkanTek.Infrastructure.Data.Entities;
using DukkanTek.Models.Request;
using DukkanTek.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Service.Inventory.Contacts
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository inventoryRepository;
        private readonly IMapper mapper;
        public InventoryService(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            this.inventoryRepository = inventoryRepository;
            this.mapper = mapper;
        }
        public async Task<List<ProductsDetails>> GetInventoryDetails(int productId)
        {
            var result = await inventoryRepository.GetInventoryDetails(productId);
            List<ProductsDetails> lstProductsDetails = null;
            if (result != null)
            {
                lstProductsDetails = new List<ProductsDetails>();
                result.ForEach(x =>
                {
                    lstProductsDetails.Add(new ProductsDetails
                    {
                        ProductId = x.ProductId,
                        ProductName = x.ProductName,
                        CategoryId = x.CategoryId,
                        CategoryName = x.CategoryName,
                        Damaged = x.Damaged,
                        Sold = x.Sold,
                        InStock = x.Quantity - (x.Sold + x.Damaged)
                    }
                    );
                }
                );
            }

            return lstProductsDetails;
        }

        public async Task UpdateProductStock(UpdateProductQuery request)
        {
            var inventoryRequest = mapper.Map<UpdateProductRequest>(request);
            await inventoryRepository.UpdateProductStock(inventoryRequest);
        }

        public async Task<OrderDetails> OrderInventory(OrderInventoryQuery request)
        {
            return await inventoryRepository.OrderInventory(request.orderRequest); 
        }
    }
}
