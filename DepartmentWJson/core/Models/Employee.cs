using DepartmentWJson.core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentWJson.core.Models
{
    internal class Employee
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int DepartmentNo { get; set; }
        public Position Position { get; set; }
        private double _salary;

        public Employee(string name, string surname, int age, int departmentNo, Position position)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = departmentNo;
            Position = position;
        }

        public double Salary 
        { 
            get
            {
                return _salary;
            }
            set
            {
                if (value > 345)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("minimum emek haqqindan asagidir");
                }
            }
        }

    }
}
