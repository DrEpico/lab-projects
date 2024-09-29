using System;

namespace Employee
{
    class Employee
    {
        public string employeeName { get; set; } = string.Empty;
        public string employeeID { get; set; } = string.Empty;
        public double hoursWorked { get; set; }
        public double hourlyRate = 9.5;

        public Employee(string employeeName, string employeeID, double hoursWorked)
        {
            this.employeeName = employeeName;
            this.employeeID = employeeID;
            this.hoursWorked = hoursWorked; // in a week
        }

        public double getWage()
        {
            return hoursWorked * hourlyRate;
        }

        public override string ToString()
        {
            double wage = getWage();
            return $"Name: {employeeName} \nEmployee ID: {employeeID} \nHours Worked: {hoursWorked} \n\nThe weekly wage is £{wage:F2}";
        }

        public static bool isValidName(string name)
        {
            return !(string.IsNullOrWhiteSpace(name) || name.Length < 1 || name.Length > 50);
        }

        public void takeInfo()
        {
            // Employee Name Input and Validation
            Console.WriteLine("Employee Name: ");
            employeeName = Console.ReadLine();
            while (!isValidName(employeeName))
            {
                Console.WriteLine("Invalid name. Please enter a valid name (1-50 characters): ");
                employeeName = Console.ReadLine();
            }

            // Employee ID Input and Validation
            Console.Write("Employee ID (a letter followed by two digits, e.g., D65): ");
            employeeID = Console.ReadLine();
            while (!System.Text.RegularExpressions.Regex.IsMatch(employeeID, @"^[A-Za-z]\d{2}$"))
            {
                Console.WriteLine("Invalid Employee ID. Please enter a valid ID (a letter followed by two digits, e.g., D65): ");
                employeeID = Console.ReadLine();
            }

            // Hours Worked Input and Validation
            Console.Write("Hours Worked: ");
            string inputHours = Console.ReadLine();
            while (!double.TryParse(inputHours, out hoursWorked) || hoursWorked < 1 || hoursWorked > 100)
            {
                Console.WriteLine("Invalid input. Hours worked must be a number between 1 and 100. Try again: ");
                inputHours = Console.ReadLine();
            }

            // Display the employee information and wage
            Console.WriteLine("\n" + this.ToString());
        }
    }
}
