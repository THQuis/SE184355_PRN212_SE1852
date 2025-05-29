// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//bc 1: ứng dụng out kiểm tra nhập hợp lệ khi nào đúng thì mới dừng

int n;
Console.Write("Nhập n >= 0: ");
string s = Console.ReadLine();
if (int.TryParse(s, out n) == false)
{
    Console.WriteLine("Bạn phải nhập số");
}
else
{
    if (n < 0)
    {
        Console.WriteLine("n phải lớn hơn 0.");
    }
    else
    {
        //Thực thi tính giai thừa
        int gt = 1;
        for (int i = 2; i <= n; i++)
        {
            gt *= i;
        }
        Console.WriteLine("Giai thừa = " + gt);
    }
}

Console.ReadLine();