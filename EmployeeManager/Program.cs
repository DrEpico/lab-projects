using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("", "", 0);

            // Take input for employee details using takeInfo method
            employee.takeInfo();

            // Optionally, display the employee details and weekly wage again
            Console.WriteLine("\nSummary:");
            Console.WriteLine(employee.ToString());

            Console.ReadLine(); // Keep the console window open
        }
    }
}