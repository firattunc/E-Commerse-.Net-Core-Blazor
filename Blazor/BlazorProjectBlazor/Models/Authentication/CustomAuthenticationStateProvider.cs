using Blazor.Extensions.Storage;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Northwİnd.Blazor.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        ILocalStorageService _localStorageService { get; }
        ISessionStorageService _sessionStorageService { get; }
        public IUserService _userService { get; set; }

        public CustomAuthenticationStateProvider(ILocalStorageService localStorageService, ISessionStorageService sessionStorageService,
            IUserService userService)
        {            
            _sessionStorageService = sessionStorageService;
            _localStorageService = localStorageService;
            _userService = userService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var accessToken = await _localStorageService.GetItemAsync<string>("token");

            ClaimsIdentity identity;

            if (accessToken != null && accessToken != string.Empty)
            {
                var user = await _localStorageService.GetItemAsync<UserModel>("loginUser");
                identity = GetClaimsIdentity(user);
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var claimsPrincipal = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }
        
        public void MarkUserAsAuthenticated(UserModel user)
        {

            var identity = GetClaimsIdentity(user);

            var claimsPrincipal = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }

        public async void MarkUserAsLoggedOut()
        {
            await _localStorageService.ClearAsync();
            await _sessionStorageService.ClearAsync();

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        private ClaimsIdentity GetClaimsIdentity(UserModel user)
        {
            var claimsIdentity = new ClaimsIdentity(new[]
                                {
                                    new Claim(ClaimTypes.Name, user.EmailAddress),
                                    new Claim(ClaimTypes.Role, user.RoleNames[0])
                                }, "apiauth_type");

            return claimsIdentity;
        }
    }
}
