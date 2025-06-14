// See https://aka.ms/new-console-template for more information

using System.Text;
using OOP4_Dictionary;

Console.OutputEncoding = Encoding.UTF8;

Category laptop = new Category();
laptop.Id = 1;
laptop.Name = "Danh mục lapTop";

Product dell = new Product()
{
    Id = 1,
    Name = "Dell1",
    Quantity = 100,
    Price = 25000000
};
laptop.AddProduct(dell);

Product dell2 = new Product()
{
    Id = 2,
    Name = "Dell 2",
    Quantity = 10,
    Price = 2500000
};
laptop.AddProduct(dell2);

Product acer = new Product()
{
    Id = 3,
    Name = "Acer 5",
    Quantity = 5,
    Price = 8000000
};
laptop.AddProduct(acer);

Product acer2 = new Product()
{
    Id = 4,
    Name = "Acer 4",
    Quantity = 7,
    Price = 8000000
};
laptop.AddProduct(acer2);

//Console.WriteLine("Danh sách sản phẩm của danh mục laptop");
//laptop.PrintsAllProduct();
//bool f = true;
//do
//{
//    Console.WriteLine("Nhập mã sản phẩm muốn tìm: ");
//    int pid = int.Parse(Console.ReadLine());
//    Product p = laptop.GetProduct(pid);

//    if (p == null)
//    {
//        Console.WriteLine("Không tìm thấy sản phẩm huhu!!!!!!!");
//    }
//    else
//    {
//        Console.WriteLine("Đã tìm thấy sản phẩm pid {0}: ", pid);
//        Console.WriteLine(p);
//        f = false;
//    }
//}
//while (f == true);

//Console.WriteLine("Danh sách chưa sắp xếp: ");
//laptop.PrintsAllProduct();
//Dictionary<int, Product> SortProduct = laptop.SortProduct();
//Console.WriteLine("Sau khi sắp xếp: ");
//foreach (KeyValuePair<int, Product> item in SortProduct)
//{
//    Product x = item.Value;
//    Console.WriteLine(x);
//}

Console.WriteLine("Danh sách chưa sắp xếp: ");
laptop.PrintsAllProduct();

Dictionary<int, Product> SortProduct2 = laptop.ComplexSort();
Console.WriteLine("Sau khi sắp xếp: ");
foreach (KeyValuePair<int, Product> item in SortProduct2)
{
    Product x = item.Value;
    Console.WriteLine(x);
}

Product px = new Product();
px.Id = 1;
px.Name = "Mac Book 1000";
px.Quantity = 50;
px.Price = 1000;
laptop.EditProduct(px);
Console.WriteLine("---Danh sách sản phẩm khi sửa---");
laptop.PrintsAllProduct();

int pid_remove = 1;
laptop.RemoveProduct(pid_remove);
Console.WriteLine("---Dánh sách sản phẩm sau khi xóa---");
laptop.PrintsAllProduct();

Console.ReadLine();