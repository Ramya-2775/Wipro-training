using System;
using System.Collections.Generic;
using System.Diagnostics;
class program
{
    static void Main(string[]args)
    {
        List<string> studentNames = new List<string>();

        studentNames.Add("Ramya");
        studentNames.Add("Bhavana");
        studentNames.Add("Vara");
        studentNames.Add("Prasad");
        studentNames.Add("Reddy");

        string nameToCheck = "Bhavana";
        if(studentNames.Contains(nameToCheck))
        {
            Console.WriteLine($"{nameToCheck} exists in the list");
        }
        else
        {
            Console.WriteLine($"{nameToCheck} does not exists in the list");
        }

        studentNames.RemoveAt(1);

        Console.WriteLine("Final list of student names");
        foreach (string name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}