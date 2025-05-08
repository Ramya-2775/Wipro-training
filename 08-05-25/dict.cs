using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        //Adding elements
        students.Add(101, "Ramya");
        students.Add(102, "Sowmya");
        students.Add(103, "Reddy");

        //Accessing values using keys
        Console.WriteLine("Student with ID 102:" + students[102]);

        //looping through the dict
        foreach (var pair in students)
        {
            Console.WriteLine($"ID:{pair.Key}, Name: {pair.Value}");
        }
    }
}
