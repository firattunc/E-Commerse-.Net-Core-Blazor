using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class OrderModel
    {        
        public DateTime DateTime { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public int PaymentId { get; set; }
        public int CargoId { get; set; }
        public long UserId { get; set; }
        public int CountryId { get; set; }
        public List<OrderProductModel> OrderProducts { get; set; }
        public OrderModel()
        {
            OrderProducts = new List<OrderProductModel>();
        }
    }
}
