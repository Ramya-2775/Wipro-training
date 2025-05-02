using System;

class Program
{
    static int SumOfDigits(int n)
    {
        if (n == 0)
            return 0;
        else
            return n % 10 + SumOfDigits(n / 10);
    }

    static void Main()
    {
        int number = 12345;
        int result = SumOfDigits(number);
        Console.WriteLine("Sum of digits of " + number + " is " + result);
    }
}
