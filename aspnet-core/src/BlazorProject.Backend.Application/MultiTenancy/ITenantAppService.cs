using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.MultiTenancy.Dto;

namespace BlazorProject.Backend.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

