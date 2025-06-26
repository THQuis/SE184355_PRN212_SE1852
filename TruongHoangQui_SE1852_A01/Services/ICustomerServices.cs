using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Services
{
    public interface ICustomerServices
    {
        Customer? Login(string phone);
        List<Customer> GetAllCustomers();

        // Thêm một khách hàng mới
        void AddCustomer(Customer customer);

        // Cập nhật thông tin một khách hàng
        void UpdateCustomer(Customer customer);

        // Xóa một khách hàng theo ID
        void DeleteCustomer(int id);

        // Tìm kiếm khách hàng theo tên (hoặc tiêu chí khác)
        List<Customer> SearchCustomers(string keyword);

    }
}
