using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        Dictionary<int, string> employees= new Dictionary<int, string>
        {
            { 1, "Ramya"},
            { 2, "sowmya"},
            { 3, "Reddy"}
        }
        ;

        //updateing th employee id 2
        employees[2] = "prasad";

        Console.WriteLine("updated employee list");

        //looping through the dict
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID:{emp.Key}, Name: {emp.Value}");
        }
    }
}
