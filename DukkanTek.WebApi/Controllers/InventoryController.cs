using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using AutoMapper;
using static System.Net.Mime.MediaTypeNames;
using AutoMapper;
using DukkanTek.Application.Features.Inventory.GetProductDetails;
using DukkanTek.Models.Request;
using DukkanTek.Application.Features.Inventory.OrderInventory;
using DukkanTek.Application.Features.Inventory.UpdateProduct;

namespace DukkanTek.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly ILogger<InventoryController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public InventoryController(ILogger<InventoryController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("GetProductsDetails")]
        public async Task<ActionResult> GetProductsDetails(int productId)
        {
            _logger.LogInformation("Get Product Details Get started at {DT}", DateTime.UtcNow.ToLongTimeString());           

            var query = new GetProductDetailsQuery { ProductId = productId };
            var result = await _mediator.Send(query);
            _logger.LogInformation("Product Details Get completed at {DT}", DateTime.UtcNow.ToLongTimeString());
            return this.Ok(result);
        }

        [HttpPost("UpdateProductStock")]
        public async Task<ActionResult> UpdateProductStock(UpdateProductRequest request)
        {
            _logger.LogInformation("Product update started at {DT}", DateTime.UtcNow.ToLongTimeString());
            var updateRequest = _mapper.Map<UpdateProductQuery>(request);
            var result = await _mediator.Send(updateRequest);
            _logger.LogInformation("Product update completed at {DT}", DateTime.UtcNow.ToLongTimeString());            
            return this.Ok(result);
        }

        [HttpPost("Order")]
        public async Task<ActionResult> Order(OrderRequest request)
        {
            _logger.LogInformation("Order placing started at {DT}", DateTime.UtcNow.ToLongTimeString());
            var orderRequest = new OrderInventoryQuery { orderRequest = request };
            var result = await _mediator.Send(orderRequest);
            _logger.LogInformation("Order placing completed at {DT}", DateTime.UtcNow.ToLongTimeString());
            return this.Ok(result);
        }

    }
}
