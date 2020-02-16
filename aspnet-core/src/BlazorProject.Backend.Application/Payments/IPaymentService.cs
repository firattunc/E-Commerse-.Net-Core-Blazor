using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.Payments.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Payments
{
    public interface IPaymentService:IApplicationService
    {
        Task<ListResultDto<PaymentListDto>> GetPayments();
    }
}
