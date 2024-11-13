namespace Courier_Management_System_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            if (s == "Processing")
            {
                Console.WriteLine("Processing");
            }
            else if(s=="Delivered")
            {
                Console.WriteLine("Delivered");
            }
            else if (s == "Cancelled")
            {
                Console.WriteLine("Cancellled");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
