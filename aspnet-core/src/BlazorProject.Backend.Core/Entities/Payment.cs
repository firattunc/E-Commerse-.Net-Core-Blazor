using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Entities
{
    public class Payment:Entity<int>
    {
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Payment()
        {
            Orders = new HashSet<Order>();
        }
    }
}
