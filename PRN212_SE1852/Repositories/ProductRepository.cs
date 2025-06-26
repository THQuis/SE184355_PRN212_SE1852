using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductDAO productDao = new ProductDAO();

        public List<Product> GetProducts()
        {
            return productDao.GetProducts();
        }

        public void InitializeDataset()
        {
            productDao.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return productDao.SaveProduct(p);
        }
    }
}