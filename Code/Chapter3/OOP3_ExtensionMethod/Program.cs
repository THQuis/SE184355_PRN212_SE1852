﻿// See https://aka.ms/new-console-template for more information
using System.Text;
using OOP3_ExtensionMethod;

Console.OutputEncoding = Encoding.UTF8;

int n1 = 5;
int n2 = 10;
Console.WriteLine("Tổng n1 = " + n1.TongTu1ToiN());
Console.WriteLine("Tổng n2 = " + n2.TongTu1ToiN());

// sắp tăng dần của mảng có kiểu Int

int[] M = new int[10];
M.TaoMangNgauNhien();
Console.WriteLine("Mẳng trc khi sắp xếp");
M.xuatMang();
M.SapXepTangDan();
Console.WriteLine("Mảng sau khi sắp xếp");
M.xuatMang();