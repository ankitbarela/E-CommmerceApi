using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_CommerceApi
{
    public class ProductData
    {
        public IEnumerable<Products> GetProducts()
        {
            //var  prod = new List<Products>();

            Products[] Product = new Products[3];
            Product[0] = new Products
            {
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
            Product[2] = new Products
            {
                Id = 3,
                Name = "McPherson Summer T-shirt",
                Size = "S, M, L",
                Color = "Green",
                Price = "3500",
                Public_id = "store/store3_ph4qw4",
                QuantityInStock = 50
            };
            return Product;
        }
    }
}
