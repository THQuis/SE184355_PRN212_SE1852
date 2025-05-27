// See https://aka.ms/new-console-template for more information
using OOP2;
using OOP2_Reuse;

FullTimeEmployee e1 = new FullTimeEmployee();
e1.Id = 1;
e1.Name = "Name";
e1.Birthday = new DateTime(2004, 2, 15);
Console.WriteLine("----Thông tin e1----");
Console.WriteLine(e1);
Console.WriteLine("Age => " + e1.TinhTuoi());