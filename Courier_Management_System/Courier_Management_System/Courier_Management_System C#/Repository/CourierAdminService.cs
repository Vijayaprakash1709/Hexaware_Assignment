using Courier_Management_System_C_.Exceptions;
using Courier_Management_System_C_.Models;

namespace Courier_Management_System_C_.Repository

{
    internal class CourierAdminService : ICourierAdminService
    {
        private readonly EmployeeCollection companyObj;

        public CourierAdminService(EmployeeCollection companyObj)
        {
            this.companyObj = companyObj;
        }

        public string AddEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.EmployeeID))
            {
                throw new InvalidEmployeeIdException("Employee ID cannot be null, empty, or consist of whitespace.");
            }
            if (companyObj.Employees.Any(e => e.EmployeeID == employee.EmployeeID))
            {
                throw new InvalidEmployeeIdException($"Employee with ID {employee.EmployeeID} already exists.");
            }
            companyObj.Employees.Add(employee);
            return $"Employee {employee.EmployeeName} added successfully with ID {employee.EmployeeID}.";
        }
    }
}
