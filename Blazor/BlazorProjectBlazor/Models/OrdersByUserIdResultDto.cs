using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class OrdersByUserIdResultDto 
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
