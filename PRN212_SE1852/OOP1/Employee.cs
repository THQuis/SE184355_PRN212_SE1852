using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        //Nhóm các thuộc tính Employee
        //Nhóm các Constructors của Employee
        #region Nhóm các Properties của Employee
        private int Id;
        private string Name;
        private string Email;
        private string Phone;

        public Employee()
        { }

        public Employee(int id, string name, string email, string phone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public void PrintInfor()
        {
            Console.WriteLine($"{Id}\t{Name}\t{Email}\t{Phone}");
        }

        public override string ToString()
        {
            string mes = $"{Id}\t{Name}\t{Email}\t{Phone}";
            return mes;
        }
    }
}