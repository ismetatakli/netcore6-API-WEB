using Core6App.Core.DTOs;
using Core6App.Core.Models;

namespace Core6App.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<List<ProductWithCategoryDto>> GetProductsWithCategory();
    }
}
