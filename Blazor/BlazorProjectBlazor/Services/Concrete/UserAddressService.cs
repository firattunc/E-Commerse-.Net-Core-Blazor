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
    public class UserAddressService : IUserAddressService
    {
        HttpClient _httpClient;
        public UserAddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<UserAddressModel> GetUserAddressByUserId(long id)
        {
            var result = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/UserAddressService/GetByUserId?Id="+id);
            return JsonConvert.DeserializeObject<UserAddressModel>(result.Result.ToString());
        }
        public async Task<UserAddressModel> UpdateUserAddress(UserAddressModel userAddressModel)
        {
            var result = await _httpClient.PutJsonAsync<ResultModel>("/api/services/app/UserAddressService/Update" , userAddressModel);
            return JsonConvert.DeserializeObject<UserAddressModel>(result.Result.ToString());
        }
    }
}
