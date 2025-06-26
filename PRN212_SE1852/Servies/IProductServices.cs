using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Servies
{
    public interface IProductServices
    {
        public List<Product> GetProducts();
        public void InitializeDataset();
        public bool SaveProduct(Product p);

    }
}
