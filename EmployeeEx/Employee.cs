using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeEx
{
    class Employee
    {
        string firstName;
        string lastName;
        int empID;
        int hoursWorked;
        double payRate;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int EmpID { get => empID; set => empID = value; }
        public int HoursWorked { get => hoursWorked; set => hoursWorked = value; }
        public double PayRate { get => payRate; set => payRate = value; }

        public double ComputePayAndOverTimePay()
        {
            double pay = 0;
            if (hoursWorked > 40)
            {
                pay = 40 * payRate + (hoursWorked - 40) * payRate * 1.5;
            }
            else
                pay = hoursWorked * payRate;
            return pay;
        }
    }
}
