using AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.OrderProducts.Dto
{
    public class OrderProductMapProfile:Profile
    {

        public OrderProductMapProfile()
        {
            CreateMap<OrderProductDto, OrderProduct>();
            CreateMap<OrderProductDto, OrderProduct>();                
            CreateMap<CreateOrderProductDto, OrderProduct>();
        }
    }
}
