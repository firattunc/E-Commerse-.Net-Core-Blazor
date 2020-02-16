using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Colours.Dto
{
    [AutoMapFrom(typeof(Colour))]
    public class ColourDto:EntityDto<int>
    {
        public string Name { get; set; }
    }
}
