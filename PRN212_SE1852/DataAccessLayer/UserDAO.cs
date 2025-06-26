using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccessLayer
{
    public class UserDAO
    {
        static List<User> users = new List<User>();

        public void InitializeDataset()
        {
            users.Add(new User() { Name = "Quí", Phone = "0924626416", Email = "truongqui858@gmail.com" });
            users.Add(new User() { Name = "Mi", Phone = "079566545", Email = "mi@gmail.com" });
            users.Add(new User() { Name = "Sơn", Phone = "0545413215", Email = "son@gmail.com" });
            users.Add(new User() { Name = "Trí", Phone = "9876454654", Email = "tri@gmail.com" });
            users.Add(new User() { Name = "Duy", Phone = "4546454654", Email = "Duy@gmail.com" });
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}