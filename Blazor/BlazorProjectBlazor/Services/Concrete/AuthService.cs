using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Northwİnd.Blazor.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Blazor.Extensions.Storage;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using BlazorProjectBlazor.Models;
using Microsoft.AspNetCore.Http.Extensions;
using MatBlazor;
using Microsoft.AspNetCore.Components.Authorization;

namespace Northwİnd.Blazor.Services.Concrete
{
    public class AuthService : IAuthService
    {
        HttpClient _httpClient;        
        public IMatToaster _Toaster { get; set; }
        public ILocalStorageService _localStorageService { get; set; }
        public NavigationManager _NavigationManager { get; set; }
        public AuthenticationStateProvider _authenticationStateProvider { get; set; }
        public AuthService(HttpClient httpClient, ILocalStorageService localStorageService
            , NavigationManager NavigationManager
            , AuthenticationStateProvider authenticationStateProvider
            ,IMatToaster Toaster)
        {
            _Toaster = Toaster;
            _authenticationStateProvider = authenticationStateProvider;
            _NavigationManager = NavigationManager;
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }
        public async Task Login(LoginModel loginModel)
        {
            try
            {
                var responseApi = await _httpClient.PostJsonAsync<ResultModel>("/api/TokenAuth/Authenticate", loginModel);
                var response = JsonConvert.DeserializeObject<TokenModel>(responseApi.Result.ToString());
                if (!string.IsNullOrEmpty(response.AccessToken))
                {
                    _httpClient.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", response.AccessToken);
                    await _localStorageService.SetItemAsync("token", response.AccessToken);
                    var responseApiUser = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/User/Get?Id=" + response.UserId);
                    var loginUser = JsonConvert.DeserializeObject<UserModel>(responseApiUser.Result.ToString());
                    await _localStorageService.SetItemAsync("loginUser", loginUser);
                    await _localStorageService.SetItemAsync("loginUserId", loginUser.Id);                    
                    ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginUser);
                    _Toaster.Add("Yönlendiriliyorsunuz..", MatToastType.Success, "Giriş Başarılı");
                    await Task.Delay(1000);
                    _NavigationManager.NavigateTo("/customerorders");
                }
                else
                {
                    _Toaster.Add("Kullanıcı Bulunamadı.", MatToastType.Warning, "Login Hatası");
                }
            }
            catch (System.Exception)
            {
                _Toaster.Add("Kullanıcı Bulunamadı.", MatToastType.Warning, "Login Hatası");
            }            
        }
        public async Task Logout()
        {
            await _localStorageService.ClearAsync();
            ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
        }
        public async Task Register(RegisterModel registerModel)
        {
            try
            {
                var responseApi = await _httpClient.PostJsonAsync<ResultModel>("/api/services/app/Account/register", registerModel);
                var canLogin = JsonConvert.DeserializeObject<RegisterOutput>(responseApi.Result.ToString());

                if (canLogin.CanLogin == true)
                {
                    var loginModel = new LoginModel { Password = registerModel.Password, UsernameOrEmailAddress = registerModel.UserName };

                    var responseApiAuthenticate = await _httpClient.PostJsonAsync<ResultModel>("/api/TokenAuth/Authenticate", loginModel);
                    var response = JsonConvert.DeserializeObject<TokenModel>(responseApiAuthenticate.Result.ToString());
                    _httpClient.DefaultRequestHeaders.Authorization =
                           new AuthenticationHeaderValue("Bearer", response.AccessToken);
                    await _localStorageService.SetItemAsync("token", response.AccessToken);
                    var responseApiUser = await _httpClient.GetJsonAsync<ResultModel>("/api/services/app/User/Get?Id=" + response.UserId);
                    var loginUser = JsonConvert.DeserializeObject<UserModel>(responseApiUser.Result.ToString());
                    await _localStorageService.SetItemAsync("loginUser", loginUser);
                    await _localStorageService.SetItemAsync("loginUserId", loginUser.Id);
                    ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginUser);
                    _Toaster.Add("Yönlendiriliyorsunuz..", MatToastType.Success, "Kayıt Başarılı");
                    await Task.Delay(1000);
                    _NavigationManager.NavigateTo("/");
                }
                else
                {
                    _Toaster.Add("Hata Oluştu.", MatToastType.Warning, "Kayıt Hatası");
                }
            }
            catch (System.Exception ex)
            {
                _Toaster.Add("Hata Oluştu.", MatToastType.Warning, "Kayıt Hatası");
            }
                                    
        }
    }
}
