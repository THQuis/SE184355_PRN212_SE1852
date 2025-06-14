using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse
{
    public static class MyUtils
    {
        //Hãy cài đtajw tên là tính tuổi cho employee

        public static int TinhTuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year + 1;
        }
    }
}