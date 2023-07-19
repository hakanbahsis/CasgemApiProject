using Casgem.BusinessLayer.Abstract;
using Casgem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.ApiLayer.Controllers
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

        [HttpGet("productList")]
        public IActionResult ProductList()
        {
            var values = _productService.GetAll();
            return Ok(values);
        }

        [HttpPost("productAdd")]
        public IActionResult AddProduct(Product product)
        {
            
                _productService.Add(product);
                return Ok(product);
        }

        [HttpDelete("productDelete")]
        public IActionResult DeleteProduct(int id)
        {
            var values=_productService.GetById(id);
            _productService.Delete(values);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.GetById(id);
          
                return Ok(values);
        }

        [HttpGet("GetProductsListWithCategories")]
        public IActionResult GetProductsListWithCategories()
        {
            var values = _productService.TGetProductsWithCategories();
            return Ok(values);
        }

        [HttpPut("updateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.Update(product);
            return Ok(product);
        }
    }
}
