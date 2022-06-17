using Blazor.Extensions.Storage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Northwİnd.Blazor.Models;
using Northwİnd.Blazor.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class OrderService : IOrderService
    {
        HttpClient _httpClient;
        ISessionStorageService _sessionStorage { get; }
        public bool IsLoogedIn { get; set; }
        public OrderService(HttpClient httpClient, ISessionStorageService sessionStorage)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
        }
        public async Task<int> Order()
        {
            var orderModel= await _sessionStorage.GetItemAsync<OrderModel>("order");
            var basketModel = await _sessionStorage.GetItemAsync<List<BasketModel>>("basket");
            var orderResultApi = await _httpClient.PostJsonAsync<ResultModel>("/api/services/app/OrderService/Createandgetid", orderModel);
            var orderId = JsonConvert.DeserializeObject<int>(orderResultApi.Result.ToString());

            foreach (var item in basketModel)
            {
                var orderProductModel = new OrderProductModel { OrderId = orderId, ProductId = item.Product.Id, Quantity = item.Quantity };
                await _httpClient.PostJsonAsync("/api/services/app/OrderProductService/Create", orderProductModel);
            }
            await _sessionStorage.RemoveItemAsync("order");
            await _sessionStorage.RemoveItemAsync("basket");
            await _sessionStorage.RemoveItemAsync("subtotal");
            return orderId;
        }

        public async Task<List<OrdersByUserIdResultDto>> GetOrdersByUserId(long id)
        {
            var resultApi= await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/OrderService/GetOrdersByUserId?Id="+id);
            var orders = JsonConvert.DeserializeObject<ListResultDto<OrdersByUserIdResultDto>>(resultApi.Result.ToString());
            return orders.items.ToList();
        }

        public async Task<GetOrderDetailByIdResultDto> GetOrderDetailById(int id)
        {
            var resultApi = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/OrderService/GetOrderDetailById?Id=" + id);
            return JsonConvert.DeserializeObject<GetOrderDetailByIdResultDto>(resultApi.Result.ToString());            
        }
    }
}
