using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRepository;

        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }

        public void SaveProduct(Product product) 
        {
            iProductRepository.SaveProduct(product);
        }

        public void DeleteProduct(Product product)
        { 
            iProductRepository.DeleteProduct(product);
        }

        public void UpdateProduct(Product product) 
        {
            iProductRepository.UpdateProduct(product);
        }

        public List<Product> GetProducts()
        {
            return iProductRepository.GetProducts();
        }

        public Product GetProductById(int productId)
        {
            return iProductRepository.GetProductById(productId);
        }
    }
}
