using System;
class program
{
    static string findlongestword(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string longestword = "";
        foreach (string word in words)
        {
            if (word.Length > longestword.Length)
                longestword = word;
        }
        return longestword;
    }
    static void Main()
    {
        Console.Write("enter a sentence:");
        string input = Console.ReadLine();

        string longest = findlongestword(input);
        Console.WriteLine("the longest word is:" + longest);
    }
}