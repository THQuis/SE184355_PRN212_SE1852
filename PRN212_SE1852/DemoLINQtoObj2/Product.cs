using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQtoObj2
{
    internal class Product

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{quantity}\t{price}";
        }

        public Product clone()
        {
            return MemberwiseClone() as Product;
        }
    }
}