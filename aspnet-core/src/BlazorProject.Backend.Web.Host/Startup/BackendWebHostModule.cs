using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BlazorProject.Backend.Configuration;

namespace BlazorProject.Backend.Web.Host.Startup
{
    [DependsOn(
       typeof(BackendWebCoreModule))]
    public class BackendWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BackendWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BackendWebHostModule).GetAssembly());
        }
    }
}
