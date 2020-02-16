using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.Entities;
using BlazorProject.Backend.Orders.Dto;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Orders
{
    public interface IOrderService: IAsyncCrudAppService<OrderDto,int, PagedOrderResultRequestDto,CreateOrderDto, OrderDto>
    {
        Task<int> CreateAndGetId(CreateOrderDto input);
        Task<ListResultDto<OrdersByUserIdResultDto>> GetOrdersByUserId(int id);
        Task<GetOrderDetailByIdResultDto> GetOrderDetailById(int id);
    }
}
