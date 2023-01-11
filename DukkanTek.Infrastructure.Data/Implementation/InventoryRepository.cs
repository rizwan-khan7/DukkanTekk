using DukkanTek.Infrastructure.Data.Contracts;
using DukkanTek.Infrastructure.Data.DomainEntities;
using DukkanTek.Infrastructure.Data.Entities;
using DukkanTek.Models.Request;
using DukkanTek.Models.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Infrastructure.Data.Implementation
{
    public class InventoryRepository : IInventoryRepository
    {
        protected readonly DukkenTekDBContext _context;
        public InventoryRepository(DukkenTekDBContext context)
        { _context = context; }

        public async Task<List<DomainEntities.ProductsDetails>> GetInventoryDetails(int productId)
        {
            var result = from inventory in _context.Inventory
                         join pd in _context.Products on inventory.ProductId equals pd.ProductId
                         join ct in _context.Category on pd.CategoryId equals ct.CategoryId
                         select new DomainEntities.ProductsDetails
                         {
                             ProductId = pd.ProductId,
                             ProductName = pd.ProductName,
                             CategoryId = ct.CategoryId,
                             CategoryName = ct.CategoryName,
                             Damaged = inventory.Defective,
                             Sold = inventory.Sold,
                             Quantity = inventory.Quantity
                         };

            if (productId > 0)
            {
                return await result.Where(x => x.ProductId == productId).ToListAsync();
            }
            return await result.ToListAsync();
        }
        public async Task UpdateProductStock(UpdateProductRequest request)
        {
            var productInventory = _context.Inventory.FirstOrDefault(item => item.ProductId == request.ProductId);

            if (productInventory != null)
            {
                if (request.AddedStock.HasValue && request.AddedStock > 0)
                {
                    productInventory.Quantity = productInventory.Quantity + (int)request.AddedStock;
                }
                if (request.DamagedStock.HasValue && request.DamagedStock > 0)
                {
                    productInventory.Defective = productInventory.Defective + (int)request.DamagedStock;
                }
                if (request.SoldStock.HasValue && request.SoldStock > 0)
                {
                    productInventory.Sold = productInventory.Sold + (int)request.SoldStock;
                }
                await _context.SaveChangesAsync();
            }
        }

        public async Task<OrderDetails> OrderInventory(OrderRequest request)
        {
            //This method need to improve. Leaving it here because of time crunch. Thanks

            OrderDetails orderdetail = null;
            if (request != null && request.ProductDetails.Count > 0)
            {
                Order order = new Order();
                order.OrderStatus = 1;
                order.TotalTax = 0;
                order.TotalDiscount = 0;
                order.Promo = "";
                order.CreatedById = 1;
                order.CreatedDateTime = DateTime.UtcNow;

                Decimal TotalAmount = 0.0M;
                Decimal GrandTotal = 0.0M;
                List<OrderItem> orderItems = new List<OrderItem>();
                foreach (var product in request.ProductDetails)
                {
                    var productItem = _context.Inventory.FirstOrDefault(x => x.ProductId == product.ProductId);
                    productItem.Sold = productItem.Sold + product.Quantity;
                    
                    OrderItem item = new OrderItem();
                    item.ProductId = product.ProductId;
                    item.Price = product.Price;
                    item.Discount = product.Discount;
                    item.Quantity = product.Quantity;
                    item.CreatedById = 1;
                    item.CreatedDateTime = DateTime.UtcNow;
                    orderItems.Add(item);
                    TotalAmount = TotalAmount + item.Price;
                    GrandTotal = GrandTotal + item.Price;
                }

                order.GrandTotal = GrandTotal;
                order.TotalAmount = TotalAmount;
                await _context.Order.AddAsync(order);
                await _context.SaveChangesAsync();
                orderItems.ForEach(x => x.OrderId = order.OrderId);
                await _context.OrderItem.AddRangeAsync(orderItems);
                await _context.SaveChangesAsync();

                orderdetail = new OrderDetails();
                orderdetail.OrderId = order.OrderId;
                orderdetail.TotalAmount = TotalAmount;
            }
            return await Task.FromResult(orderdetail);
        }
    }
}
