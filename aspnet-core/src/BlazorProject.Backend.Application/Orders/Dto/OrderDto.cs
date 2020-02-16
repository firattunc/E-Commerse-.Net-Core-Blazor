using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Authorization.Users;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Orders.Dto
{
    [AutoMapFrom(typeof(Order))]
    public class OrderDto:EntityDto<int>
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public int CargoId { get; set; }
        public int PaymentId { get; set; }
        public int CountryId { get; set; }
        public long UserId { get; set; }
        public DateTime CreationTime { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
