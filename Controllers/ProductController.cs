using inventoryApi.Domain;
using inventoryApi.Domain.Contracts;
using inventoryApi.Services;
using Microsoft.AspNetCore.Mvc;
namespace inventoryApi.Controllers
{
    [Route("inventory")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("product")]
        public async Task<ActionResult<Response<List<Product>>>> AllProducts()
        {
            var response = await _productService.GetProducts();
            return response;
        }

        [HttpGet("/searchProduct")]
        public async Task<ActionResult<Response<List<Product>>>> Search( [FromQuery] string search)
        {
            Console.WriteLine("this is called");
            var response = await _productService.SearchProduct(search);
            return response;
        }

    }
}