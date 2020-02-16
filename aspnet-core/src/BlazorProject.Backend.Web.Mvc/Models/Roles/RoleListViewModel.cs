using System.Collections.Generic;
using BlazorProject.Backend.Roles.Dto;

namespace BlazorProject.Backend.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
