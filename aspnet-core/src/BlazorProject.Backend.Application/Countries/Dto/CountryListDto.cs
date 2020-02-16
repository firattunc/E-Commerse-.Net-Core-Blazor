using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Countries.Dto
{
    [AutoMapFrom(typeof(Country))]
    public class CountryListDto:EntityDto
    {
        public string Name { get; set; }
    }
}
