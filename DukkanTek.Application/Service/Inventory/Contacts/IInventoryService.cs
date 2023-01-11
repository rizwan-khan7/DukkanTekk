
using DukkanTek.Application.Features.Inventory.GetProductDetails;
using DukkanTek.Application.Features.Inventory.OrderInventory;
using DukkanTek.Application.Features.Inventory.UpdateProduct;
using DukkanTek.Models.Request;
using DukkanTek.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Service.Inventory.Contacts
{
    public interface IInventoryService
    {
        Task<List<ProductsDetails>> GetInventoryDetails(int productId);
        Task UpdateProductStock(UpdateProductQuery request);
        Task<OrderDetails> OrderInventory(OrderInventoryQuery request);
    }
}
