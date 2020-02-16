using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BlazorProject.Backend.Controllers
{
    public abstract class BackendControllerBase: AbpController
    {
        protected BackendControllerBase()
        {
            LocalizationSourceName = BackendConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
