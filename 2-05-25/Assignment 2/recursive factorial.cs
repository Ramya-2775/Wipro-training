using System;

class Program
{
    // Recursive method to calculate factorial of a number
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    // Method to print the multiplication representation of factorial
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
        int[] numbers = { 7, 6, 5, 4, 3, 2, 1 }; // Your array

        // Print multiplication representation for factorial of 7
        Console.Write("Factorial of 7 is: ");
        PrintFactorialRepresentation(7);
        Console.WriteLine();
        
        // Calculate and display the factorial result for 7
        int result = Factorial(7);
        Console.WriteLine("Factorial of 7 is: " + result);
    }
}
