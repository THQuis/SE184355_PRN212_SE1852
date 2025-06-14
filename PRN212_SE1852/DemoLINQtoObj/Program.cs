using System.Text;

Console.OutputEncoding = Encoding.UTF8;

/*
 * Dùng LINQ to obj để xuất các số chẵn trong danh sách
 *
 */
int[] arr = { 100, 35, 80, 17, 22, 40, 70, 33, 18 };
//Ccahs 1: Dùng Method syntax(Extension method)
var even_List = arr.Where(x => x % 2 == 0);
Console.WriteLine("Danh sách các số chẵn theo method syntax:");
foreach (var x in even_List)
{
    Console.WriteLine(x + "\t");
}

//Cách 2: Dùng Query Syntax (cú pháp tương tự SQL)
var even_List2 = from x in arr
                 where x % 2 == 0
                 select x;
Console.WriteLine("Danh sách các số chẵn theo Query syntax:");
foreach (var x in even_List2) Console.WriteLine(x + "\t");

//Sắp xếp mangr tăng dần và giảm dần
// dùng method và query syntax
var list_asc = arr.OrderBy(x => x);
var list_desc = arr.OrderByDescending(x => x);
//Dùng Query
var list_asc2 = from x in arr
                orderby x
                select x;
var list_desc2 = from x in arr
                 orderby x descending
                 select x;

//tính tổng danh sách
Console.WriteLine("Tổng: " + arr.Sum());
Console.WriteLine("Điếm số chẵn: " + arr.Where(x => x % 2 == 0));