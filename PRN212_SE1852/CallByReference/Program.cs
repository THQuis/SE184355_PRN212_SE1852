// See https://aka.ms/new-console-template for more information
void doiCho(ref int a, ref int b)
{
    int temp = a; // dg hiểu là a chưa có giá trị nên out bị lỗi , sử dụng ref cho trg hợp này
    a = b;
    b = temp;
    Console.WriteLine("a trong hàm = " + a);
    Console.WriteLine("b trong hàm = " + b);
}

int a = 5;
int b = 7;
Console.WriteLine("a trc khi vào hàm =" + a);
Console.WriteLine("b trc khi vào hàm =" + b);
doiCho(ref a, ref b);
Console.WriteLine("a sau khi vào hàm =" + a);
Console.WriteLine("b sau khi vào hàm =" + b);
Console.ReadLine();