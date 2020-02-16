using Abp.Domain.Entities;
using System.Collections.Generic;

namespace BlazorProject.Backend.Entities
{
    public class Cargo:Entity<int>
    {
        public string Name { get; set; }        
        public virtual ICollection<Order> Orders { get; set; }
        public Cargo()
        {
            Orders = new HashSet<Order>();
        }
    }
}
