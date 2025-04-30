using System;

class program
{
    static int add(int a, int b)
    {
        return a+b;
    }
    static double add(double a,double b)
    {
        return a+b;
    }
    static void Main()
    {
        Console.WriteLine(" int add:"+ add (4,5));
        Console.WriteLine("double add:"+add(3.4,6.8));
    }
}
    