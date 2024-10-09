using ECommerce.WebAPI.Models;
using ECommerce.WebAPI.Service.Abstract;
using ECommerce.WebAPI.Service.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<Category> categories = _categoryService.GetAll();
            return Ok(categories);
        }
        //static List<Category> Categories = new List<Category>()
        //{
        //    new Category { Id = 1, Name ="elektronik"},
        //    new Category { Id = 2, Name ="giyim"},
        //    new Category { Id = 3, Name ="spor"},

        //};

        //[HttpGet]
        //public List<Category> GetAll()
        //{
        //    return Categories;
        //}

        //[HttpGet("getbyid")]
        //public Category GetById(int id)
        //{
        //    Category? category = Categories.SingleOrDefault(x => x.Id == id);
        //    return category;
        //}
    }
}

