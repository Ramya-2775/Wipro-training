using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        int start = 0;
        int end = input.Length - 1;

        while (start < end)
        {
            if (input[start] != input[end])
                return false;

            start++;
            end--;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        if (IsPalindrome(word))
            Console.WriteLine($"{word} is a palindrome.");
        else
            Console.WriteLine($"{word} is not a palindrome.");
    }
}
