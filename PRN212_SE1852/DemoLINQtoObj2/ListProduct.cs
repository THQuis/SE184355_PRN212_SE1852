namespace DemoLINQtoObj2
{
    public class ListProduct
    {
        private List<Product> products;

        public ListProduct()
        {
            products = new List<Product>();
        }

        public void gen_sample_products()
        {
            products.Add(new Product() { Id = 1, Name = "p1", quantity = 10, price = 100 });
            products.Add(new Product() { Id = 2, Name = "p2", quantity = 10, price = 85 });
            products.Add(new Product() { Id = 3, Name = "p3", quantity = 8, price = 60 });
            products.Add(new Product() { Id = 4, Name = "p4", quantity = 20, price = 70 });
            products.Add(new Product() { Id = 5, Name = "p5", quantity = 15, price = 100 });
            products.Add(new Product() { Id = 6, Name = "p6", quantity = 24, price = 89 });
            products.Add(new Product() { Id = 7, Name = "p7", quantity = 30, price = 80 });
            products.Add(new Product() { Id = 8, Name = "p8", quantity = 2, price = 100 });
            products.Add(new Product() { Id = 9, Name = "p9", quantity = 90, price = 100 });
            products.Add(new Product() { Id = 10, Name = "p10", quantity = 70, price = 100 });
        }

        public void PrintProducts()
        {
            products.ForEach(p => Console.WriteLine(p));
        }

        public void FillterProductByPrice(double price1, double price2)
        {
            var result = products.Where(p => p.price >= price1 && p.price <= price2);
            result.ToList().ForEach(p => Console.WriteLine(p));
        }

        public void FillterProductByPriceDesc(double price1, double price2)
        {
            var result = from p in products
                         where p.price >= price1 && p.price < price2
                         orderby p.price descending
                         select p;
            result.ToList().ForEach(p => Console.WriteLine(p));
        }

        public void FillterProductByQuantity(int p1, int p2)
        {
            var result = from p in products
                         where p.quantity >= p1 && p.quantity <= p2
                         select new { p.Id, p.Name };

            foreach (var p in result)
            {
                Console.WriteLine(p.Id + "\t" + p.Name);
            }
        }
    }
}