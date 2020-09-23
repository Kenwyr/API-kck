using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Data;
//using API.Services.ProductService;

namespace API.Controllers
{

    [ApiController]
    [Route("API/[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product> {
            new Product(),
            new Product { Id = 1 , Title = "Kilde blå"}
        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }
 
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(products.FirstOrDefault(c => c.Id == id));
        }

    }
}