using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        //create a list 
        List<int> numbers = new List<int> { 1, 2, 4, 2, 5, 7, 5, 8, 9, 9 };
        Console.WriteLine("original list:");
        foreach(int num in numbers)
        {
            Console.WriteLine(num + " ");
        }

        //find unique numbers
        List<int> uniqueNumbers = new List<int>();
        foreach(int num in numbers)
        {
            if(!uniqueNumbers.Contains(num))
            {
                uniqueNumbers.Add(num);
            }
        }
        Console.WriteLine("\n\nunique Numbers:");
        foreach(int num in uniqueNumbers)
        {
            Console.WriteLine(num + " ");
        }
        //count unique elemnts
        Console.WriteLine($"\n\nTotal unique elements: {uniqueNumbers.Count}");
    }
}