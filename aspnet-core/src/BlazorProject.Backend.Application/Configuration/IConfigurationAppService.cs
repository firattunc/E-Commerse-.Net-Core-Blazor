using System.Threading.Tasks;
using BlazorProject.Backend.Configuration.Dto;

namespace BlazorProject.Backend.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
