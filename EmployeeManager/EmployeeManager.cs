using System;

namespace Employee
{
    public class EmployeeManager
    {
        // Method to take employee information and create an Employee object
        public Employee CreateEmployee()
        {
            // Employee Name Input and Validation
            Console.WriteLine("Employee Name: ");
            string employeeName = Console.ReadLine() ?? string.Empty;
            while (!isValidName(employeeName))
            {
                Console.WriteLine("Invalid name. Please enter a valid name (1-50 characters): ");
                employeeName = Console.ReadLine() ?? string.Empty;
            }

            // Employee ID Input and Validation
            Console.Write("Employee ID (a letter followed by two digits, e.g., D65): ");
            string employeeID = Console.ReadLine() ?? string.Empty;
            while (!System.Text.RegularExpressions.Regex.IsMatch(employeeID, @"^[A-Za-z]\d{2}$"))
            {
                Console.WriteLine("Invalid Employee ID. Please enter a valid ID (a letter followed by two digits, e.g., D65): ");
                employeeID = Console.ReadLine() ?? string.Empty;
            }

            // Hours Worked Input and Validation
            Console.Write("Hours Worked: ");
            string inputHours = Console.ReadLine() ?? "0";
            double tempHours;
            while (!double.TryParse(inputHours, out tempHours) || tempHours < 1 || tempHours > 100)
            {
                Console.WriteLine("Invalid input. Hours worked must be a number between 1 and 100. Try again: ");
                inputHours = Console.ReadLine() ?? "0";
            }

            // Create and return a new Employee object
            Employee employee = new Employee(employeeName, employeeID, tempHours);
            return employee;
        }

        // Helper method to validate employee names
        public static bool isValidName(string name)
        {
            return !(string.IsNullOrWhiteSpace(name) || name.Length < 1 || name.Length > 50);
        }
    }
}
