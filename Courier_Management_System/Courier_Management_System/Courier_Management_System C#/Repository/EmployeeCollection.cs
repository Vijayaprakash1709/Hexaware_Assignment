using Courier_Management_System_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System_C_.Repository
{
    internal class EmployeeCollection
    {
        public List<Employee> Employees { get; set; }

        public EmployeeCollection()
        {
            Employees = new List<Employee>();
        }
    }
}
