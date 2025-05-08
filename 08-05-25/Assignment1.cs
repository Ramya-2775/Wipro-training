using System;
using System.Collections.Generic;
class Employee
{
    public int ID;
    public string Name;
}

class program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee { ID = 1, Name = "Ramya" });
        employees.Add(new Employee { ID = 2, Name = "Reddy" });
        employees.Add(new Employee { ID = 3, Name = "prasad" });
        employees.Add(new Employee { ID = 4, Name = "Bhavana" });
        employees.Add(new Employee { ID = 5, Name = "Vara" });


        //remove 
        employees.RemoveAll(e => e.Name == "prasad");

        //check if ramya exists
        bool found = employees.Exists(e => e.Name == "Ramya");
        Console.WriteLine(found ? "Ramya exists": "RAmya not found");

        //print total employees
        Console.WriteLine("Total:" + employees.Count);

        //print all employee details
        foreach(var e in employees)
        {
            Console.WriteLine($"ID: { e.ID}, Name: { e.Name}");
        }
    }
}