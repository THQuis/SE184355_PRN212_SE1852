// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string ho = "Trương";
string tenLot = "Hoàng";
string ten = "Quí";

string fullName = ho + " " + tenLot + " " + ten;
Console.WriteLine(fullName);
//StringBuilder là lớp dùng để nối chuỗi hiệu quả hơn + trong Java,
//nhất là khi thực hiện nhiều lần nối.
StringBuilder sb = new StringBuilder();
sb.Append(ho);//append() là phương thức dùng để thêm chuỗi vào đối tượng StringBuilder.
sb.Append(" ");
sb.Append(tenLot);
sb.Append(" ");
sb.Append(ten);

string nam2 = sb.ToString();//"<ho> <tenLot> <ten>"

Console.WriteLine(nam2);

Console.ReadLine();