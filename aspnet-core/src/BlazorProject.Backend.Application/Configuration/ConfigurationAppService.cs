using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BlazorProject.Backend.Configuration.Dto;

namespace BlazorProject.Backend.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BackendAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
