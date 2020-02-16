using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using BlazorProject.Backend.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorProject.Backend.Entities
{
    public class Order:Entity<int>,IHasCreationTime
    {        
        public DateTime CreationTime { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public int CargoId { get; set; }
        public int PaymentId { get; set; }
        public int CountryId { get; set; }
        public long UserId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }        
        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }
        [ForeignKey("CargoId")]
        public virtual Cargo Cargo { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public Order()
        {
            CreationTime = DateTime.Now;
            OrderProducts = new HashSet<OrderProduct>();
        }
    }
}
