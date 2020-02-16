using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Entities;
using BlazorProject.Backend.OrderProducts.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.OrderProducts
{
    public class OrderProductService : AsyncCrudAppService<OrderProduct, OrderProductDto, int, PagedOrderProductResultRequestDto, CreateOrderProductDto, OrderProductDto>, IOrderProductService
    {
        public OrderProductService(IRepository<OrderProduct, int> repository) : base(repository)
        {
        }
    }
}
