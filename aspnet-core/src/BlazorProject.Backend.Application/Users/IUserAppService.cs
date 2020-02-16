using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.Roles.Dto;
using BlazorProject.Backend.Users.Dto;

namespace BlazorProject.Backend.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
