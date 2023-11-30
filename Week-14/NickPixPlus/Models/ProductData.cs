namespace NickPixPlus.Models
{
    public class ProductData
    {
        public static List<ProductModel> GetProducts()
        {
            List<ProductModel> products = new List<ProductModel>();

            products.Add(new ProductModel()
            {
                ProductId = 1,
                ProductName = "The Shawshank Redemption",
                ProductDescription = "Starring Tom Hanks",
                ProductImage = "shawshank.jpg",
                ProductPrice = 5
            });

            products.Add(new ProductModel()
            {
                ProductId = 2,
                ProductName = "The Matrix",
                ProductDescription = "Starring Keanu Reeves",
                ProductImage = "matrix.jpg",
                ProductPrice = 6
            });

            products.Add(new ProductModel()
            {
                ProductId = 3,
                ProductName = "The Shining",
                ProductDescription = "Starring Jack Nicholson",
                ProductImage = "shining.jpg",
                ProductPrice = 7
            });

            return products;
        }
        public static ProductModel GetProduct(int id)
        {
            List<ProductModel> products = ProductData.GetProducts();
            foreach (ProductModel product in products)
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }
            return new ProductModel();
        }
    }
}
