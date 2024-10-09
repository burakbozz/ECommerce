using ECommerce.WebAPI.Models;

namespace ECommerce.WebAPI.Service.Abstract;

public interface IProductService
{
    
    List<Product> GetAll();

    Product? GetById(int id);

    Product Add(Product product);

    Product Update(Product product);

    Product? Delete(int id);
}
