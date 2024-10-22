using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depo
{
    internal interface IEmployeeService
    {
        void Add(Employee employee);
        void GetEmployee();
        void GetEmployeeInfo();
        Employee[] GetAllEmployees();
        Employee[] GetAllEmployeeBySalary(int minPrice, int maxPrice);
        Employee[] GetAllEmployeeByDepartmentNo(int departmentNo);
    }
}
