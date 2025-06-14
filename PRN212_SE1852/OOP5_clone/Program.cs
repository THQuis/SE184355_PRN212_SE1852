// See https://aka.ms/new-console-template for more information

using System.Xml;
using OOP5_clone;

Customer c1 = new Customer();
c1.Id = 1;
c1.Name = "Obama";
Customer c2 = c1;
//lúc này c1 và c2 cùng trở tới 1 ô nhớ
// 1 ô chớ từ 2 đối tuọng trở lên trở vào  ==> alias
// c1 đổ làm c2 đổi và ngược lại
Customer c3 = c1.copy();
//lúc này sao chép toàn bộ dữ liệu tại ô nhớ c1 dg quản lý
//sang 1 ô nhớ mới hoàn toàn và giao cho c3 quản lý
//lúc này c3 đổi không liên quan c1 và ngược lại

Product p1 = new Product()
{ Id = 1, Name = "Coca", quantity = 10, price = 100 };

Product p2 = new Product()
{ Id = 2, Name = "Pepsi", quantity = 15, price = 70 };

p1 = p2;
p2.Name = "Sting";
p2.price = 205.99;

Console.WriteLine("Thông tin p1: ");
Console.WriteLine(p1); // Output: 2       Sting   15      205.99, bộ nhớ p1 bị hu hồi

Product p3 = new Product() { Id = 3, Name = "7UP", quantity = 20, price = 20 };
Product p4 = new Product() { Id = 4, Name = "Suprise", quantity = 9, price = 25 };
Product p5 = new Product() { Id = 5, Name = "Tà tưa", quantity = 90, price = 11 };

p5 = p3;
p3 = p4;
Console.WriteLine("---p5---");
Console.WriteLine(p5);
Console.WriteLine("---p3---");
Console.WriteLine(p3);
// hỏi: ô nhớ chấp phát cho p3 có tự động thu hồi hay khôg?

Product p6 = new Product() { Id = 6, Name = "P6", quantity = 90, price = 11 };

Product p7 = p6;
//lúc này HĐH sẽ cấp pháp 1 ô nhớ mới cho p7 quản lý
//và ô nhớ này có giá trị y chang giá trị của ô nhớ mà p6 dg quản lí
// atucws là p6  và p7 quản lý 2 ô nhớ khác nhau hboanf toàn
//p6 đổi ko liên can gì p7 và ngược lại
//=> ko phải Alias
Console.WriteLine("---p6---");
Console.WriteLine(p6);
Console.WriteLine("---P7---");
Console.WriteLine(p7);

p7.Name = "NIce";
Console.WriteLine("\r\np7.Name = \"NIce\";");
Console.WriteLine(p7);