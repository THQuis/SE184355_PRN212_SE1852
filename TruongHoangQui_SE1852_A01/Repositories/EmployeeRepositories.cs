using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class EmployeeRepositories : IEmployeeRepositories
    {
        private static EmployeeRepositories? instance = null;
        private static readonly object instanceLock = new object();

        public static EmployeeRepositories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeRepositories();
                    }
                }
                return instance;
            }
        }
        // --- Kết thúc Mẫu thiết kế Singleton ---

        // Constructor private để không ai tạo mới được từ bên ngoài
        private EmployeeRepositories() { }

        // 2. Implement phương thức CheckLogin
        public Employee? CheckLogin(string username, string password)
        {
            // 3. Gọi trực tiếp đến phương thức static của EmployeeDAO
            return EmployeeDAO.CheckLogin(username, password);
        }
    }
}
