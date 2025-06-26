using System.Collections.Generic;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        // Singleton pattern (tuỳ chọn, nếu bạn đang áp dụng giống CustomerRepositories)
        private static ProductRepositories? instance = null;
        private static readonly object instanceLock = new object();

        public static ProductRepositories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductRepositories();
                    }
                    return instance;
                }
            }
        }

        // Constructor private
        private ProductRepositories() { }

        public List<Product> GetAllProducts()
        {
            return ProductDAO.GetAllProducts();
        }

        public Product? GetProductById(int id)
        {
            return ProductDAO.GetProductById(id);
        }

        public void AddProduct(Product product)
        {
            ProductDAO.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            ProductDAO.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            ProductDAO.DeleteProduct(id);
        }

        public List<Product> SearchProducts(string keyword)
        {
            return ProductDAO.SearchProducts(keyword);
        }
    }
}