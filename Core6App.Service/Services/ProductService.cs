using AutoMapper;
using Core6App.Core.DTOs;
using Core6App.Core.Models;
using Core6App.Core.Repositories;
using Core6App.Core.Services;
using Core6App.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core6App.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<List<ProductWithCategoryDto>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();
            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return productsDto;
        }
    }
}
