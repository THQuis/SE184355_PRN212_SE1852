using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;    // Thêm using để nhận biết đối tượng Employee
using Repositories;       // Thêm using để gọi vào lớp Repositories

namespace Services
{
    // Kế thừa từ interface IEmployeeServices
    public class EmployeeServices : IEmployeeServices
    {
        // Khai báo một đối tượng repository để sử dụng
        // Dùng 'private readonly' để đảm bảo nó được gán một lần duy nhất trong constructor
        private readonly IEmployeeRepositories iEmployeeRepositories;

        // Constructor của lớp Service
        public EmployeeServices()
        {
            // Lấy instance duy nhất (Singleton) của EmployeeRepositories
            // Đây là lúc tầng Service và tầng Repository được kết nối với nhau
            iEmployeeRepositories = EmployeeRepositories.Instance;
        }

        // Implement phương thức Login đã được định nghĩa trong interface
        public Employee? Login(string username, string password)
        {
            // --- Đây là nơi để xử lý các quy tắc nghiệp vụ ---
            // Ví dụ: Kiểm tra xem username và password có rỗng không
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null; // Hoặc ném ra một lỗi (Exception)
            }

            // Sau khi kiểm tra nghiệp vụ, gọi xuống lớp Repository để kiểm tra trong "cơ sở dữ liệu"
            return iEmployeeRepositories.CheckLogin(username, password);
        }
    }
}