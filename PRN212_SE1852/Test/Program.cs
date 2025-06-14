using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string unusedVariable = "I am not used";

            List<string> names = new List<string> { "Alice", "Bob", null, "Charlie", "" };

            foreach (var name in names)
            {
                if (name.Length > 0)
                {
                    Console.WriteLine(name);
                }

                if (name == "ZZZ")
                {
                    Console.WriteLine("This won't happen");
                }
            }

            int a = 5, b = 10;
            if ((a + b) > 10)
            {
                Console.WriteLine("Sum > 10");
            }

            if ((a + b) > 10)
            {
                Console.WriteLine("This is duplicated logic");
            }

            // ❌ Có thể dùng LINQ thay cho vòng lặp bên trên
        }
    }
}