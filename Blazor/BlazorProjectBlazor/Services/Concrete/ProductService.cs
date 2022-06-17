using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Northwİnd.Blazor.Models;
using Northwİnd.Blazor.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class ProductService : IProductService
    {
        HttpClient _httpClient;
        public bool IsLoogedIn { get; set; }
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductModel>> GetProductsById(int categoryId)
        {

            var result = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/productservice/getallbycategoryId?Id="+categoryId);
            return JsonConvert.DeserializeObject<ListResultDto<ProductModel>>(result.Result.ToString()).items.ToList();
        }

        public async Task<ProductModel> GetProductById(int productId)
        {
            var result = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/productservice/get?Id=" + productId);
            return JsonConvert.DeserializeObject<ProductModel>(result.Result.ToString());
        }

        public async Task<List<ProductModel>> GetAll()
        {
            var result = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/productservice/getall");
            return JsonConvert.DeserializeObject<ListResultDto<ProductModel>>(result.Result.ToString()).items.ToList();
        }
    }
}
