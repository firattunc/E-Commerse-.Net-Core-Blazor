using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Entities;
using BlazorProject.Backend.Payments.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Payments
{
    public class PaymentService:ApplicationService,IPaymentService
    {
        private readonly IRepository<Payment> _repository;
        public PaymentService(IRepository<Payment> repository)
        {
            _repository = repository;
        }

        public async Task<ListResultDto<PaymentListDto>> GetPayments()
        {
            var payments = await _repository.GetAllListAsync();
            return new ListResultDto<PaymentListDto>(ObjectMapper.Map<List<PaymentListDto>>(payments));
        }
    }
}
