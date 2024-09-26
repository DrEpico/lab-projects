using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Koby Hills", "D65", 35);
            Console.WriteLine(employee.ToString());

            string name = "Wolfeschlegelsteinhausenbergerdorff";
            Console.WriteLine($"Is the name valid? {Employee.isValidName(name)}");
            
            Console.ReadLine();
        }
    }
}