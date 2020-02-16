using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Entities;
using BlazorProject.Backend.Orders.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Orders
{
    public class OrderService : AsyncCrudAppService<Order, OrderDto, int, PagedOrderResultRequestDto, CreateOrderDto, OrderDto>, IOrderService
    {
        public OrderService(IRepository<Order> repositoryOrder) : base(repositoryOrder)
        {
        }
        public async Task<int> CreateAndGetId(CreateOrderDto input)
        {
            CheckCreatePermission();
            var order = ObjectMapper.Map<Order>(input);
            int orderId;
            try
            {
                orderId = await Repository.InsertAndGetIdAsync(order);
            }
            catch (Exception)
            {

                throw;
            }
            return orderId;
        }
        public async Task<ListResultDto<OrdersByUserIdResultDto>> GetOrdersByUserId(int id)
        {
            var orders = await Repository.GetAllListAsync(x => x.UserId == id);                             
            return new ListResultDto<OrdersByUserIdResultDto>(ObjectMapper.Map<List<OrdersByUserIdResultDto>>(orders));
        }
        public async Task<GetOrderDetailByIdResultDto> GetOrderDetailById(int id)
        {
            var order = await Repository.GetAll().Where(x => x.Id == id).Include(x => x.OrderProducts).Include(x => x.Cargo)
                 .Include(x => x.Country).Include(x => x.Payment).FirstOrDefaultAsync();
            if (order==null)
            {
                throw new EntityNotFoundException(typeof(Order), id);                
            }
            var GetOrderDetailByIdResultDto = new GetOrderDetailByIdResultDto();
            ObjectMapper.Map(order, GetOrderDetailByIdResultDto);
            return GetOrderDetailByIdResultDto;
        }
    }
}
