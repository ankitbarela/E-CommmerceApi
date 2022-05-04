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

            Products[] Product = new Products[6];
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
            Product[3] = new Products
            {
                Id = 4,
                Name = "Karpos Shoes",
                Size = "39 - 43",
                Color = "Brown, Black",
                Price = "19500",
                Public_id = "store/store7_rkjrdo",
                QuantityInStock = 50
            };
            Product[4] = new Products
            {
                Id = 5,
                Name = "Rainbow T-shirt",
                Size = "S, M, L",
                Color = "As seen in the picture",
                Price = "5000",
                Public_id = "store/store11_td1at8",
                QuantityInStock = 50
            };
            Product[5] = new Products
            {
                Id = 6,
                Name = "Gregory Shoes",
                Size = "37 - 40",
                Color = "Yellow, Black",
                Price = "10500",
                Public_id = "store/store5_sht2jx",
                QuantityInStock = 10
            };
            return Product;
        }
    }
}
