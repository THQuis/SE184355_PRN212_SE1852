using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Services
{
    public interface IEmployeeServices
    {
        Employee? Login(string username, string password);
    }
}
