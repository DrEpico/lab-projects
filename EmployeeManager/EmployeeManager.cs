using System;

namespace Employee
{
    public class EmployeeManager
    {
        public static List<Employee> employees = new List<Employee>(); // Dynamically growing list

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

        public void AddEmployee()
        {
            Employee employee = CreateEmployee();
            employees.Add(employee);
            Console.WriteLine("Employee added successfully.");
        }

        public void ListEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees to display.");
                return;
            }

            Console.WriteLine("\nEmployees List:");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {employees[i]}"); // Display position number and employee details
            }
        }

        public void RemoveEmployee()
        {
            ListEmployees(); // Show current employees
            Console.Write("Enter the position number of the employee to remove: ");
            if (int.TryParse(Console.ReadLine(), out int position) && position > 0 && position <= employees.Count)
            {
                employees.RemoveAt(position - 1); // Remove employee at the specified position
                Console.WriteLine("Employee removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid position number.");
            }
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Employee Manager Menu ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. List Employees");
                Console.WriteLine("3. Remove Employee");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        ListEmployees();
                        break;
                    case "3":
                        RemoveEmployee();
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return; // Exit the loop and the program
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
