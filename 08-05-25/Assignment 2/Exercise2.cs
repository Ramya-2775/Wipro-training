using System;
using System.Collections;
class program
{
    static void Main()
    {
        //create arraylist of integers
        ArrayList numbers = new ArrayList();
        Random random = new Random();

        //Add 10 random numbers btwn 1&50
        for (int i = 0; i < 10; i++)
        {
            int num = random.Next(1,51);
            numbers.Add(num);
        }
        Console.WriteLine("Original list of numbers");
        foreach (int num in numbers)
        {
            Console.WriteLine(num + " ");
        }

        //sort the list in ascending order
        numbers.Sort();
        Console.WriteLine("\n\n sorted list of elements");
        foreach (int num in numbers)
        {
            Console.WriteLine(num + " ");
        }

        //find nd print max nd min values
        int min = (int)numbers[0];
        int max = (int)numbers[numbers.Count - 1];
        Console.WriteLine($"\n\nminimum value: {min}");
        Console.WriteLine($"\n\nmaximum value: {max}");

        //calculate the average 
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"Average value:{average:F2}");
    }
}