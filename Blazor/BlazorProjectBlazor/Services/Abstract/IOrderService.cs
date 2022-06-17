using Northwİnd.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Abstract
{
    public interface IOrderService
    {
        Task<int> Order();
        Task<List<OrdersByUserIdResultDto>> GetOrdersByUserId(long id);
        Task<GetOrderDetailByIdResultDto> GetOrderDetailById(int id);
    }
}
