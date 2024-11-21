﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System_C_.Models
{
    internal class Employee
    {
        private string employeeID;
        private string employeeName;
        private string email;
        private string contactNumber;
        private string role;
        private double salary;

        public Employee() { }

        public Employee(string employeeID, string employeeName, string email, string contactNumber, string role, double salary)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.email = email;
            this.contactNumber = contactNumber;
            this.role = role;
            this.salary = salary;
        }

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string ToString()
        {
            return $"Employee [EmployeeID={employeeID}, EmployeeName={employeeName}, Email={email}, ContactNumber={contactNumber}, Role={role}, Salary={salary}]";
        }
    }
}
