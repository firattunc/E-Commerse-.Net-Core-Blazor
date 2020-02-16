using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace BlazorProject.Backend.Web.Views
{
    public abstract class BackendRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BackendRazorPage()
        {
            LocalizationSourceName = BackendConsts.LocalizationSourceName;
        }
    }
}
