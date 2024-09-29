using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of EmployeeManager
            EmployeeManager manager = new EmployeeManager();

            // Display the menu and handle user input
            manager.DisplayMenu();

            Console.ReadLine(); // Keep the console window open
        }
    }
}
