using System;

public class HelloWorld
{
    static int sub(int a,int b)
    {
        return a-b;
    }
    static void Main()
    {
        int num1= 10;
        int num2 = 5;
        
        Console.WriteLine("subtract: " + sub(num1,num2));
    }
}