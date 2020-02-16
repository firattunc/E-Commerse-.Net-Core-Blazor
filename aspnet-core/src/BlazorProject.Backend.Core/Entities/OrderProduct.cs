using Abp.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorProject.Backend.Entities
{
    public class OrderProduct:Entity<int>
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("ProductId")]
        [JsonIgnore]
        public virtual Product Product { get; set; }
        [ForeignKey("OrderId")]       
        [JsonIgnore]
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
