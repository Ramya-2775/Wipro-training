using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int employeeID;
        public string employeeName;
        public string department;
        public double salary;

        public Employee(int employeeID, string employeeName, string department, double salary)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.department = department;
            this.salary = salary;
        }
        public void printdetails()
        {
            Console.WriteLine("employeeID:" + employeeID);
            Console.WriteLine("employeeName:" + employeeName);
            Console.WriteLine("department:" + department);
            Console.WriteLine("salary:" + salary);
        }

        public void updatesalary(double newsalary)
        {
            salary = newsalary;
            Console.WriteLine("salary updated to:" + salary);
        }

        public double annualsalary()
        {
            return salary * 12;
        }
    }
}
