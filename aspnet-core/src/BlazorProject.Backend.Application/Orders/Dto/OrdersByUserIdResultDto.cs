using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Orders.Dto
{
    [AutoMapFrom(typeof(Order))]
    public class OrdersByUserIdResultDto:EntityDto<int>
    {        
        public decimal Total { get; set; }
        public string Status { get; set; }   
        public DateTime CreationTime { get; set; }

    }
}
