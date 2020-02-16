using Abp.AutoMapper;
using BlazorProject.Backend.Authentication.External;

namespace BlazorProject.Backend.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
