using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    // 1. Chuyển class thành 'static'
    public static class EmployeeDAO
    {
        // Giả lập dữ liệu nhân viên
        private static readonly List<Employee> Employees = new List<Employee>();

        // 2. Sử dụng 'static constructor' (hàm dựng tĩnh)
        // Hàm này sẽ tự động chạy một lần duy nhất khi lớp được gọi lần đầu tiên.
        // Đây là nơi hoàn hảo để khởi tạo dữ liệu.
        static EmployeeDAO()
        {
            InitializeDataset();
        }

        // 3. Chuyển phương thức này thành 'private static' vì nó chỉ được gọi bên trong
        private static void InitializeDataset()
        {
            // Chỉ thêm dữ liệu nếu danh sách đang trống
            if (!Employees.Any())
            {
                Employees.Add(new Employee() { EmployeeID = 1, Name = "Admin", UserName = "admin", Password = "1234", JobTitle = "Manager" });
                Employees.Add(new Employee() { EmployeeID = 2, Name = "John Doe", UserName = "john", Password = "abcd", JobTitle = "Staff" });
                Employees.Add(new Employee() { EmployeeID = 3, Name = "Hoàng Quí", UserName = "qui", Password = "qui", JobTitle = "Manager" });
            }
        }

        // 4. Chuyển phương thức này thành 'public static'
        public static Employee? CheckLogin(string username, string password)
        {
            return Employees.FirstOrDefault(e => e.UserName == username && e.Password == password);
        }

        // Phương thức GetAll() của bạn đã là static, rất tốt!
        public static List<Employee> GetAll() => Employees;
    }
}