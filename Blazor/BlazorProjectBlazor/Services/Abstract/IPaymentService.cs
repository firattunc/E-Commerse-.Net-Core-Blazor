using Northwİnd.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Abstract
{
    public interface IPaymentService
    {
        Task<List<Payment>> GetPayments();
    }
}
