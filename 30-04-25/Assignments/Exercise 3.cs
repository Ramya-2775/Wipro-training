//Reverse a number

using System;

public class ReverseNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int reverse = 0;
        while (num != 0)
        {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num /= 10;                      
        }

        Console.WriteLine("Reversed number: " + reverse);
    }
}
