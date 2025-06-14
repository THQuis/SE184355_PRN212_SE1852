// See https://aka.ms/new-console-template for more information
using System.Text;
using OOP2;

/*
 Ứng dụng Generic để quản lý nhân viên, thực hienejk

 */
//câu 1: tạo 5 nhân viên, 4 full và 1 part

List<Employee> employees = new List<Employee>();
FullTimeEmployee fe1 = new FullTimeEmployee()
{
    Id = 1,
    Name = "nam 1",
    IdCard = "123",
    Birthday = new DateTime(1995, 2, 14)
};

employees.Add(fe1);

FullTimeEmployee fe2 = new FullTimeEmployee()
{
    Id = 2,
    Name = "nam 2",
    IdCard = "1232",
    Birthday = new DateTime(1995, 2, 16)
};

employees.Add(fe2);

FullTimeEmployee fe3 = new FullTimeEmployee()
{
    Id = 3,
    Name = "nam 3",
    IdCard = "789",
    Birthday = new DateTime(1995, 2, 11)
};

employees.Add(fe3);

FullTimeEmployee fe4 = new FullTimeEmployee()
{
    Id = 4,
    Name = "nam 4",
    IdCard = "456",
    Birthday = new DateTime(1995, 2, 19)
};

employees.Add(fe4);

PartimeEmployee fe5 = new PartimeEmployee()
{
    Id = 5,
    Name = "nam 5",
    IdCard = "888",
    Birthday = new DateTime(1995, 2, 1),
    WorkingHour = 2
};

employees.Add(fe5);

//Câu 2: xuất toàn bộ thồng tin
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Thông tin toàn bộ nhân sự: ");
//C1: dùng Expresstion body(Lamda Expression)
employees.ForEach(e => Console.WriteLine(e));
//C2 thông thg
Console.WriteLine("Thong thường");
foreach (var e in employees)
{
    Console.WriteLine(e.ToString());
}
//Câu 3 : sắp xếp năm sinh tăng dần
//Cũng là R-Read/Retrieve
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        Employee e1 = employees[i];
        Employee e2 = employees[j];

        if (e1.Birthday < e2.Birthday)
        {
            employees[i] = e2;
            employees[j] = e1;
        }
    }
}
Console.WriteLine("Sau khi sắp xếp ");
employees.ForEach(e => Console.WriteLine(e));
//Câu 5 : sửa
Console.WriteLine("===========Sửa thông tin Nhân viên==========");
Console.WriteLine("Nhập ID cần sửa: ");
int id = int.Parse(Console.ReadLine());
bool found = false;
foreach (Employee e in employees)
{
    if (id == e.Id)
    {
        Console.WriteLine("Nhập tên mới: ");
        e.Name = Console.ReadLine();
        Console.WriteLine("Nhập new IdCard: ");
        e.IdCard = Console.ReadLine();
        Console.WriteLine("Nhập new Birthday: ");
        e.Birthday = DateTime.Parse(Console.ReadLine());

        found = true;
        break;
    }
}
if (!found)
{
    Console.WriteLine("Khong tìm thấy nhân viên với ID.");
}
else
{
    Console.WriteLine("Thông tin Nhân viên sau khi sửa");
    foreach (Employee e in employees)
    {
        if (id == e.Id)
        {
            Console.WriteLine(e);
        }
    }
}
//    Câu 6: xóa

Console.WriteLine("===========Xóa thông tin Nhân viên==========");
Console.WriteLine("Nhập ID cần xóa: ");
int id2 = int.Parse(Console.ReadLine());
bool found2 = false;
foreach (Employee e in employees)
{
    if (id2 == e.Id)
    {
        employees.Remove(e);
        found2 = true;
        break;
    }
}
if (!found2)
{
    Console.WriteLine("Khong tìm thấy nhân viên với ID.");
}
else
{
    Console.WriteLine("Xóa thành công.");
    employees.ForEach(e => Console.WriteLine(e));
}