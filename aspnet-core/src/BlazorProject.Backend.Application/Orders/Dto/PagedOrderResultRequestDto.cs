using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Orders.Dto
{
    [AutoMapFrom(typeof(Order))]
    public class PagedOrderResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
