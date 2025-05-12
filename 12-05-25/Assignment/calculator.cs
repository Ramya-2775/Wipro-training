using System.ComponentModel.Design;

interface icalculator
{
    void add (int a , int b);
    void sub(int a , int b); 
    void mul(int a , int b);
    void divide(int a , int b);
}
class simplecalculator : icalculator
{
    public void add(int a, int b)
    {
        Console.WriteLine($"Addition of {a} + {b} = {a+b}");
    }

    public void sub(int a , int b)
    {
        Console.WriteLine($"subtraction of {a}-{b} = {a-b}");
    }

    public void mul(int a, int b)
    { 
        Console.WriteLine($"multiplication of {a}*{b} = {a *b}");
    }

    public void divide(int a , int b)
    {
        if (b != 0)
        {
            Console.WriteLine($"division of {a}/{b} = {a / b}");
        }
        else
        { 
            Console.WriteLine("Divison by zero is not allowed");
        }
    }
class program
    {
        static void Main()
        {
            icalculator calculator =  new simplecalculator();
            calculator.add (3, 4);
            calculator.sub (9, 6);
            calculator.mul (6,7);
            calculator.divide  (5, 2);
        }
    }

}