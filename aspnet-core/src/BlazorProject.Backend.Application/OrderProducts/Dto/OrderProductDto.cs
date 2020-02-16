using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.OrderProducts.Dto
{
    [AutoMapFrom(typeof(OrderProduct))]
    public class OrderProductDto:EntityDto<int>
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
