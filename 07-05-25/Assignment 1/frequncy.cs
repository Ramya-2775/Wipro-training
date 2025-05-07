using System;
using System.Collections.Generic;
class program
{
    static void printfrequencies(int[]arr)
    {
        Dictionary<int, int> frequnecy = new Dictionary<int, int>();
        foreach (int num in arr)
            {
            if (frequnecy.ContainsKey(num))
                frequnecy[num]++;
            else
                frequnecy[num] = 1;
        }
        foreach (var item in frequnecy)
            {
            Console.WriteLine($"Element {item.Key} appears {item.Value} time(s).");
        }
    }
    static void Main()
    {
        int[] numbers = { 2, 3, 4, 5, 6, 76, 4, 5, 8, 2, 3};
        printfrequencies(numbers);
    }
}