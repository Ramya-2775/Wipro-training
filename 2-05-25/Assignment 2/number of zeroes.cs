using System;

class Program
{
    static int CountZeroes(int n)
    {
        if (n == 0) 
            return 0;
        else
        {
            return (n % 10 == 0 ? 1 : 0) + CountZeroes(n / 10);
        }
    }

    static void Main()
    {
        int number = 2080904; 
        int result = CountZeroes(number);
        Console.WriteLine("Number of zeroes in " + number + " is " + result);
    }
}
