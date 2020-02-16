using Abp.AspNetCore.Mvc.ViewComponents;

namespace BlazorProject.Backend.Web.Views
{
    public abstract class BackendViewComponent : AbpViewComponent
    {
        protected BackendViewComponent()
        {
            LocalizationSourceName = BackendConsts.LocalizationSourceName;
        }
    }
}
