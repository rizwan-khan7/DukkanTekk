using AutoMapper;
using DukkanTek.Application.Features.Inventory.GetProductDetails;
using DukkanTek.Application.Features.Inventory.UpdateProduct;
using DukkanTek.Models.Request;
using DukkanTek.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanTek.Application.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<ProductsDetails, Infrastructure.Data.DomainEntities.ProductsDetails>().ReverseMap();
            CreateMap<UpdateProductQuery, UpdateProductRequest>().ReverseMap();
        }
    }
}
