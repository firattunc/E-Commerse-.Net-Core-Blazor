using System.Collections.Generic;
using BlazorProject.Backend.Roles.Dto;
using BlazorProject.Backend.Users.Dto;

namespace BlazorProject.Backend.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
