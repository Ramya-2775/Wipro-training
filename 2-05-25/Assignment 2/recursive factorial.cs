using System;

class Program
{
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
    static void Main()
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7};

        foreach (int num in numbers)
        {
            int result = Factorial(num);
            Console.WriteLine("Factorial of " + num + " is " + result);
        }
    }
}
