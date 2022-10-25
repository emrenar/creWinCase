using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shopping.WebApp.Application.CategoryService;
using Shopping.WebApp.Application.CategoryService.GetCategories;
using Shopping.WebApp.Application.CategoryService.GetCategoryWithProducts;
using Shopping.WebApp.Models;
using Shopping.WebApp.Models.Context;
using System.Linq;

namespace Shopping.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ShoppingDbContext _context;
        private readonly IMapper _mapper;

        public CategoryController(ShoppingDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult GetCategories()
        {
            GetCategoriesApplication categori = new GetCategoriesApplication(_context);
            var result = categori.Handle();

            return View(result);
        }

        public IActionResult GetCategoryDetails(int id)
        {
            GetCategoryDetailsApplication products = new GetCategoryDetailsApplication(_context,_mapper);
            products.CategoryId = id;
            var result = products.Handle();

            return View(result);
        }
    }
}
