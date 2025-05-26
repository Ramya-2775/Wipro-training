using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequencyAnalyzer
{
    class Program
    {
        static void Main()
        {
            string paragraph = "This is a test. This test is only a test. In case of an actual emergency...";

            var words = paragraph
                .ToLower()
                .Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var frequency = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (frequency.ContainsKey(word))
                    frequency[word]++;
                else
                    frequency[word] = 1;
            }

            var top5 = frequency.OrderByDescending(pair => pair.Value).Take(5);

            Console.WriteLine("Top 5 Frequent Words:");
            foreach (var pair in top5)
                Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }
}