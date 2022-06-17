using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Discount { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }        
        public string ImgUrl { get; set; }
        public int ColourId { get; set; }
    }
}
