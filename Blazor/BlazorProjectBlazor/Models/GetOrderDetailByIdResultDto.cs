using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class GetOrderDetailByIdResultDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public string CargoName { get; set; }
        public string PaymentName { get; set; }
        public string CountryName { get; set; }
        public DateTime CreationTime { get; set; }
        public List<OrderProductModel> OrderProducts { get; set; }

    }
}
