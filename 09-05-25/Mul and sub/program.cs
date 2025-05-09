using ConsoleApp1;
using System;
 class program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        //Add
        Console.WriteLine("Multiplication:");
        Console.WriteLine("7 * 9 = " + calc.Mul(7, 9));
        Console.WriteLine("3.5 * 9.7 = " + calc.Mul(3.5, 9.7));
        Console.WriteLine("3 * 5 * 8 =  " + calc.Mul(3, 5, 7));

        Console.WriteLine("Subtraction:");
        Console.WriteLine("7 - 9 = " + calc.sub(7, 9));
        Console.WriteLine("3.5 - 9.7 = " + calc.sub(3.5, 9.7));
        Console.WriteLine("3 - 5 - 8 =  " + calc.sub(3, 5, 7));

    }
}