using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Entities;
using BlazorProject.Backend.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Products
{
    public class ProductService : AsyncCrudAppService<Product, ProductDto, int, PagedProductResultRequestDto, CreateProductDto, ProductDto>, IProductService
    {
        public ProductService(IRepository<Product, int> repository) : base(repository)
        {
        }

        public async Task<ListResultDto<ProductDto>> GetAllByCategoryId(int id)
        {
            var products = await Repository.GetAllListAsync(x => x.CategoryId == id);
            return new ListResultDto<ProductDto>(ObjectMapper.Map<List<ProductDto>>(products));
        }


    }
}
