using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.Countries.Dto;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Countries
{
    public interface ICountryService: IApplicationService
    {
        Task<ListResultDto<CountryListDto>> GetCountries();
    }
}
