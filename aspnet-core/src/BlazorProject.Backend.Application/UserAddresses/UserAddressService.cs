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
    public class UserAddressService: ApplicationService, IUserAddressService
    {
        private readonly IRepository<UserAddress> _userAddressRepository;
        public UserAddressService(IRepository<UserAddress> userAddressRepository)
        {
            _userAddressRepository = userAddressRepository;
        }

        public async Task<UserAddressDto> GetByUserId(long id)
        {
            var address =await _userAddressRepository.FirstOrDefaultAsync(x => x.UserId==id);
            return ObjectMapper.Map<UserAddressDto>(address);
        }
    }
}
