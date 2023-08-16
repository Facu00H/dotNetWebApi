using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Features.Products.DTOs;
using WebApplication1.Features.Products.Models;
using WebApplication1.Features.Products.Service;

namespace WebApplication1.Features.Products.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("getProducts")]
        public IActionResult GetAllProducts()
        {
            List<ProductEntity> product = _productService.GetAllProducts();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] CreateProductDTO product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }

        [HttpDelete]
        [Route("deleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

        [HttpGet]
        [Route("getProducts/{id}")]
        public IActionResult GetProduct(int id)
        {
            ProductEntity product = _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPatch]
        [Route("UpdateProduct/{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] UpdateProductDTO product)
        {
            _productService.UpdateProduct(id, product);
            return Ok();
        }
    }
}
