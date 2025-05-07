using System;
using System.Collections.Generic;
class Program
{
    static void printduplicatewords(string sentence)
    {
        string[] words = sentence.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordcount = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (wordcount.ContainsKey(word))
                wordcount[word]++;
            else
                wordcount[word] = 1;
        }
        Console.WriteLine("Duplicate words:");
        foreach (var pair in wordcount)
        {
            if (pair.Value > 1)
                Console.WriteLine($"{pair.Key}  - {pair.Value} times");
        }
    }
        public static void Main()
        {
            Console.Write("enter a sentence:");
            string input = Console.ReadLine();
            printduplicatewords(input);
              
        }
}