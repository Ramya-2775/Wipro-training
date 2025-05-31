using System;
using System.Collections.Generic;
using System.Linq;

/*class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string paragraph = Console.ReadLine();

        char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r', '\t' };
        string[] words = paragraph
            .ToLower()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries);

        
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
                wordFrequency[word]++;
            else
                wordFrequency[word] = 1;
        }

        
        int vowelsCount = 0;
        int consonantsCount = 0;

        foreach (char ch in paragraph.ToLower())
        {
            if ("aeiou".Contains(ch))
                vowelsCount++;
            else if (ch >= 'a' && ch <= 'z')
                consonantsCount++;
        }

        string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault() ?? "";
        string shortestWord = words.OrderBy(w => w.Length).FirstOrDefault() ?? "";

        Console.WriteLine("\nWord Frequencies:");
        foreach (var pair in wordFrequency)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }

        Console.WriteLine($"\nTotal vowels: {vowelsCount}");
        Console.WriteLine($"Total consonants: {consonantsCount}");

        Console.WriteLine($"Longest word: {longestWord}");
        Console.WriteLine($"Shortest word: {shortestWord}");
    }
}*/
