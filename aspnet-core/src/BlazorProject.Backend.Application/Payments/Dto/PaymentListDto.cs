using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BlazorProject.Backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Backend.Payments.Dto
{
    [AutoMapFrom(typeof(Payment))]
    public class PaymentListDto:EntityDto
    {
        public string Name { get; set; }
    }
}
