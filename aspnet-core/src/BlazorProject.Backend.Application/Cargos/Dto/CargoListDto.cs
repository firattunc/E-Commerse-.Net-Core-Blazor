using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Cargos.Dto
{
    [AutoMapFrom(typeof(Cargo))]
    public class CargoListDto:EntityDto
    {
        public string Name { get; set; }
    }
}
