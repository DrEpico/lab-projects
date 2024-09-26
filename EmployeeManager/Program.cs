using System;

namespace EmployeeManager
{
    class Employee
    {
        public string employeeName { get; set; }
        public string employeeID { get; set; }
        public double hoursWorked { get; set; }
        public double hourlyRate = 9.5;

        public Employee(string employeeName, string employeeID, double hoursWorked)
        {
            this.employeeName = employeeName;
            this.employeeID = employeeID;
            this.hoursWorked = hoursWorked;//in a week
        }

        public override string ToString()
        {
            return $"Name: {employeeName} \nEmployee ID: {employeeID} \nHours Worked: {hoursWorked} \n\nThe weekly wage is £{hoursWorked * hourlyRate}";
        }
    }

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
