using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Cargos.Dto;
using BlazorProject.Backend.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Cargos
{
    public class CargoService : ApplicationService, ICargoService
    {
        private readonly IRepository<Cargo> _cargoRepository;
        public CargoService(IRepository<Cargo> cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }
        public async Task<ListResultDto<CargoListDto>> GetCargos()
        {
            var cargos = await _cargoRepository.GetAllListAsync();

            return new ListResultDto<CargoListDto>
            (
                ObjectMapper.Map<List<CargoListDto>>(cargos)
            );

        }
    }
}