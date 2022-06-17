using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class OrderProductModel
    {
        public int OrderProductId { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
