using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public interface ICustomerRepositories
    {
        List<Customer> SearchCustomers(string keyword);

        Customer? CheckLogin(string phone);
        // Lấy toàn bộ danh sách khách hàng
        List<Customer> GetAllCustomers();

        // Lấy một khách hàng theo ID
        Customer? GetCustomerById(int id);

        // Thêm một khách hàng mới
        void AddCustomer(Customer customer);

        // Cập nhật thông tin một khách hàng
        void UpdateCustomer(Customer customer);

        // Xóa một khách hàng theo ID
        void DeleteCustomer(int id);
       

    }
}
