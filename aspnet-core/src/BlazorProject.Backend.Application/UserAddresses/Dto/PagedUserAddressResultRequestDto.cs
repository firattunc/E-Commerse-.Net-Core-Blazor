using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.UserAddresses.Dto
{
    [AutoMapFrom(typeof(UserAddress))]
    public class PagedUserAddressResultRequestDto:PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
