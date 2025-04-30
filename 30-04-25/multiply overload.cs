using System;

class Program
{
    static int multiply(int a, int b)
    {
        return a * b;
    }

    static double multiply(double a, double b)
    {
        return a * b;
    }

    static void Main()
    {
        Console.WriteLine("int multiply: " + multiply(3, 7));
        Console.WriteLine("double multiply: " + multiply(2.5, 4.0));
    }
}
