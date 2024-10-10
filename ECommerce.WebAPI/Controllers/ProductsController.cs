using ECommerce.WebAPI.Context;
using ECommerce.WebAPI.Dtos.Products.Requests;
using ECommerce.WebAPI.Dtos.Products.Responses;
using ECommerce.WebAPI.Models;
using ECommerce.WebAPI.Repository.Abstracts;
using ECommerce.WebAPI.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<ProductResponseDto> products = _productService.GetAll();
            return Ok(products);
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody]CreateProductRequest request ) 
        { 
            var created = _productService.Add(request);
            return Ok(created);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = _productService.GetById(id);
            return Ok(product);
        }

        // @RestController
        // @Request("api/products/")

        //[Route("api/[controller]")]
        //[ApiController]
        //public class ProductsController : ControllerBase
        //{
        //    MsSqlContext context =new MsSqlContext();

        //    [HttpPost("add")]
        //    public Product Add(Product product)
        //    {
        //        //insert into Products values
        //        context.Products.Add(product);
        //        context.SaveChanges();

        //        return product;
        //    }
        //    [HttpGet("getall")]
        //    public List<Product> GetAllProducts()
        //    {
        //        return context.Products.ToList();
        //    }

        //static List<Product> Products = new List<Product>()
        //{
        //    new Product { Id = 1,Name = "dyson süpürge",Price =25000 ,Stock = 50},
        //    new Product { Id = 2,Name = "Iphone 16",Price =87000 ,Stock = 100},
        //    new Product { Id = 3,Name = "steel series alpha 7",Price =2500 ,Stock = 10},
        //    new Product { Id = 4,Name = "piyano",Price =9999 ,Stock = 5},
        //    new Product { Id = 5,Name = "fb forması",Price =2500 ,Stock = 50}
        //};

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
        //[HttpGet]
        //public List<Product> GetAll()
        //{
        //    return Products;
        //}

        //[HttpGet("getbyid")]
        //public Product GetById(int id)
        //{
        //    Product? product = Products.SingleOrDefault(x=> x.Id == id);
        //    return product;
        //}
    }


}

