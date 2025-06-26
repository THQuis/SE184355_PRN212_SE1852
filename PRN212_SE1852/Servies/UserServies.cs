using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using Repositories;

namespace Servies
{
    public class UserServies : IUserServies
    {
        private readonly IUserRepository iUserRepository;

        public UserServies()
        {
            iUserRepository = new UserRepository();
        }
        public List<User> GetAllUsers()
        {
            return iUserRepository.GetAllUsers();
        }
    }
}
