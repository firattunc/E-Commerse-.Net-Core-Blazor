using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.UserAddresses.Dto
{

    [AutoMapTo(typeof(UserAddress))]
    public class CreateUserAddressDto
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
