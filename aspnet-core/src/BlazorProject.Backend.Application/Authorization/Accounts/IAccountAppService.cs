using System.Threading.Tasks;
using Abp.Application.Services;
using BlazorProject.Backend.Authorization.Accounts.Dto;

namespace BlazorProject.Backend.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
