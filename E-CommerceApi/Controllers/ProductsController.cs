using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_CommerceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
       
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Products> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new Products
            {
                Id = 1,
                Name = "Ore Sweater",
                Size = "M, XL, XXL",
                Color = "Custom made to what you want",
                Price = "15000",
                Public_id = "store/store4_rlkr3u",
                QuantityInStock = 20
            });
            
        }
    }
}
