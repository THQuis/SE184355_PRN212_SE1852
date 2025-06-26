using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using Repositories;

namespace Servies
{
    public class ProductServices:IProductServices
    {
        private readonly IProductRepository iProductRepository;

        public ProductServices()
        {
            iProductRepository = new ProductRepository();
        }
        public List<Product> GetProducts()
        {
            return iProductRepository.GetProducts();
        }

        public void InitializeDataset()
        {
            iProductRepository.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return iProductRepository.SaveProduct(p);
        }
    }
}
