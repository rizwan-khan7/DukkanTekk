using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Features.Inventory.GetProductDetails
{
    public class GetProductDetailsQuery : IRequest<GetProductDetailsQueryResult>
    {
        public int ProductId { get; set; }
    }
}
