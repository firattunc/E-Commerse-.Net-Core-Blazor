using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Northwİnd.Blazor.Models;
using Northwİnd.Blazor.Services.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        HttpClient _httpClient;                
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CategoryModel>> GetCategories()
        {
            var result= await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/CategoriesService/GetCategories");
            var category = JsonConvert.DeserializeObject<ListResultDto<CategoryModel>>(result.Result.ToString());                    
            return category.items.ToList();
        }
    }
}
