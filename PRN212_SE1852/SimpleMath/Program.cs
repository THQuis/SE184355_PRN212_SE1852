// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string do_Math(double a, double b, string op)
{
    string result = "";
    switch (op)
    {
        case "+":
            result = a + "+" + b + "= " + (a + b);
            break;

        case "-":
            result = a + "-" + b + "= " + (a - b);
            break;

        case "*":
            result = a + "*" + b + "= " + (a * b);
            break;

        case "/":
            if (b == 0)
            {
                result = "Mâuc khác không";
            }
            else
            {
                result = a + "/" + b + "= " + (a / b);
            }
            break;

        default:
            result = "Nhập sai cú pháp";
            break;
    }
    return result;
}

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Nhập a: ");
double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập b: ");
double b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập phép toán: + - * /");
String op = Console.ReadLine();
Console.WriteLine(do_Math(a, b, op));
Console.ReadLine();