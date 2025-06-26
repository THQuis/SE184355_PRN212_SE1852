using System.Collections.Generic;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepositories productRepositories;

        public ProductServices()
        {
            productRepositories = ProductRepositories.Instance;
        }

        public List<Product> GetAllProducts()
        {
            return productRepositories.GetAllProducts();
        }

        public Product? GetProductById(int id)
        {
            return productRepositories.GetProductById(id);
        }

        public void AddProduct(Product product)
        {
            productRepositories.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepositories.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            productRepositories.DeleteProduct(id);
        }

        public List<Product> SearchProducts(string keyword)
        {
            return productRepositories.SearchProducts(keyword);
        }
    }
}