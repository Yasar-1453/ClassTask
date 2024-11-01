using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentWJson.core.Models
{
    internal class Department
    {
        private static int _no;
        public int No { get; set; }

        public Department()
        {
            _no = 0;
            No = 0;
        }
    }
}
