using System;

namespace EmployeeManager 
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Koby Hills", "D65", 35);
            Console.WriteLine(employee.ToString());

            Console.ReadLine();
        }
    }
}