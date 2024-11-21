using Courier_Management_System_C_.Repository;
using Microsoft.VisualBasic;
using Pay_Xpert.Utility;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Courier_Management_System_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------Task 1 :Control Flow Statements--------------------

            #region --1.Write a program that checks whether a given order is delivered or not based on its status(e.g., "Processing," "Delivered," "Cancelled"). Use if-else statements for this.

            //string s =Console.ReadLine();
            //if (s == "Processing")
            //{
            //    Console.WriteLine("Processing");
            //}
            //else if(s=="Delivered")
            //{
            //    Console.WriteLine("Delivered");
            //}
            //else if (s == "Cancelled")
            //{
            //    Console.WriteLine("Cancellled");
            //}
            //Console.WriteLine("Hello, World!");

            #endregion

            #region --2.Implement a switch-case statement to categorize parcels based on their weight into "Light," "Medium," or "Heavy."

            //Console.WriteLine("Enter your parcel weight");
            //int weight = int.Parse(Console.ReadLine());

            //switch (weight)
            //{
            //    case <=10:
            //        Console.WriteLine("Light");
            //        break;
            //    case >10 and <=20:
            //        Console.WriteLine("Medium");
            //        break;
            //    case >20:
            //        Console.WriteLine("Heavy");
            //        break;
            //}

            #endregion

            #region --3. Implement User Authentication 1. Create a login system for employees and customers using Java control flow statements.


            //string username = "Vijay";
            //string password = "pass";
            //string user = "";
            //string pass = "";
            //Console.WriteLine("Enter Your UserName ::");
            //user = Console.ReadLine();
            //Console.WriteLine("Enter Your Password ::");
            //pass = Console.ReadLine();
            //if (pass == password && user == username)
            //{
            //    Console.WriteLine($"Welcome, {username}");

            //}
            //else
            //{
            //    Console.WriteLine($"Wrong username or password ");

            //}

            #endregion

            #region --4. Implement Courier Assignment Logic 1. Develop a mechanism to assign couriers to shipments based on predefined criteria(e.g., proximity, load capacity) using loops.

            //int[] shipmentWeights = { 30, 120, 75, 20, 180, 55, 220 };

            //Console.WriteLine("Courier 1 Shipments:");
            //for (int i = 0; i < shipmentWeights.Length; i++)
            //{
            //    if (shipmentWeights[i] < 50)
            //    {
            //        Console.WriteLine($"Shipment {i + 1}: {shipmentWeights[i]}");
            //    }
            //}

            //Console.WriteLine("\nCourier 2 Shipments:");
            //for (int i = 0; i < shipmentWeights.Length; i++)
            //{
            //    if (shipmentWeights[i] >= 50 && shipmentWeights[i] < 200)
            //    {
            //        Console.WriteLine($"Shipment {i + 1}: {shipmentWeights[i]}");
            //    }
            //}

            //Console.WriteLine("\nCourier 3 Shipments:");
            //for (int i = 0; i < shipmentWeights.Length; i++)
            //{
            //    if (shipmentWeights[i] >= 200)
            //    {
            //        Console.WriteLine($"Shipment {i + 1}: {shipmentWeights[i]}");
            //    }
            //}

            #endregion

            #region --5. Write a Java program that uses a for loop to display all the orders for a specific customer.  

            //string[][] orders = new string[2][];
            //orders[0] = new string[] { "Mobile", "Laptop", "Powerbank" };
            //orders[1] = new string[] { "Processor", "GPU" };

            //Console.Write("Enter customer number (1 or 2): ");
            //int customerIndex = int.Parse(Console.ReadLine());
            //if (customerIndex < 0 || customerIndex > orders.Length)
            //{
            //    Console.WriteLine("Invalid customer ID.");
            //    return;
            //}

            //Console.WriteLine($"\nOrders for Customer {customerIndex}:");
            //for (int i = 0; i < orders[customerIndex-1].Length; i++)
            //{
            //    Console.WriteLine(orders[customerIndex-1][i]);
            //}

            #endregion

            #region --6. Implement a while loop to track the real-time location of a courier until it reaches its destination. 

            //string[] cities = { "Chennai", "Banglore", "Mumbai", "Salem", "Attur" };
            //string[] orders = { "Banglore", "Salem", "Attur" };

            //int currentCityIndex = 0;

            //Console.WriteLine("Courier's Journey:");

            //while (currentCityIndex < orders.Length)
            //{
            //    string currentCity = orders[currentCityIndex];
            //    Console.WriteLine($"Courier is in {currentCity}");
            //    currentCityIndex++;
            //    Console.WriteLine("Waiting for pickup.....");
            //}

            //Console.WriteLine("\nCourier has reached the final destination.");

            #endregion

            #region --7. Create an array to store the tracking history of a parcel, where each entry represents a location update.

            //string[] trackingHistory = new string[5];

            //trackingHistory[0] = "Parcel picked up from Warehouse";
            //trackingHistory[1] = "Parcel is in the way to Bangalore";
            //trackingHistory[2] = "Parcel arrived at Bangalore";
            //trackingHistory[3] = "Parcel is in tthe way to Attur";
            //trackingHistory[4] = "Parcel delivered to Customer";

            //Console.WriteLine("Parcel Tracking History:");

            //for (int i = 0; i < trackingHistory.Length; i++)
            //{
            //    Console.WriteLine(trackingHistory[i]);
            //}

            #endregion

            #region --8. Implement a method to find the nearest available courier for a new order using an array of couriers. 

            //string[] courierNames = { "Courier1", "Courier2", "Courier3" };
            //int[] courierDistances = { 5, 10, 3 };

            //int nearestIndex = -1;
            //int shortestDistance = int.MaxValue;

            //for (int i = 0; i < courierNames.Length; i++)
            //{
            //    if (courierDistances[i] < shortestDistance)
            //    {
            //        shortestDistance = courierDistances[i];
            //        nearestIndex = i;
            //    }
            //}

            //if (nearestIndex != -1)
            //{
            //    Console.WriteLine($"The nearest courier is {courierNames[nearestIndex]}.");
            //}
            //else
            //{
            //    Console.WriteLine("No courier found.");
            //}

            #endregion

            #region --9. Parcel Tracking: Create a program that allows users to input a parcel tracking number.Store the 
            //tracking number and Status in 2d String Array. Initialize the array with values.Then, simulate the
            //tracking process by displaying messages like "Parcel in transit," "Parcel out for delivery," or "Parcel 
            //delivered" based on the tracking number's status.  

            //string[,] trackingInfo = new string[,]
            //{
            //    { "12345", "Parcel in transport" },
            //    { "67890", "Parcel out for delivery" },
            //    { "11223", "Parcel delivered" },
            //    { "44556", "Parcel in transport" },
            //    { "78901", "Parcel delivered" }
            //};

            //Console.Write("Enter parcel tracking number: ");
            //string trackingNumber = Console.ReadLine();

            //bool parcelFound = false;

            //for (int i = 0; i < trackingInfo.GetLength(0); i++)
            //{
            //    if (trackingInfo[i, 0] == trackingNumber)
            //    {
            //        parcelFound = true;
            //        Console.WriteLine($"Tracking Number: {trackingInfo[i, 0]} - Status: {trackingInfo[i, 1]}");
            //        break;
            //    }
            //}

            //if (!parcelFound)
            //{
            //    Console.WriteLine("Parcel tracking number not found.");
            //}

            #endregion

            #region --10. Customer Data Validation: Write a function which takes 2 parameters, data-denotes the data and 
            //detail - denotes if it is name addtress or phone number.Validate customer information based on
            //following critirea. Ensure that names contain only letters and are properly capitalized, addresses do not
            //contain special characters, and phone numbers follow a specific format(e.g., ###-###-####).

            //Console.WriteLine("Enter Name:");
            //string name = Console.ReadLine();
            //string nameMessage = "Invalid Name: Name should only contain letters and be properly capitalized.";
            //string[] nameWords = name.Split(' ');
            //bool isNameValid = true;

            //foreach (var word in nameWords)
            //{
            //    if (word.Length == 0) continue;
            //    if (!Char.IsUpper(word[0]))
            //    {
            //        isNameValid = false;
            //        break;
            //    }
            //    for (int i = 1; i < word.Length; i++)
            //    {
            //        if (!Char.IsLetter(word[i]))
            //        {
            //            isNameValid = false;
            //            break;
            //        }
            //    }
            //}

            //if (isNameValid)
            //    Console.WriteLine("Valid Name");
            //else
            //    Console.WriteLine(nameMessage);

            //Console.WriteLine("Enter Address:");
            //string address = Console.ReadLine();
            //bool isAddressValid = true;

            //foreach (var c in address)
            //{
            //    if (!Char.IsLetterOrDigit(c) && c != ' ' && c != '.' && c != ',' && c != '-' && c != '#')
            //    {
            //        isAddressValid = false;
            //        break;
            //    }
            //}

            //if (isAddressValid)
            //    Console.WriteLine("Valid Address");
            //else
            //    Console.WriteLine("Invalid Address: Address contains invalid characters.");

            //Console.WriteLine("Enter Phone Number:");
            //string phoneNumber = Console.ReadLine();
            //bool isPhoneValid = phoneNumber.Length == 10;

            //if (isPhoneValid)
            //{
            //    bool allDigits = true;
            //    foreach (var c in phoneNumber)
            //    {
            //        if (!Char.IsDigit(c))
            //        {
            //            allDigits = false;
            //            break;
            //        }
            //    }
            //    if (allDigits)
            //        Console.WriteLine("Valid Phone Number");
            //    else
            //        Console.WriteLine("Invalid Phone Number: Phone number should contain exactly 10 digits.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Phone Number: Phone number should contain exactly 10 digits.");
            //}

            #endregion

            #region --11. Address Formatting: Develop a function that takes an address as input (street, city, state, zip code) 
            //and formats it correctly, including capitalizing the first letter of each word and properly formatting the
            //zip code.

            //Console.WriteLine("Enter Address (Street, City, State, Zip Code):");
            //string address = Console.ReadLine();

            //string formattedAddress = FormatAddress(address);
            //Console.WriteLine("Formatted Address:");
            //Console.WriteLine(formattedAddress);
            //}

            //static string FormatAddress(string address)
            //{
            //    string[] parts = address.Split(',');

            //    if (parts.Length != 4)
            //    {
            //        return "Invalid address format. Please ensure you provide Street, City, State, and Zip Code.";
            //    }

            //    string street = CapitalizeWords(parts[0].Trim());
            //    string city = CapitalizeWords(parts[1].Trim());
            //    string state = CapitalizeWords(parts[2].Trim());
            //    string zipCode = FormatZipCode(parts[3].Trim());

            //    return $"{street}, {city}, {state}, {zipCode}";
            //}

            //static string CapitalizeWords(string input)
            //{
            //    string[] words = input.Split(' ');
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        if (words[i].Length > 0)
            //        {
            //            words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            //        }
            //    }
            //    return string.Join(" ", words);
            //}

            //static string FormatZipCode(string zipCode)
            //{
            //    string cleanedZip = string.Empty;
            //    foreach (char c in zipCode)
            //    {
            //        if (Char.IsDigit(c))
            //        {
            //            cleanedZip += c;
            //        }
            //    }

            //    if (cleanedZip.Length == 6)
            //    {
            //        return cleanedZip;
            //    }
            //    else
            //    {
            //        return "Invalid Zip Code: Should be exactly 6 digits.";
            //    }

            #endregion

            #region --12. Order Confirmation Email: Create a program that generates an order confirmation email. The email 
            //should include details such as the customer's name, order number, delivery address, and expected 
            //delivery date.  

            //Console.WriteLine("Enter Customer's Name:");
            //string customerName = Console.ReadLine();

            //Console.WriteLine("Enter Order Number:");
            //string orderNumber = Console.ReadLine();

            //Console.WriteLine("Enter Delivery Address:");
            //string deliveryAddress = Console.ReadLine();

            //Console.WriteLine("Enter Expected Delivery Date (YYYY-MM-DD):");
            //string deliveryDateInput = Console.ReadLine();

            //Console.WriteLine("\nOrder Confirmation Email:");
            //if (!DateTime.TryParse(deliveryDateInput, out DateTime expectedDeliveryDate))
            //{
            //    Console.WriteLine("Invalid date format. Please use YYYY-MM-DD.");
            //}

            //Console.WriteLine($"Dear {customerName},\n");
            //Console.WriteLine("Thank you for your order!");
            //Console.WriteLine($"Order Number: {orderNumber}");
            //Console.WriteLine($"Delivery Address: {deliveryAddress}");
            //Console.WriteLine($"Expected Delivery Date: {expectedDeliveryDate:MMMM dd, yyyy}\n");
            //Console.WriteLine("Any queries, feel free to contact support@couriers.com .");
            //Console.WriteLine("Best regards,\nVijay");

            #endregion

            #region --13.Calculate Shipping Costs: Develop a function that calculates the shipping cost based on the distance
            //between two locations and the weight of the parcel.You can use string inputs for the source and
            //destination addresses.

            //    Console.WriteLine("Enter Source Address:");
            //    string source = Console.ReadLine();

            //    Console.WriteLine("Enter Destination Address:");
            //    string destination = Console.ReadLine();

            //    Console.WriteLine("Enter Parcel Weight (kg):");
            //    double weight = Convert.ToDouble(Console.ReadLine());

            //    int distance = CalculateDistance(source, destination);
            //    if (distance < 0)
            //    {
            //        Console.WriteLine("Invalid addresses. Unable to calculate distance.");
            //        return;
            //    }

            //    const double ratePerKm = 1.00;
            //    const double ratePerKg = 2.00;

            //    double cost = (distance * ratePerKm) + (weight * ratePerKg);

            //    Console.WriteLine($"\nShipping Cost Calculation:");
            //    Console.WriteLine($"Source: {source}");
            //    Console.WriteLine($"Destination: {destination}");
            //    Console.WriteLine($"Distance: {distance} km");
            //    Console.WriteLine($"Weight: {weight} kg");
            //    Console.WriteLine($"Total Shipping Cost: ${cost:F2}");
            //}

            //static int CalculateDistance(string source, string destination)
            //{
            //    source = source.ToLower().Trim();
            //    destination = destination.ToLower().Trim();

            //    if (source == "attur" && destination == "salem" || source == "attur" && destination == "namakkal")
            //        return 100;
            //    else if (source == "salem" && destination == "chennai" || source == "chennai" && destination == "banglore")
            //        return 200;
            //    else if (source == "chennai" && destination == "delhi" || source == "chennai" && destination == "mumbai")
            //        return 500;
            //    else
            //        return -1;
            //}

            #endregion

            #region --14. Password Generator: Create a function that generates secure passwords for courier system 
            //accounts.Ensure the passwords contain a mix of uppercase letters, lowercase letters, numbers, and
            //special characters.  

            //Console.Write("Enter desired password length (minimum 8): ");
            //int length = int.Parse(Console.ReadLine());

            //if (length < 8)
            //{
            //    Console.WriteLine("Password length must be at least 8 characters.");
            //    return;
            //}

            //const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            //const string numbers = "0123456789";
            //const string specialChars = "!@#$%^&*()_-+=<>?";
            //const string allChars = upperCase + lowerCase + numbers + specialChars;

            //var random = new Random();
            //var password = new char[length];
            //int position = 0;

            //password[position++] = upperCase[random.Next(upperCase.Length)];
            //password[position++] = lowerCase[random.Next(lowerCase.Length)];
            //password[position++] = numbers[random.Next(numbers.Length)];
            //password[position++] = specialChars[random.Next(specialChars.Length)];

            //for (; position < length; position++)
            //{
            //    password[position] = allChars[random.Next(allChars.Length)];
            //}

            //for (int i = password.Length - 1; i > 0; i--)
            //{
            //    int j = random.Next(i + 1);
            //    (password[i], password[j]) = (password[j], password[i]);
            //}

            //Console.WriteLine($"Generated Password: {new string(password)}");

            #endregion


            #region --15. Find Similar Addresses: Implement a function that finds similar addresses in the system. This can be 
            //useful for identifying duplicate customer entries or optimizing delivery routes.Use string functions to
            //implement this.

            //    string[] addresses = {
            //    "123,Salem",
            //    "Banglore",
            //    "attur"
            //};
            //    List<string> addressList = new List<string>(addresses);

            //    Console.Write("Enter a new address: ");
            //    string newAddress = Console.ReadLine();

            //    bool isDuplicate = IsAddressExists(addressList, newAddress);

            //    if (isDuplicate)
            //    {
            //        Console.WriteLine("The entered address is already used.");
            //    }
            //    else
            //    {
            //        addressList.Add(newAddress);
            //        Console.WriteLine("The entered address is added.");
            //    }
            //}

            //static bool IsAddressExists(List<string> addresses, string newAddress)
            //{
            //    foreach (string existingAddress in addresses)
            //    {
            //        if (existingAddress.Equals(newAddress, StringComparison.OrdinalIgnoreCase))
            //        {
            //            return true;
            //        }
            //        else if (existingAddress.ToLower().Contains(newAddress.ToLower()) ||
            //                 newAddress.ToLower().Contains(existingAddress.ToLower()))
            //        {
            //            return true;
            //        }
            //    }
            //    return false;

            #endregion

            //------------------------Task 5 , 6----------------------

            #region Task 5,6,7,8
            //Main main = new Main();
            //main.MainMethod();

            #endregion

            #region Demo DB Task 9

            CourierServiceDb courierServiceDb = new CourierServiceDb(DBConnUtil.GetConnectionString());
            var result=courierServiceDb.GetCourier("track1");
            Console.WriteLine(result.SenderName);
            #endregion

        }
    }
}
