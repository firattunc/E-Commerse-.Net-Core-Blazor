using AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.UserAddresses.Dto
{
    public class UserAddressMapProfile:Profile
    {
        public UserAddressMapProfile()
        {
            CreateMap<UserAddressDto, UserAddress>();
            CreateMap<UserAddressDto, UserAddress>();                
            CreateMap<CreateUserAddressDto, Order>();
        }
    }
}
