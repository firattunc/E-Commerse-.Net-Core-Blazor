using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.Countries.Dto;
using BlazorProject.Backend.Entities;
using BlazorProject.Backend.OrderProducts.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProject.Backend.OrderProducts
{
    public interface IOrderProductService: IAsyncCrudAppService<OrderProductDto, int, PagedOrderProductResultRequestDto, CreateOrderProductDto, OrderProductDto>
    {        
                
    }
}
