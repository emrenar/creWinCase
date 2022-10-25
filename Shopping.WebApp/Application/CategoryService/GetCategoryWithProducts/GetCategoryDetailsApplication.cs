using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shopping.WebApp.Models;
using Shopping.WebApp.Models.Context;

namespace Shopping.WebApp.Application.CategoryService.GetCategoryWithProducts
{
    public class GetCategoryDetailsApplication
    {
        private readonly ShoppingDbContext _context;
        private readonly IMapper _mapper;

        public int CategoryId { get; set; }
        public GetCategoryDetailsViewModel Model { get; set; }

        public GetCategoryDetailsApplication(ShoppingDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GetCategoryDetailsViewModel> Handle()
        {
            var products = _context.Products.Include(z=>z.Category).Where(x=>x.CategoryId==CategoryId).OrderBy(y => y.Id).ToList();
            if (products is null)
            {
                return null;
            }
            List<GetCategoryDetailsViewModel> cdm = _mapper.Map<List<GetCategoryDetailsViewModel>>(products);
            return cdm;
        }

        public class GetCategoryDetailsViewModel
        {
            public int Id { get; set; }

            public string? Title { get; set; }

            public string? Description { get; set; }

            public string ProductImage { get; set; }

            public decimal Price { get; set; }

            public int Stock { get; set; }

            public double Rating { get; set; }

            public double DiscountPercentage { get; set; }

            public string? Brand { get; set; }
          
            public string CategoryName { get; set; }
        }
    }
}
