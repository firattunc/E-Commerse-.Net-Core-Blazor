using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.Products.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Products
{
    public interface IProductService:IAsyncCrudAppService<ProductDto,int,PagedProductResultRequestDto,CreateProductDto,ProductDto>
    {
        Task<ListResultDto<ProductDto>> GetAllByCategoryId(int id);
    }
}
