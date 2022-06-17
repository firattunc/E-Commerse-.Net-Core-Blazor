using BlazorProjectBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProjectBlazor.Services.Abstract
{
    public interface IUserAddressService
    {
        Task<UserAddressModel> GetUserAddressByUserId(long id);
        Task<UserAddressModel> UpdateUserAddress(UserAddressModel userAddressModel);
    }
}
