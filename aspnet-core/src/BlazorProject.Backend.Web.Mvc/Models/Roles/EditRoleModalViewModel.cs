using Abp.AutoMapper;
using BlazorProject.Backend.Roles.Dto;
using BlazorProject.Backend.Web.Models.Common;

namespace BlazorProject.Backend.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
