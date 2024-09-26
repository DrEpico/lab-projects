using System;

    class EmployeeManager
    {
        public string employeeName { get; set; }
        public string employeeID { get; set; }
        public double hoursWorked { get; set; }
        public double hourlyRate = 9.5;

        public EmployeeManager(string employeeName, string employeeID, double hoursWorked)
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
    }

