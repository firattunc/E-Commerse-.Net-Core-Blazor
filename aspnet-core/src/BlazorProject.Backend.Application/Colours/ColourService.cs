using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Colours.Dto;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Colours
{
    public class ColourService : ApplicationService, IColoursService
    {
        private readonly IRepository<Colour> _colourRepository;
        public ColourService(IRepository<Colour> colourRepository)
        {
            _colourRepository = colourRepository;
        }
        public async Task<ListResultDto<ColourListDto>> GetAll()
        {
            var colours =await _colourRepository.GetAllListAsync();
            return new ListResultDto<ColourListDto>(ObjectMapper.Map<List<ColourListDto>>(colours));
        }
    }
}
