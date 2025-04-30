using System;

class Program
{
    static int subtract(int a, int b)
    {
        return a - b;
    }

    static double subtract(double a, double b)
    {
        return a - b;
    }

    static void Main()
    {
        Console.WriteLine("int subtract: " + subtract(9, 4));
        Console.WriteLine("double subtract: " + subtract(10.5, 4.2));
    }
}
