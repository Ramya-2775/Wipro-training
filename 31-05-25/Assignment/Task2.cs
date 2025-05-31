using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int ID;
    public string Name;
    public string Department;
    public double Salary;

    public Employee(int id, string name, string dept, double salary)
    {
        ID = id;
        Name = name;
        Department = dept;
        Salary = salary;
    }
}

/*class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(1, "Ramya", "HR", 50000),
            new Employee(2, "Sowmya", "IT", 70000),
            new Employee(3, "Reddy", "Finance", 60000),
            new Employee(4, "Ravi", "IT", 75000),
            new Employee(5, "Diana", "HR", 52000),
            new Employee(6, "Raju", "Finance", 62000),
            new Employee(7, "Rani", "IT", 71000)
        };

        
        Console.WriteLine("Enter department to filter (e.g., HR, IT, Finance):");
        string inputDept = Console.ReadLine();

        var filtered = employees.Where(e => e.Department == inputDept);

        Console.WriteLine($"\nEmployees in {inputDept} department:");
        foreach (var emp in filtered)
        {
            Console.WriteLine($"{emp.ID} - {emp.Name} - {emp.Department} - ${emp.Salary}");
        }

        
        Console.WriteLine("\nEmployees sorted by Salary (high to low):");
        var sorted = employees.OrderByDescending(e => e.Salary);
        foreach (var emp in sorted)
        {
            Console.WriteLine($"{emp.Name} - ${emp.Salary}");
        }

        
        Console.WriteLine("\nAverage Salary by Department:");
        var avgSalary = employees
                        .GroupBy(e => e.Department)
                        .Select(group => new
                        {
                            Department = group.Key,
                            Average = group.Average(e => e.Salary)
                        });

        foreach (var item in avgSalary)
        {
            Console.WriteLine($"{item.Department} - ${item.Average:F2}");
        }
    }
}*/

