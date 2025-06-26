using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;    // Thêm using để nhận biết đối tượng Customer
using Repositories;       // Thêm using để gọi vào lớp Repositories

namespace Services
{
    // 1. Kế thừa từ interface ICustomerServices
    public class CustomerServices : ICustomerServices
    {
        // 2. Khai báo một "cầu nối" đến lớp Repository
        private readonly ICustomerRepositories iCustomerRepositories;

        // 3. Constructor của lớp Service
        public CustomerServices()
        {
            // Lấy instance duy nhất (Singleton) của CustomerRepositories
            iCustomerRepositories = CustomerRepositories.Instance;
        }

        // 4. Implement phương thức Login đã được định nghĩa trong interface
        public Customer? Login(string phone)
        {
            // Xử lý các quy tắc nghiệp vụ (nếu có)
            if (string.IsNullOrEmpty(phone))
            {
                return null;
            }

            // Gọi xuống lớp Repository để kiểm tra trong "cơ sở dữ liệu"
            return iCustomerRepositories.CheckLogin(phone);
        }

        public List<Customer> GetAllCustomers()
        {
            return iCustomerRepositories.GetAllCustomers();
        }

        public void AddCustomer(Customer customer)
        {
            iCustomerRepositories.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            iCustomerRepositories.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            iCustomerRepositories.DeleteCustomer(id);
        }

        public List<Customer> SearchCustomers(string keyword)
        {
            return iCustomerRepositories.SearchCustomers(keyword);
        }

    }
}