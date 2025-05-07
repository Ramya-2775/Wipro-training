
using System;
using System.Collections;
using System.Globalization;
class program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList() { 4, 1, 8, 3 };
        numbers.Sort();
        Console.WriteLine("sorted");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
        numbers.Reverse();
        Console.WriteLine("Reversed");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}