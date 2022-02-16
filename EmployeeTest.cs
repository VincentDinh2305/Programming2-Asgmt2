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
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee employee01 = new Employee();
            Employee employee02 = new Employee();

            Console.Write("Enter your First Name: ");
            employee02.FirstName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            employee02.LastName = Console.ReadLine();
            Console.Write("Enter your base salary: $");
            employee02.BaseSalary = double.Parse(Console.ReadLine());
            Console.Write("Enter your gross sales (must be greater than zero): $");
            employee02.GrossSales = double.Parse(Console.ReadLine());
            Console.Write("Enter your commission rate (must be between 0.2(20%) and 1.0(100%)): ");
            employee02.CommissionRate = double.Parse(Console.ReadLine());

            if (employee02.GrossSales > 0 && 
                (employee02.CommissionRate > 0.1 && 
                employee02.CommissionRate < 1.0))
            {
                Console.WriteLine("\n\nFIRST OBJECT");
                Console.WriteLine($"\nEmployee Id: {employee01.employeeUserId}");
                Console.WriteLine($"Name: {employee01.FirstName} {employee01.LastName}");
                Console.WriteLine($"BaseSalary: ${employee01.BaseSalary}");
                Console.WriteLine($"GrossSales: ${employee01.GrossSales}");
                Console.WriteLine($"ComissionRate: {employee01.CommissionRate}");
                Console.WriteLine("Earnings: $" + employee01.earnings());

                Console.WriteLine("\n\nSECOND OBJECT");
                Console.WriteLine($"\nEmployee Id: {employee02.employeeUserId}");
                Console.WriteLine($"Name: {employee02.FirstName} {employee02.LastName}");
                Console.WriteLine($"BaseSalary: ${employee02.BaseSalary}");
                Console.WriteLine($"GrossSales: ${employee02.GrossSales}");
                Console.WriteLine($"ComissionRate: {employee02.CommissionRate}");
                Console.WriteLine("Earnings: $" + employee02.earnings());
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please try again.");
            }
        }
    }
}