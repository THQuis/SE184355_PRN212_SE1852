using System.Text;
using LucyDemoLINQ2SQL2;

Console.OutputEncoding = Encoding.UTF8;

string connectionString = "Server=localhost;database=Lucy_SalesData;uid=sa;pwd=12345";

Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
// cau1 xuẩt dnah sách khách hàng có mua hàng

var ds1 = from c in context.Customers
          where c.Orders.Any()
          select c;
Console.WriteLine("Danh sách khách hàng đã từng mua hàng:");
foreach (var customer in ds1)
{
    Console.WriteLine($"{customer.CustomerID} - {customer.CompanyName}");
}