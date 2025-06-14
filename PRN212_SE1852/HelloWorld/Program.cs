// See https://aka.ms/new-console-template for more information
using System.Text;

namespace HelloWord
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // var dùng khi không biết kiểu gì?
            //dynamic type > obj type , dynamic type nó sẽ ko cần khai báo trc, linh động
            //nhược điểm : debugg khó.

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Tôi là người đẹp trai nhất thế giới <3");

            Console.ReadLine();
        }
    }
}