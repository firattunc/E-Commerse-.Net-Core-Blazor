using AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Orders.Dto
{
    public class OrderMapProfile : Profile
    {
        public OrderMapProfile()
        {
            CreateMap<OrderDto, Order>();
            CreateMap<OrderDto, Order>()
                .ForMember(x => x.OrderProducts, opt => opt.Ignore());
            CreateMap<CreateOrderDto, Order>();
        }
    }
}
