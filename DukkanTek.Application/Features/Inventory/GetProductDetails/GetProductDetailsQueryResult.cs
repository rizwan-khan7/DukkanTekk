using DukkanTek.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Features.Inventory.GetProductDetails
{
    public class GetProductDetailsQueryResult
    {
        public List<ProductsDetails> ProductsDetailsList
        {
            get; set;
        }
    }
}
