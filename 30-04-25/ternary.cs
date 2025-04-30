using System;
class program 
{
    static int add(int a,int b)=>a+b;
    static int sub(int a,int b)=>a+b;
    static int mul(int a,int b)=>a+b;
    static double divide(int a,int b)=> (b==0)?0:(double)a/b;
    
    static void Main()
    {
        Console.WriteLine("Addition:"+add(5,5));
        Console.WriteLine("subtraction:"+sub(9,0));
        Console.WriteLine("Multiply:"+mul(7,8));
        Console.WriteLine("Divide:"+divide(9,0));
        
    }
}