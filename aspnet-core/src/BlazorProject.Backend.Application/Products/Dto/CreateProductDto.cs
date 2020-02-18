using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Products.Dto
{
    [AutoMapTo(typeof(Product))]
    public class CreateProductDto
    {
        public string Name { get; set; }
        public int Discount { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Colour { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }
        public int ColourId { get; set; }
    }
}
