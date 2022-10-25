using PagedList;
using Shopping.WebApp.Models;
using Shopping.WebApp.Models.Context;

namespace Shopping.WebApp.Application.CategoryService.GetCategories
{
    public class GetCategoriesApplication
    {
        private readonly ShoppingDbContext _context;
        public GetCategoriesViewModel Model { get; set; }
        public GetCategoriesApplication(ShoppingDbContext context)
        {
            _context = context;
        }

        public List<GetCategoriesViewModel> Handle()
        {
            var categories = _context.Categories.Where(x => x.IsActive == true).OrderBy(y => y.Id).ToList();
            if (categories is null)
            {
                return null;
            }
            List<GetCategoriesViewModel> vm = new List<GetCategoriesViewModel>();
            foreach (var item in categories)
            {
                vm.Add(new GetCategoriesViewModel()
                {
                    Id=item.Id,
                    CategoryName=item.CategoryName,
                    CategoryStatu= "Active"
                });
            }
            return vm;
        }
        public class GetCategoriesViewModel
        {
            public int Id { get; set; }

            public string? CategoryName { get; set; }

            public string? CategoryStatu { get; set; }
        }
    }
}
