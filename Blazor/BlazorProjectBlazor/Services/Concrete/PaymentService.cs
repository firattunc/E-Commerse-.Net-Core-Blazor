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
    public class PaymentService:IPaymentService
    {
        HttpClient _httpClient;
        public PaymentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Payment>> GetPayments()
        {
            var result = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/Paymentservice/getPayments");
            return JsonConvert.DeserializeObject<ListResultDto<Payment>>(result.Result.ToString()).items.ToList();
        }
    }
}
