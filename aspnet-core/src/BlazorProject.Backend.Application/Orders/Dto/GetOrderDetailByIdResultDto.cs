using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Orders.Dto
{
    [AutoMapFrom(typeof(Order))]
    public class GetOrderDetailByIdResultDto : EntityDto
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public string CargoName { get; set; }
        public string PaymentName { get; set; }
        public string CountryName { get; set; }
        public DateTime CreationTime { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
