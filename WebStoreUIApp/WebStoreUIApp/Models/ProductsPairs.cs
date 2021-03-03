using System;

namespace WebStoreUIApp.Models
{
    public class ProductsPairs : Tuple<Product, Product>
    {
        public ProductsPairs(Product item1, Product item2)
            : base(item1, item2 ?? CreateEmptyModel())
        {
        }

        private static Product CreateEmptyModel()
        {
            return new Product
            {
                Name = "",
                ImagePath = "",
                Price = 0
            };
        }
    }
}