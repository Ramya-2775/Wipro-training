using System;
using System.Collections;
class program
{
    static void Main()
    {
        //create array list
        ArrayList studentnames = new ArrayList();

        //Add 5 names to the list
        studentnames.Add("Ramya");
        studentnames.Add("Reddy");
        studentnames.Add("sowmya");
        studentnames.Add("prasad");
        studentnames.Add("geetha");

        Console.WriteLine("original list of students:");
        foreach (string name in studentnames)
        {
            Console.WriteLine(name);
        }

        //remove specific name
        studentnames.Remove("geetha");

        //display list after removal
        Console.WriteLine("\nList after removing 'geetha' :");
        foreach (string name in studentnames)
        {
            Console.WriteLine(name);
        }

        //check if name exists
        string nameToCheck = "sowmya";
        if (studentnames.Contains(nameToCheck))
        {
            Console.WriteLine($"\n{nameToCheck} is present in the list");
        }
        else
        { 
            Console.WriteLine($"\n{nameToCheck} is not found in the list");
        }
    }
}
