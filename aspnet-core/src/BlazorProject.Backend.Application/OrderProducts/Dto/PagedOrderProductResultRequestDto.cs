using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.OrderProducts.Dto
{
    [AutoMapFrom(typeof(OrderProduct))]
    public class PagedOrderProductResultRequestDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
