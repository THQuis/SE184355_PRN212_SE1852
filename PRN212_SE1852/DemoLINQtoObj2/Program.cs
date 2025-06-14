// See https://aka.ms/new-console-template for more information
using System.Text;
using DemoLINQtoObj2;

Console.OutputEncoding = Encoding.UTF8;
ListProduct lp = new ListProduct();
//Giả lập dữ liệu
lp.gen_sample_products();
Console.WriteLine("Danh sách products:");
lp.PrintProducts();
Console.WriteLine("Danh sách sản phẩm có giá trị từ 80 -> 100:");
lp.FillterProductByPrice(80, 100);

Console.WriteLine("Danh sách sản phẩm có giá trị  DESC từ 70 -> 100:");
lp.FillterProductByPriceDesc(80, 100);