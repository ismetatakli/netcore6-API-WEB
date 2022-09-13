using Core6App.Core.Models;
using Core6App.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core6App.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
