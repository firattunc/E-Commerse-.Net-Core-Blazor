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
    public class CountryService : ICountryService
    {
        HttpClient _httpClient;        
        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Country>> GetCountries()
        {
            var result = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/countryservice/getcountries");
            return JsonConvert.DeserializeObject<ListResultDto<Country>>(result.Result.ToString()).items.ToList();
        }
    }
}
