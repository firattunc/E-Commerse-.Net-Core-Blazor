using Abp.Application.Services;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Entities;
using BlazorProject.Backend.UserAddresses.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.UserAddresses
{
    public class UserAddressService: AsyncCrudAppService<UserAddress,UserAddressDto, int, CreateUserAddressDto, PagedUserAddressResultRequestDto, UserAddressDto>, IUserAddressService
    {
        public UserAddressService(IRepository<UserAddress, int> repository) : base(repository)
        {
        }

        public async Task<UserAddressDto> GetByUserId(long id)
        {
            var address =await Repository.FirstOrDefaultAsync(x => x.UserId==id);
            return ObjectMapper.Map<UserAddressDto>(address);
        }
    }
}
