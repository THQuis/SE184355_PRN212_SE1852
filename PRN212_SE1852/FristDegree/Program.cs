// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phương Trình bậc 1 !!!!!!!");
Console.WriteLine("Nhập hệ số a: ");
double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập hệ sôs b: ");
double b = Double.Parse(Console.ReadLine());

if (a == 0 && b == 0)
{
    Console.WriteLine("Phương Trình vô no");
}
else if (a == 0 && b != 0)
{
    Console.WriteLine("Phương trình vô no");
}
else
{
    Console.WriteLine("Phương trình có nghiệm x = {0}", b / a);
}

Console.ReadLine();