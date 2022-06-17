using BlazorProjectBlazor.Models;
using BlazorProjectBlazor.Services.Abstract;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Northwİnd.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorProjectBlazor.Services.Concrete
{
    public class ColourService : IColourService
    {
        HttpClient _httpClient;
        public ColourService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async   Task<List<ColourModel>> GetAll()
        {
            var result = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/ColourService/getall");            
            return JsonConvert.DeserializeObject<ListResultDto<ColourModel>>(result.Result.ToString()).items.ToList();
            
        }
    }
}
