using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practice17._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department(2, 4);
            


            Employee employee = new Employee(2,"sup", "rolton", 21, 4, 5000);
            Employee employee2 = new Employee(3, "wass", "good", 41, 5, 5300);
            Employee employee3 = new Employee(4, "were", "abd", 32, 2, 5200);
            Employee employee4 = new Employee(5, "go", "home", 24, 4, 5010);


            department.AddEmployee(employee);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
            department.AddEmployee(employee4);

            department.GetEmployee(2);
            department.GetEmployeeInfo(2);
            department.GetAllEmployees();
            department.GetAllEmployeesBySalary();
            department.GetAllEmployeesByDepartmentNo(4);

        }
    }
}
