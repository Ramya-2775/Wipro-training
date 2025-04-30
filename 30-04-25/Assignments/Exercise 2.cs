//find the sum of digits of a number

using System;

public class SumOfDigits
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        while (num != 0)
        {
            int digit = num % 10;
            sum += digit;          
            num /= 10;            
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
