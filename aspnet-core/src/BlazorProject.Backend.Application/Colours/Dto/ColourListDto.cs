using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Colours.Dto
{
    [AutoMapFrom(typeof(Colour))]
    public class ColourListDto:EntityDto
    {
        public string Name { get; set; }
    }
}
