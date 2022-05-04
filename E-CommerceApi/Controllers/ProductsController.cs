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
        //readonly Products[] Product;
        ////{
        ////     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //// };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Products> Get()
        {
           var  prod = new List<Products>();

            Products[] Product = new Products[2];
            Product[0] = new Products { 
            Id = 1,
            Name = "Ore Sweater",
            Size = "M, XL, XXL",
            Color = "Custom made to what you want",
            Price = "15000",
            Public_id = "store / store4_rlkr3u",
            QuantityInStock = 20
            };
            Product[1] = new Products
            {
                Id = 2,
                Name = "McPherson T-shirt",
                Size = "S, M, L",
                Color = "White",
                Price = "4000",
                Public_id = "store/store2_iuj9gd",
                QuantityInStock = 13
            };
            return Product;
        }
    }
}
