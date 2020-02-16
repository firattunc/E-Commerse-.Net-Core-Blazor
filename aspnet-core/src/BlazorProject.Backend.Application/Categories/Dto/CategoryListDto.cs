using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Categories.Dto
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryListDto:EntityDto
    {
        public string Name { get; set; }
    }
}
