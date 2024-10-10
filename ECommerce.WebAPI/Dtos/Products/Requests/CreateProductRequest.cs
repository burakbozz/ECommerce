namespace ECommerce.WebAPI.Dtos.Products.Requests
{
    public sealed record CreateProductRequest
        (
            string Name,
            int Stock,
            double Price,
            int CategoryId
        );
    
}
