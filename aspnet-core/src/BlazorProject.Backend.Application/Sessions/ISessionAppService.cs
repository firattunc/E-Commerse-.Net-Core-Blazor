using System.Threading.Tasks;
using Abp.Application.Services;
using BlazorProject.Backend.Sessions.Dto;

namespace BlazorProject.Backend.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
