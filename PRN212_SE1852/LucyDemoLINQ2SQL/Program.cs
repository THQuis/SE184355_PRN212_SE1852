using System.Text;
using LucyDemoLINQ2SQL;

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

// Câu 2: Tìm 3 khách hàng có tổng giá trị đơn hàng cao nhất
var top3Customers = (from c in context.Customers
                     where c.Orders.Any()
                     select new
                     {
                         Customer = c,
                         TotalValue = c.Orders.Sum(o => o.Order_Details.Sum(od => od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount)))
                     })
                     .OrderByDescending(x => x.TotalValue)
                     .Take(3);

Console.WriteLine("\nTop 3 khách hàng có tổng giá trị đơn hàng cao nhất:");
foreach (var item in top3Customers)
{
    Console.WriteLine($"{item.Customer.CustomerID} - {item.Customer.CompanyName} : {item.TotalValue:C}");
}