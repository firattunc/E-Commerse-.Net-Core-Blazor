using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Countries.Dto;
using BlazorProject.Backend.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Countries
{
    public class CountryService : ApplicationService, ICountryService
    {
        private readonly IRepository<Country> _repositoryCountry;
        public CountryService(IRepository<Country> repositoryCountry)
        {
            _repositoryCountry = repositoryCountry;
        }
        public async Task<ListResultDto<CountryListDto>> GetCountries()
        {
            var countries = await _repositoryCountry.GetAllListAsync();   
            
            return new ListResultDto<CountryListDto>(ObjectMapper.Map<List<CountryListDto>>(countries));
        }
    }
}
