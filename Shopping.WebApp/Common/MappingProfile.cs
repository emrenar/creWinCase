using AutoMapper;
using Shopping.WebApp.Models;
using static Shopping.WebApp.Application.CategoryService.GetCategoryWithProducts.GetCategoryDetailsApplication;

namespace Shopping.WebApp.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product,GetCategoryDetailsViewModel>()
                .ForMember(dest=>dest.CategoryName,opt=>opt.MapFrom(src=>src.Category.CategoryName));
        }
    }
}
