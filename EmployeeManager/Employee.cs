using System;

namespace Employee
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
            if (string.IsNullOrWhiteSpace(name) || name.Length < 1 || name.Length > 50)
                return false;
            return true;
        }

        private bool validateInput()
        {
            if (this.hoursWorked < 1 || this.hoursWorked > 100)
            {
                return false;
            }
            return true;
        }
    }
}

