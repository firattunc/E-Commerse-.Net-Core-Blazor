using BlazorProjectBlazor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        [Required]        
        public string UserName { get; set; }

        [Required]        
        public string Name { get; set; }

        [Required]        
        public string Surname { get; set; }

        [Required]
        [EmailAddress]        
        public string EmailAddress { get; set; }
        [MaxLength(32)]
        [MinLength(11)]
        [Required]
        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }

        public string FullName { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime CreationTime { get; set; }

        public string[] RoleNames { get; set; }
        public UserAddressModel UserAddress { get; set; }
        public UserModel()
        {
            UserAddress = new UserAddressModel();
        }

    }
}