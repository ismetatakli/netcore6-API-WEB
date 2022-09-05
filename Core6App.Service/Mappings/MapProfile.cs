using AutoMapper;
using Core6App.Core.DTOs;
using Core6App.Core.Models;

namespace Core6App.Service.Mappings
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();
        }
    }
}
