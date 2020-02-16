using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class PagedProductResultRequestDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
