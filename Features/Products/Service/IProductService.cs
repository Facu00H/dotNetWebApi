using WebApplication1.Features.Products.DTOs;
using WebApplication1.Features.Products.Models;

namespace WebApplication1.Features.Products.Service
{
    public interface IProductService
    {
        void CreateProduct(CreateProductDTO product);
        void DeleteProduct(int IdProduct);
        List<ProductEntity> GetAllProducts();
        ProductEntity GetProductById(int id);
        void UpdateProduct(int id, UpdateProductDTO product);
    }
}