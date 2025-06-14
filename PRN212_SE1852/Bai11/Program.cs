using System.Text;

namespace Bai11
{
    internal class Program
    {
        public static string GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0 && c == 0)
                {
                    return "Phương Trình vô số nghiệm";
                }
                if (b == 0 && c != 0)
                {
                    return "vô nghiệm";
                }
                else
                {
                    return "x =  " + ((double)-c / b);
                }
            }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    return "Vô nghiệm";
                if (delta == 0)
                {
                    double x = -b / 2 * a;
                    return "No kép x1=x2 = " + x;
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    return "x1=" + x1 + "; x2 = " + x2;
                }
            }
        }

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string kp = GiaiPhuongTrinhBac2(0, 0, 0);
            Console.WriteLine(kp);

            kp = GiaiPhuongTrinhBac2(0, 0, 5);
            Console.WriteLine(kp);

            kp = GiaiPhuongTrinhBac2(0, 8, 3);
            Console.WriteLine(kp);

            kp = GiaiPhuongTrinhBac2(2, 5, -7);
            Console.WriteLine(kp);
            Console.ReadLine();
        }
    }
}