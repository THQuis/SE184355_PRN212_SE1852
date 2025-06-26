using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer; // Thêm using để gọi vào DAO

namespace Repositories
{
    // Kế thừa từ interface ICustomerRepositories
    public class CustomerRepositories : ICustomerRepositories
    {
        // --- Bắt đầu Mẫu thiết kế Singleton ---
        private static CustomerRepositories? instance = null;
        private static readonly object instanceLock = new object();

        public static CustomerRepositories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerRepositories();
                    }
                }
                return instance;
            }
        }
        // --- Kết thúc Mẫu thiết kế Singleton ---

        // Constructor private
        private CustomerRepositories() { }

        // Implement phương thức CheckLogin từ interface
        public List<Customer> SearchCustomers(string keyword)
        {
            return CustomerDAO.SearchCustomers(keyword);
        }


        public Customer? CheckLogin(string phone)
        {
            // Gọi trực tiếp đến phương thức static của CustomerDAO
            return CustomerDAO.CheckLogin(phone);
        }
        public List<Customer> GetAllCustomers()
        {
            // Gọi phương thức tương ứng từ DAO
            return CustomerDAO.GetAllCustomers();
        }

        public Customer? GetCustomerById(int id)
        {
            // Gọi phương thức tương ứng từ DAO
            return CustomerDAO.GetCustomerById(id);
        }

        public void AddCustomer(Customer customer)
        {
            // Gọi phương thức tương ứng từ DAO
            CustomerDAO.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            // Gọi phương thức tương ứng từ DAO
            CustomerDAO.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            // Gọi phương thức tương ứng từ DAO
            CustomerDAO.DeleteCustomer(id);
        }
    }
}