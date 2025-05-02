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
    static void PrintFactorialRepresentation(int n)
    {
        if (n == 1)
        {
            Console.Write("1");
            return;
        }
        Console.Write(n + "*");
        PrintFactorialRepresentation(n - 1);
    }

    static void Main()
    {
        int[] numbers = { 7, 6, 5, 4, 3, 2, 1 }; 
        Console.Write("Factorial of 7 is: ");
        PrintFactorialRepresentation(7);
        Console.WriteLine();
        int result = Factorial(7);
        Console.WriteLine("Factorial of 7 is: " + result);
    }
}
