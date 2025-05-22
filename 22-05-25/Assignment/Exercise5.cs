using System;
using System.Collections.Generic;
using System.Linq;

class Employee 
{ 
    public string Name; 
    public string Department; 
}
namespace Employees
{
    class program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new()
            {
                new Employee { Name = "Ramya", Department = "HR" },
                new Employee { Name = "Sowmya", Department = "IT" },
                new Employee { Name = "Diana", Department = "IT" },
                new Employee { Name = "Remo", Department = "Finance" },
                new Employee { Name = "Reddy", Department = "HR" },
                new Employee { Name = "Peddi", Department = "Finance" },

            };
            var grouped = employees.GroupBy(e => e.Department);
            foreach (var dept in grouped)
            {
                Console.WriteLine($"\nDepartment: {dept.Key}");
                foreach (var emp in dept)
                    Console.WriteLine($" - {emp.Name}");
            }
        }
    }
}






            




        


