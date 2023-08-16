using WebApplication1.Data;
using WebApplication1.Features.Products.DTOs;
using WebApplication1.Features.Products.Models;

namespace WebApplication1.Features.Products.Service
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;

        public ProductService(StoreDbContext context)
        {
            _context = context;
        }

        public void CreateProduct(CreateProductDTO product)
        {
            ProductEntity productEntity = new()
            {
                Name = product.Name,
                CreateDate = DateTime.Now,
                Description = product.Description,
                Stock = product.Stock,
            };
            _context.Products.Add(productEntity);
            _context.SaveChanges();
        }

        public ProductEntity GetProductById(int id)
        {
            ProductEntity? product = _context.Products.Find(id);

            if (product == null)
            {
                throw new Exception("the product with id: " + id + " was not found");
            }

            return product;
        }

        public void DeleteProduct(int IdProduct)
        {
            ProductEntity productToDelete = GetProductById(IdProduct);

            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
        }

        public List<ProductEntity> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateProduct(int IdProduct, UpdateProductDTO productUpdated)
        {
            ProductEntity existingProduct = GetProductById(IdProduct);

            existingProduct.Name = productUpdated.Name ?? existingProduct.Name;
            existingProduct.Description = productUpdated.Description ?? existingProduct.Description;

            _context.Products.Update(existingProduct);

            _context.SaveChanges();
        }
    }
}
