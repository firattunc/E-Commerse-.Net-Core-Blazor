using Abp.AutoMapper;
using BlazorProject.Backend.Sessions.Dto;

namespace BlazorProject.Backend.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
