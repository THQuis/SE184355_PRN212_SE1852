using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string IdCard { get; set; }
        public DateTime Birthday { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, string idCard, DateTime birthDay)
        {
            this.Id = id;
            this.Name = name;
            this.IdCard = idCard;
            this.Birthday = birthDay;
        }

        public virtual double calSalary()
        {
            return 4000000;
        }

        public override string ToString()
        {
            return Id + "\t" + IdCard + "\t" + Name + "\t" + Birthday.ToString("dd/MM/yyyy") + "\t" + calSalary();
        }
    }
}