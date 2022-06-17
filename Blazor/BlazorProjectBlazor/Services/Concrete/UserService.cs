using BlazorProjectBlazor.Models;
using BlazorProjectBlazor.Models.AccountUpdate;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Northwİnd.Blazor.Models;
using Northwİnd.Blazor.Services.Abstract;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class UserService : IUserService
    {
        HttpClient _httpClient;
        public IMatToaster _Toaster { get; set; }
        public NavigationManager _NavigationManager { get; set; }
        public UserService(HttpClient httpClient
            , IMatToaster Toaster
            , NavigationManager NavigationManager)
        {
            _NavigationManager = NavigationManager;
            _Toaster = Toaster;
            _httpClient = httpClient;
        }

        public async Task ChangePassword(ChangePasswordDto changePasswordDto)
        {
            try
            {
                var resultApi = await _httpClient.PostJsonAsync<ResultModel>("/api/services/app/user/changepassword", changePasswordDto);

                if (resultApi.Result.ToString() == "True")
                    _Toaster.Add("Şifre Güncellendi", MatToastType.Success, "Başarılı");
                else
                    _Toaster.Add("Şifre Güncellenemedi.Lütfen şifrenizin doğruluğunu kontrol edin.", MatToastType.Info, "Başarısız");
            }
            catch (Exception)
            {

                _Toaster.Add("Şifre Güncellenemedi.Lütfen şifrenizin doğruluğunu kontrol edin.", MatToastType.Info, "Başarısız");
            }

        }

        public Task<UserModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserModel> UpdateUser(UserModel userModel)
        {           
            
            try
            {
                var resultApi = await _httpClient.PutJsonAsync<ResultModel>("/api/services/app/User/Update", userModel);
                _Toaster.Add("Bilgileriniz Başarıyla Güncellendi.", MatToastType.Success, "Başarılı");
                return JsonConvert.DeserializeObject<UserModel>(resultApi.Result.ToString());
            }
            catch (Exception)
            {
                _Toaster.Add("Hata Oluştu", MatToastType.Info, "Başarısız");
                return new UserModel { };
            }
            
        }
    }
}
