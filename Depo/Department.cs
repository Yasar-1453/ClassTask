using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depo
{
    internal class Department : IEmployeeService
    {
        public int No { get; set; }
        Employee[] Employees = new Employee[0];
        private int _currentEmployeeCount = 0;

        public Department(int no)
        {
            No = no;
        }

        public void Add(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }

        public void GetEmployee()
        {
            string name = Console.ReadLine();
            foreach(Employee emp in Employees)
            {
                if(name == emp.Name)
                {
                    Console.WriteLine($"ID: {emp.Id} ,Name: {emp.Name}, Surname: {emp.Surname}, Age: {emp.Age} Salary: {emp.Salary}, Department: {emp.DepartmentNo}");
                }
            }
        }

        public void GetEmployeeInfo()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"ID: {emp.Id} ,Name: {emp.Name}, Surname: {emp.Surname}, Age: {emp.Age} Salary: {emp.Salary}, Department: {emp.DepartmentNo}");
            }
        }

        public Employee[] GetAllEmployees()
        {
            Employee[] r = new Employee[_currentEmployeeCount];
            Array.Copy( Employees, r, _currentEmployeeCount);
            return r;
        }

        public Employee[] GetAllEmployeeBySalary(int minPrice , int maxPrice)
        {

            Employee[] employees = new Employee[_currentEmployeeCount];

            int count = 0;


            foreach (Employee emp in Employees)
            {
                if (emp.Salary != null && emp.Salary >= minPrice && emp.Salary <= maxPrice)
                {
                    employees[count++] = emp;
                    count++;
                }
            }

            Employee[] r = new Employee[_currentEmployeeCount];
            Array.Copy(Employees, r, _currentEmployeeCount);
            return r;
        }

        public Employee[] GetAllEmployeeByDepartmentNo(int departmentNo)
        {
            Employee[] employees = new Employee[_currentEmployeeCount];

            int count = 0;

            foreach (Employee emp in Employees)
            {
                if(emp.DepartmentNo != null && emp.DepartmentNo == departmentNo)
                {
                    employees[count++] = emp;
                    count++;
                }

            }
                Employee[] r = new Employee[_currentEmployeeCount];
                Array.Copy(Employees, r, _currentEmployeeCount);
                return r;
        }
    }
}
