using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 20, 40, 60 };

        int index = numbers.IndexOf(60);
        Console.WriteLine("Index of 60 is:" + index);

        bool contains = numbers.Contains(40);
        Console.WriteLine("contains 40 at:" + contains);
    }
}