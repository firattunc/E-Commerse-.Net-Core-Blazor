using System.Collections.Generic;
using BlazorProject.Backend.Roles.Dto;

namespace BlazorProject.Backend.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}