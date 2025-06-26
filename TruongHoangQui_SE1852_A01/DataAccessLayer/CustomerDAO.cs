using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    // 1. Chuyển class thành 'static'
    public static class CustomerDAO
    {
        private static readonly List<Customer> Customers = new List<Customer>();

        // 2. Sử dụng 'static constructor' để tự động khởi tạo dữ liệu một lần duy nhất
        static CustomerDAO()
        {
            InitializeDataset();
        }

        // 3. Chuyển thành 'private static'
        private static void InitializeDataset()
        {
            if (!Customers.Any())
            {
                Customers.AddRange(new List<Customer>
        {
            new Customer { CustomerID = 1, CompanyName = "Cửa hàng Tiện lợi 24/7", ContactName = "Lý Thị Ngọc", Phone = "0939888777" },
            new Customer { CustomerID = 2, CompanyName = "Công ty Giao hàng Hỏa tốc", ContactName = "Trần Minh Hoàng", Phone = "0924626416" },
            new Customer { CustomerID = 3, CompanyName = "Cafe Góc Phố", ContactName = "Phạm Thị Hằng", Phone = "0901234567" },
            new Customer { CustomerID = 4, CompanyName = "Sách & Tri thức", ContactName = "Nguyễn Văn Dũng", Phone = "0987456321" },
            new Customer { CustomerID = 5, CompanyName = "Điện máy Hòa Phát", ContactName = "Trần Đức Mạnh", Phone = "0977778888"},
            new Customer { CustomerID = 6, CompanyName = "Thời trang Moon", ContactName = "Lê Thị Bích", Phone = "0934445566" },
            new Customer { CustomerID = 7, CompanyName = "Studio Ảnh Cưới Hạnh Phúc", ContactName = "Phan Quốc Huy", Phone = "0911223344" },
            new Customer { CustomerID = 8, CompanyName = "Cửa hàng Hoa Tươi Xuân", ContactName = "Đoàn Thị Yến", Phone = "0909090909" },
            new Customer { CustomerID = 9, CompanyName = "Shop Mỹ Phẩm Lavender", ContactName = "Ngô Minh Trang", Phone = "0944112233" },
            new Customer { CustomerID = 10, CompanyName = "Hiệu thuốc Tâm An", ContactName = "Vũ Thị Tâm", Phone = "0966554433" },
            new Customer { CustomerID = 11, CompanyName = "Bách hóa Xanh", ContactName = "Đặng Minh Phúc", Phone = "0911888999" },
            new Customer { CustomerID = 12, CompanyName = "Nội thất Phúc Lộc", ContactName = "Hoàng Văn Long", Phone = "0988123456"},
            new Customer { CustomerID = 13, CompanyName = "Tiệm bánh Ngọt Ngào", ContactName = "Trần Kim Oanh", Phone = "0933334444" },
            new Customer { CustomerID = 14, CompanyName = "Văn phòng phẩm Hương Giang", ContactName = "Lý Hoàng Giang", Phone = "0901002003"},
            new Customer { CustomerID = 15, CompanyName = "Siêu thị Thực phẩm Sạch", ContactName = "Phạm Thanh Thủy", Phone = "0966888777" }
        });
            }
        }


        // 4. Chuyển thành 'public static'
        public static Customer? CheckLogin(string phone)
        {
            return Customers.FirstOrDefault(c => c.Phone == phone);
        }

        // 5. Chuyển thành 'public static'
        public static List<Customer> GetAllCustomers()
        {
            return Customers;
        }

        public static Customer? GetCustomerById(int id)
        {
            return Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public static void AddCustomer(Customer customer)
        {
            // Tự động tạo ID mới
            customer.CustomerID = Customers.Max(c => c.CustomerID) + 1;
            Customers.Add(customer);
        }

        public static void UpdateCustomer(Customer customer)
        {
            Customer? existingCustomer = Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
                // Cập nhật các thuộc tính
                existingCustomer.CompanyName = customer.CompanyName;
                existingCustomer.ContactName = customer.ContactName;
                existingCustomer.ContactTitle = customer.ContactTitle;
                existingCustomer.Address = customer.Address;
                existingCustomer.Phone = customer.Phone;
            }
        }

        public static void DeleteCustomer(int id)
        {
            Customer? customerToRemove = Customers.FirstOrDefault(c => c.CustomerID == id);
            if (customerToRemove != null)
            {
                Customers.Remove(customerToRemove);
            }
        }
        public static List<Customer> SearchCustomers(string keyword)
        {
            return Customers
                .Where(c => c.CompanyName.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                            || c.ContactName.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                            || c.Phone.Contains(keyword))
                .ToList();
        }

    }
}