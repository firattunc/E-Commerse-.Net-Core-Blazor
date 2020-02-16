using Abp.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorProject.Backend.Entities
{
    public class Product:Entity<int>
    {
        public string Name { get; set; }

        public int Discount { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }        
        public string ImgUrl { get; set; }        
        public int ColourId { get; set; }
        [ForeignKey("ColourId")]
        public virtual Colour Colour { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }        
        [JsonIgnore]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }
    }
}
