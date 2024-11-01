using DepartmentWJson.core.Enums;
using DepartmentWJson.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentWJson
{
    internal class AppDbContext
    {
        List<Employee> Employee = new List<Employee>();
        List<Department> Department = new List<Department>();
        private int _employeeLimit;
        public int EmployeeLimit
        {
            get
            {
                return _employeeLimit;
            }
            set
            {
                if (value > 0 && value <20)
                {
                    _employeeLimit = value;
                }
                else
                {
                    Console.WriteLine("employee sayi limiti kecib");
                }
            }
        }

        public void AddEmployee(Employee employee)
        {
            Employee.Add(employee);
        }
        public void GetEmployee(int id)
        {
            foreach (Employee emp in Employee)
            {
                if (emp.Id == id)
                {
                    Console.WriteLine($"Employee {Employee}");
                }
            }
        }
        public List<Employee> GetAllEmployees()
        {
            return Employee;
        }

        public List<Employee> GetEmployeesBySalary(double minSalary, double maxSalary)
        {
            return Employee.FindAll(x => x.Salary >= minSalary && x.Salary <=maxSalary);
        }

        public List<Employee> GetEmployeesByPosition(Position position)
        {
            return Employee.FindAll(x => x.Position == position);
        }

        public List<Employee> GetEmployeesByDepartmentNo(int derpartmentNo)
        {
            return Employee.FindAll(x => x.DepartmentNo == derpartmentNo);
        }
    }
}
