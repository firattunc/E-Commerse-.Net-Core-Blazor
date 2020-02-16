using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Orders.Dto
{    
    [AutoMapTo(typeof(Order))]
    public class CreateOrderDto
    {
        public int CargoId { get; set; }
        public int PaymentId { get; set; }
        public int CountryId { get; set; }
        public long UserId { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public decimal Total { get; set; }
    }
}
