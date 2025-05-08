using System;
using System.Collections.Generic;
using System.Diagnostics;
class program
{
    static void Main(string[]args)
    {
        List<string> fruits = new List<string>() { "Apple", "Banana", "cherry" };

        //Add an element
        fruits.Add("Mango");

        //inserting element @index 1
        fruits.Insert(1, "orange");

        //removing an element by value
        fruits.Remove("Banana");

        //remove an element by index
        fruits.RemoveAt(2);

        //checking if an element exists
        if (fruits.Contains("Apple"))
            Console.WriteLine("Apple exists in the list");

        //sorting the list
        fruits.Sort();

        //printing the final list
        Console.WriteLine("Fruits list: ");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}