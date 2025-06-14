//nhân sự  có mã tên lương,
using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FullTimeEmployee teo = new FullTimeEmployee();
teo.Id = 1;
teo.Name = "Quí";
Console.WriteLine("Lương của Teo= " + teo.calSalary());
//teo.Birthday = "07/09/2004";

PartimeEmployee ty = new PartimeEmployee();
ty.WorkingHour = 2;
ty.Name = "Trần Mình Tý";
ty.Id = 2;
Console.WriteLine("Lương của Tý= " + ty.calSalary());

FullTimeEmployee obama = new FullTimeEmployee()
{
    Id = 100,
    Name = "Barac Obama",
    Birthday = new DateTime(1960, 1, 25),
    IdCard = "123"
};
Console.WriteLine("=========Thông tin của Obama============");
Console.WriteLine(obama);

PartimeEmployee trump = new PartimeEmployee()
{
    Id = 200,
    IdCard = "456",
    Name = "Donal Trump",
    Birthday = new DateTime(1940, 12, 26),
    WorkingHour = 3
};
Console.WriteLine("=========Thông tin của Trump============");
Console.WriteLine(trump);