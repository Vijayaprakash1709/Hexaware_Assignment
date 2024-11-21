using Courier_Management_System_C_.Models;
using Courier_Management_System_C_.Repository;
using Courier_Management_System_C_.Services;

namespace Courier_Management_System_C_
{
    internal class Main
    {
        public void MainMethod()
        {
            CourierCompanyCollection companyCollection = new CourierCompanyCollection();
            EmployeeCollection employeeCollection = new EmployeeCollection();
            ICourierUserService userService = new CourierUserService(companyCollection);
            ICourierAdminService adminService = new CourierAdminService(employeeCollection);
            CourierServiceHelper serviceHelper = new CourierServiceHelper(userService, adminService);

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-------------------- Welcome to Courier System --------------------");
                    Console.WriteLine("                     User Interface             ");
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. Place Order");
                    Console.WriteLine("3. Get Order Status");
                    Console.WriteLine("4. Cancel Order");
                    Console.WriteLine("5. View Assigned Orders");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter your choice: ");

                    int choice = int.Parse(Console.ReadLine());
                    if (choice > 6 || choice<1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }

                    if (choice == 6)
                    {
                        Console.WriteLine("Thank you for using the Courier Management System!");
                        break;
                    }

                    HandleChoice(choice, serviceHelper);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                }

            }
        }

        private void HandleChoice(int choice, CourierServiceHelper serviceHelper)
        {
            switch (choice)
            {
                case 1:
                    serviceHelper.AddEmployee();
                    break;
                case 2:
                    serviceHelper.PlaceOrder();
                    break;
                case 3:
                    serviceHelper.GetOrderStatus();
                    break;
                case 4:
                    serviceHelper.CancelOrder();
                    break;
                case 5:
                    serviceHelper.ViewAssignedOrders();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

    }
}
