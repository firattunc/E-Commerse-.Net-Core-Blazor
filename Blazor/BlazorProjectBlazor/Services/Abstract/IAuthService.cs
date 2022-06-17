using BlazorProjectBlazor.Models;
using Northwİnd.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services
{
    public interface IAuthService
    {
        Task Login(LoginModel loginModel);
        Task Register(RegisterModel registerModel);
        Task Logout();
    }
}
