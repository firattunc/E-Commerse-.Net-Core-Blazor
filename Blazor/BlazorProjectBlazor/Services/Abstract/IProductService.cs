using Northwİnd.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Abstract
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProductsById(int categoryId);
        Task<ProductModel> GetProductById(int productId);
        Task<List<ProductModel>> GetAll();
    }
}
