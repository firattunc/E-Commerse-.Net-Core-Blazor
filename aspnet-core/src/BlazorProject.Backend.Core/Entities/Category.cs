using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Entities
{
    public class Category:Entity<int>
    {
        public string Name { get; set; }        
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
