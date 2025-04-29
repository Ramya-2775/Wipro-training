using System;

public class HelloWorld
{
    static int add(int a,int b)
    {
        return a + b;
    }
    static void Main()
    {
        int num1= 5;
        int num2 = 8;
        
        Console.WriteLine("Addition: " + add(num1,num2));
    }
}