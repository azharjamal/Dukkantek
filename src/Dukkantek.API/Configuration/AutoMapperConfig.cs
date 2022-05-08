
using AutoMapper;
using Dukkantek.API.DTOs.Product;
using Dukkantek.API.DTOs.Category;
using Dukkantek.Domain.Models;
using Dukkantek.Domain.Models.Inventories;

namespace Dukkantek.API.Configuration
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Category, CatgoryAddDto>().ReverseMap();
            CreateMap<Category, CatgoryEditDto>().ReverseMap();
            CreateMap<Category, CatgoryResultDto>().ReverseMap();


            CreateMap<Product, ChangeStatusDto>().ReverseMap();
            CreateMap<Product, SaleDto>().ReverseMap();

        }
    }
}
