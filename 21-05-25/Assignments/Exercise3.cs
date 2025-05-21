using System;
using System.Collections.Generic;
class program
{
    static void Main(string[]args)
    {
        string input = "Ramya";

        Dictionary<char,int> charcount = new Dictionary<char,int>();

        foreach (char c in input)
        {
            if (charcount.ContainsKey(c))
                charcount[c]++;
            else
                charcount[c] = 1;
        }
        foreach (char c in input)
        {
            if (charcount[c] == 1)
            {
                Console.WriteLine("First non repeating character:" + c);
                return;
            }
        }
        Console.WriteLine("No non repeating character found");
     }
}
  
