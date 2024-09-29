using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of EmployeeManager
            EmployeeManager manager = new EmployeeManager();

            // Take input and create an employee
            Employee employee = manager.CreateEmployee();

            // Display the employee details
            Console.WriteLine("\n" + employee.ToString());

            Console.ReadLine(); // Keep the console window open
        }
    }
}
