using Core6App.Core.DTOs;
using Core6App.Core.Models;

namespace Core6App.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
