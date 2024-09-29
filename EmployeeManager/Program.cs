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

            Console.ReadLine(); // Keep the console window open
        }
    }
}