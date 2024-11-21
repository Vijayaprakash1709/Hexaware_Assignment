using Courier_Management_System_C_.Models;
using Courier_Management_System_C_.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_System_C_.Services
{
    internal class CourierServiceHelper
    {
        private readonly ICourierUserService _userService;
        private readonly ICourierAdminService _adminService;

        public CourierServiceHelper(ICourierUserService userService, ICourierAdminService adminService)
        {
            _userService = userService;
            _adminService = adminService;
        }

        public void AddEmployee()
        {
            Console.Write("Enter Employee ID: ");
            string employeeId = Console.ReadLine();

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Role: ");
            string role = Console.ReadLine();

           
            var employee = new Employee
            {
                EmployeeID = employeeId,
                EmployeeName = name,
                Role = role
            };
            string result = _adminService.AddEmployee(employee);
            Console.WriteLine(result);
        }


        public void PlaceOrder()
        {
            Console.Write("Enter Sender Name: ");
            string senderName = Console.ReadLine();

            Console.Write("Enter Sender Address: ");
            string senderAddress = Console.ReadLine();

            Console.Write("Enter Receiver Name: ");
            string receiverName = Console.ReadLine();

            Console.Write("Enter Receiver Address: ");
            string receiverAddress = Console.ReadLine();

            Console.Write("Enter Weight of the Parcel: ");
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                Console.WriteLine("Invalid weight input. Please enter a valid number.");
                return;
            }

            Console.Write("Enter User ID: ");
            string userId = Console.ReadLine();

            var trackingNumber = _userService.PlaceOrder(new Models.Courier(
                senderName, senderAddress, receiverName, receiverAddress, weight, "Placed", DateTime.Now.AddDays(5), userId));

            Console.WriteLine($"Order placed successfully. Tracking Number: {trackingNumber}");
        }

        public void GetOrderStatus()
        {
            Console.Write("Enter Tracking Number: ");
            string trackingNumber = Console.ReadLine();

            string status = _userService.GetOrderStatus(trackingNumber);
            Console.WriteLine($"Order Status: {status}");
        }

        public void CancelOrder()
        {
            Console.Write("Enter Tracking Number: ");
            string trackingNumber = Console.ReadLine();

            bool success = _userService.CancelOrder(trackingNumber);
            if (success)
            {
                Console.WriteLine("Order canceled successfully.");
            }
            else
            {
                Console.WriteLine("Failed to cancel the order. Please check the tracking number.");
            }
        }

        public void ViewAssignedOrders()
        {
            Console.Write("Enter Courier Staff ID: ");
            string staffId = Console.ReadLine();

            var orders = _userService.GetAssignedOrders(staffId);
            if (orders.Count > 0)
            {
                Console.WriteLine("Assigned Orders:");
                foreach (var order in orders)
                {
                    Console.WriteLine(order.ToString());
                }
            }
            else
            {
                Console.WriteLine("No orders assigned to this staff.");
            }
        }
    }
}
