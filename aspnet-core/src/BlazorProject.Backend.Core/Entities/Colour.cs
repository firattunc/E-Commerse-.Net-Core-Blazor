using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Entities
{
    public class Colour:Entity<int>
    {
        public string Name { get; set; }
        public virtual  ICollection<Product> Products{ get; set; }
        public Colour()
        {
            Products = new HashSet<Product>();
        }
    }
}
