using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17._10
{
    internal class Department
    {
        private int _no;
        private Employee[] Employees;
        private int _employeeLimit;

        public Department(int no, int employeeLimit)
        {
            _no = no;
            _employeeLimit = employeeLimit;
            Employees = new Employee[EmployeeLimit];
        }

        public int No {  get { return _no; } set { } }
        public int EmployeeLimit { get { return _employeeLimit; } set { } }

        public void AddEmployee(Employee employee)
        {
            Employee[] newEmployee = new Employee[Employees.Length + 1];

            for (int i = 0; i < Employees.Length; i++)
            {
                newEmployee[i] = Employees[i];
            }
            newEmployee[Employees.Length - 1] = employee;
            Employees = newEmployee;
        }

        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in Employees)
            {
                if(emp != null && emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public void GetEmployeeInfo(int id)
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.SurName + " " + emp.Age + " " + emp.Salary);
            }
        }

        public Employee[] GetAllEmployees()
        {
            Employee[] result = new Employee[0];
            Array.Copy(Employees, result, 0);
            return result; 
        }

        public Employee[] GetAllEmployeesBySalary()
        {
            Employee[] emp = GetAllEmployees();

            for (int i = 0; i < emp.Length - 1; i++)
            {
                for (int j = 0; j < emp.Length - i - 1; j++)
                {
                    if (emp[j].Salary > emp[j + 1].Salary)
                    {
                        var temp = emp[j];
                        emp[j] = emp[j + 1];
                        emp[j + 1] = temp;
                    }
                }
            }

            return emp; 
        }

        public Employee[] GetAllEmployeesByDepartmentNo(int departmentNo)
        {
            Employee[] temp = new Employee[0];
            int count = 0;

            foreach (var emp in Employees)
            {
                if (emp != null && emp.DepartmentNo == departmentNo)
                {
                    temp[count] = emp;
                    count++;
                }
            }

            Employee[] result = new Employee[count];
            Array.Copy(temp, result, count);
            return result; 
        }
    }
}
