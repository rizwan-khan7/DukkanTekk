using DukkanTek.Infrastructure.Data.DomainEntities;
using DukkanTek.Infrastructure.Data.Entities;
using DukkanTek.Models.Request;
using DukkanTek.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Infrastructure.Data.Contracts
{
    public interface IInventoryRepository
    {
        Task<List<DomainEntities.ProductsDetails>> GetInventoryDetails(int productId);
        Task UpdateProductStock(UpdateProductRequest request);
        Task<OrderDetails> OrderInventory(OrderRequest request);
    }
}
