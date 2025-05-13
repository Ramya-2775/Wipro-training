using System;
using System.Linq;

delegate void customdel(string s);

class testclass
{
    static void hello(string s)
    {
        Console.WriteLine($"hello,{s}");
    }
    static void Main()
    {
        customdel hidel;

        hidel = hello;

        Console.WriteLine("invoking delegate hidel:");
        hidel("A");
    }
}

