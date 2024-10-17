using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17._10
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public string SurName;
        public int Age;
        public int DepartmentNo;
        public int _salary;

        public Employee(int id, string name, string surName, int age, int departmentNo, int salary)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Age = age;
            DepartmentNo = departmentNo;
            _salary = salary;
        }

        public int Salary { get; set; }
    }
}
