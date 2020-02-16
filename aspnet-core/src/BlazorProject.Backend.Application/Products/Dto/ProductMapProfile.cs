using AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Products.Dto
{
    public class ProductMapProfile:Profile
    {
        public ProductMapProfile()
        {
            CreateMap<ProductDto, Product>();
            CreateMap<ProductDto, Product>()
                .ForMember(x => x.OrderProducts, opt => opt.Ignore());
            CreateMap<CreateProductDto, Product>();
        }
    }
}
