using ECommerce.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.Controllers
{
    // @RestController
    // @Request("api/products/")
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static List<Product> Products = new List<Product>()
        {
            new Product { Id = 1,Name = "dyson süpürge",Price =25000 ,Stock = 50},
            new Product { Id = 2,Name = "Iphone 16",Price =87000 ,Stock = 100},
            new Product { Id = 3,Name = "steel series alpha 7",Price =2500 ,Stock = 10},
            new Product { Id = 4,Name = "piyano",Price =9999 ,Stock = 5},
            new Product { Id = 5,Name = "fb forması",Price =2500 ,Stock = 50}
        };

        //[HttpGet("getproduct")]
        //public Product GetProduct()
        //{
        //    return new Product
        //    {
        //        Id = 1,
        //        Name = "test",
        //        Price = 100,
        //        Stock =100
        //    };
        //}
        [HttpGet]
        public List<Product> GetAll()
        {
            return Products;
        }

        [HttpGet("getbyid")]
        public Product GetById(int id)
        {
            Product product = Products.SingleOrDefault(x=> x.Id == id);
            return product;
        }
    }
}
