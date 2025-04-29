using System;

public class HelloWorld
{
    static int mul(int a,int b)
    {
        return a * b;
    }
    static void Main()
    {
        int num1= 5;
        int num2 = 8;
        
        Console.WriteLine("Multiply: " + mul(num1,num2));
    }
}