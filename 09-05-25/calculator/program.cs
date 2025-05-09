using ConsoleApp1;
using System;
 class program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        //Add
        Console.WriteLine("Additiion:");
        Console.WriteLine("7 + 9 = " + calc.add(7, 9));
        Console.WriteLine("3.5 + 9.7 = " + calc.add(3.5, 9.7));
        Console.WriteLine("3 + 5 +7 =  " + calc.add(3, 5, 7));
    }
}