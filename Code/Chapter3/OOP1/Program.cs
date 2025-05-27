// See https://aka.ms/new-console-template for more information

using System.Text;
using OOP1;

Console.OutputEncoding = Encoding.UTF8;
Category c1 = new Category();

c1.Id = 1;
c1.Name = "Nước mắm";
c1.PrintInfor();

Employee employee1 = new Employee();
// Tự gọi set
employee1.id = 1;
employee1.name = "Lê Thị Trà Mi";
employee1.phone = "0924626416";
employee1.email = "truongqui858@gmail.com";
//TỰ gọi get
Console.WriteLine($"Employee ID = {employee1.id}");
Console.WriteLine($"Employee Name = {employee1.name}");
Console.WriteLine($"Employee Phone = {employee1.phone}");
Console.WriteLine($"Employee Email = {employee1.email}");
employee1.PrintInfor();

//Ngoài ra có TO SString giống JAVA
Console.WriteLine("---------------------");
Console.WriteLine(employee1);

Employee employee2 = new Employee(2, "Trương Hoàng Quí", "mi@gmail.com", "113");
Console.WriteLine(employee2);

Employee employee3 = new Employee()
{
    id = 3;
    name = "Lê Thị Trà Mi",
    email = "truongqui858@gmail.com",
    phone = "0924626416"
}
Console.WriteLine(employee3);
