using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> products = new List<Product>();

        public void InitializeDataset()
        {
            products.Add(new Product() { Id = 1, Name = "Coca", Quantity = 10, Price = 200.5 });
            products.Add(new Product() { Id = 2, Name = "pepsi", Quantity = 10, Price = 200.5 });
            products.Add(new Product() { Id = 3, Name = "IshowSpeed", Quantity = 10, Price = 10.5 });
            products.Add(new Product() { Id = 4, Name = "Messi", Quantity = 10, Price = 210.5 });
            products.Add(new Product() { Id = 5, Name = "Ronaoldorado", Quantity = 10, Price = 5500 });
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public bool SaveProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old != null)
            {
                return false;
            }

            products.Add(p);
            return true;
        }
    }
}