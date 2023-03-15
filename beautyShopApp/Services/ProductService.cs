

using beautyShopApp.Models;

namespace beautyShopApp.Services
{
    public class ProductService
    {
        static ProductService _instance;

        public static ProductService Instance
        {
            get
            { return _instance ?? (_instance = new ProductService()); }
        }

        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "Moisturiser",
                    Image = "moisturiser_01.png",
                    Description = "Oil balancing mask",
                    Price = 11.99,
                },
                new Product
                {
                    Name = "Moisturiser",
                    Image = "moisturiser_01.png",
                    Description = "Oil balancing mask",
                    Price = 11.99,
                },
                new Product
                {
                    Name = "Moisturiser",
                    Image = "moisturiser_01.png",
                    Description = "Oil balancing mask",
                    Price = 11.99,
                },
                new Product
                {
                    Name = "Moisturiser",
                    Image = "moisturiser_01.png",
                    Description = "Oil balancing mask",
                    Price = 11.99,
                },
                new Product
                {
                    Name = "Moisturiser",
                    Image = "moisturiser_01.png",
                    Description = "Oil balancing mask",
                   Price = 11.99,
                },

            };
        }
    }
}
        

