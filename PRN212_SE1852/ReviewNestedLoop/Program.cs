// See https://aka.ms/new-console-template for more information

using System.Text;

void hinh1(int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == (n - 1) || i == j)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }// for này cột
        Console.WriteLine();
    }
}

//hinh1(10);
// Sắp xếp mảng tăng dần dùng do while lồng nhau

void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

// mảng mang nội tại của ref không cânf phải khai báo
void mysort(int[] arr)
{
    int i = 0;
    int j = i + 1;
    do
    {
        do
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        } while (j < arr.Length - 1);
        i++;
        j = i + 1;
    } while (i < arr.Length - 1);
}

Console.OutputEncoding = Encoding.UTF8;
int[] arr = { 10, 3, 7, 2, 9, 5, 4 };
Console.WriteLine("Mẳng trước khi sắp xếp: ");
foreach (int i in arr)
{
    Console.Write($"{i}\t");
}
Console.WriteLine("\nMẳng sau khi sắp xếp: ");
mysort(arr);
foreach (int i in arr)
{
    Console.Write($"{i}\t");
}