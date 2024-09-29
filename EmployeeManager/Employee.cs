using System;

namespace Employee
{
    public class Employee
    {
        public string employeeName { get; set; } = string.Empty; // Ensures it's never null
        public string employeeID { get; set; } = string.Empty;
        public double hoursWorked { get; set; }
        public double hourlyRate = 9.5;

        // Constructor
        public Employee(string employeeName, string employeeID, double hoursWorked)
        {
            this.employeeName = employeeName;
            this.employeeID = employeeID;
            this.hoursWorked = hoursWorked; // in a week
        }

        // Method to calculate wage
        public double getWage()
        {
            return hoursWorked * hourlyRate;
        }

        // Override ToString method to display employee details
        public override string ToString()
        {
            double wage = getWage();
            return $"Name: {employeeName} \nEmployee ID: {employeeID} \nHours Worked: {hoursWorked} \n\nThe weekly wage is £{wage:F2}";
        }
    }
}


