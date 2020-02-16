using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.Cargos.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Cargos
{
    public interface ICargoService:IApplicationService
    {
        Task<ListResultDto<CargoListDto>> GetCargos();
    }
}
