using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "this will be many products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "just a product";
        }
    }
}