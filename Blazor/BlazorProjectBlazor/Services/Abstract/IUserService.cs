using BlazorProjectBlazor.Models.AccountUpdate;
using Northwİnd.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Abstract
{
    public interface IUserService
    {
        Task<UserModel> Get(int id);
        Task ChangePassword(ChangePasswordDto changePasswordDto);
        Task<UserModel> UpdateUser(UserModel userModel); 
    }
}
