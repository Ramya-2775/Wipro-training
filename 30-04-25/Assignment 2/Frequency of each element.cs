using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 1, 3, 2, 1 };
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        foreach (var pair in freq)
        {
            Console.WriteLine($"{pair.Key} occurs {pair.Value} time(s)");
        }
    }
}
