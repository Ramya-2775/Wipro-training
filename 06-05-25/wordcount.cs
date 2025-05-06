using System;
class program
{
    static int countwords(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
            return 0;
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    static void Main()
    {
        string input = "Hii My Name is Ramya";
        int wordcount = countwords(input);
        Console.WriteLine("Number of words:" + wordcount);
    }
}
