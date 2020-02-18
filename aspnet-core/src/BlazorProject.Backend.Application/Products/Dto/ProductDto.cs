using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto:EntityDto<int>
    {
        public string Name { get; set; }
        public int Discount { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Colour { get; set; }
        public string ImgUrl { get; set; }
        public string ColourId { get; set; }
    }
}
