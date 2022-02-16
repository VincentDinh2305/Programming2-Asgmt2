//Name: Dinh Hoang Viet Phuong
//Student ID: 301 123 263
//I've done this assignment by my own. Please do not grade the whole team.
//Thank you so much.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemoApplication
{
    class Employee
    {   
        public readonly int employeeUserId;
        private string firstName;
        private string lastName;
        private double baseSalary;
        private double grossSales;
        private double commissionRate;

        public string FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }
        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }
        public double BaseSalary
        {
            set { baseSalary = value; }
            get { return baseSalary; }
        }
        public double GrossSales
        {
            set { grossSales = value; }
            get { return grossSales; }
        }
        public double CommissionRate
        {
            set { commissionRate = value; }
            get { return commissionRate; }
        }
        public Employee()
        {
            employeeUserId = 301123263;
            FirstName = "Phuong";
            LastName = "Dinh Hoang Viet";
            BaseSalary = 3000;
            GrossSales = 1000;
            CommissionRate = 0.3;
        }
        public Employee(int EmployeeId, string FirstName, double baseSalary)
        {
            employeeUserId = EmployeeId;
            FirstName = firstName;
            BaseSalary = baseSalary;
        }

        public double earnings()
        {
            return commissionRate * grossSales + baseSalary;
        }
    }
}
