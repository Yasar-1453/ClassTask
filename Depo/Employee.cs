using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depo
{
    internal class Employee : Human
    {
        public Employee(int id, string name, string surname, int age, int departmentNo, int salary) : base (id, name, surname, age)
        {
            DepartmentNo = departmentNo;
            Salary = salary;
        }

        public int DepartmentNo { get; set; }
        public int Salary {  get; set; }
    }
}
