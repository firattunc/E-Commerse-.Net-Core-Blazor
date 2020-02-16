using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BlazorProject.Backend.Categories.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Backend.Categories
{
    public interface ICategoriesService:IApplicationService
    {
        Task<ListResultDto<CategoryListDto>> GetCategories();
    }
}
