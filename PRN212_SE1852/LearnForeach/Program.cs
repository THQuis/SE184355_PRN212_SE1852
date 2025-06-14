// See https://aka.ms/new-console-template for more information
//Hãy viết hàm có khả năng nhập vào bất kì phần tử nào
//và trả về tất cả phần tử đó

using System.Text;

int sums(params int[] arr)
{
    int s = 0;
    foreach (int i in arr)
    {
        s += i;
        Console.Write(i + " ");
    }
    return s;
}
Console.OutputEncoding = Encoding.UTF8;
int s1 = sums(1);
int s2 = sums(1, 8);
int s3 = sums(12, 5, 10);

Console.WriteLine($"\ns1={s1}; s2={s2}; s3={s3}");

// sử dụng do while for lồng nhau để vẽ 