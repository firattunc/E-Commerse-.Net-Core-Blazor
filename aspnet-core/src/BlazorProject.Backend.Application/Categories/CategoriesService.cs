using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using BlazorProject.Backend.Categories.Dto;
using BlazorProject.Backend.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Categories
{
    public class CategoriesService : ApplicationService, ICategoriesService
    {
        private readonly IRepository<Category> _categoryRepository;
        public CategoriesService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<ListResultDto<CategoryListDto>> GetCategories()
        {
            var categories = await _categoryRepository.GetAllListAsync();

            return new ListResultDto<CategoryListDto>(ObjectMapper.Map<List<CategoryListDto>>(categories));
        }
    }
}
