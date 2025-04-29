using System;
public class EvenOddCheck
{
    public static void Main()
    {
        int number;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is even.");
        }
        else
        {
            Console.WriteLine(number + " is odd.");
        }
    }
}
