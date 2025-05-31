using System;

class Calculator
{
    // Add methods
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static float Add(float a, float b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    // Subtract methods
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static float Subtract(float a, float b)
    {
        return a - b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Multiply methods
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static float Multiply(float a, float b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }
}

/*class Program
{
    static void Main()
    {
        Console.WriteLine("Enter operation (add, subtract, multiply):");
        string operation = Console.ReadLine().ToLower();

        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();

        
        if (int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
        {
            PerformOperation(operation, int1, int2);
        }
        else if (float.TryParse(input1, out float float1) && float.TryParse(input2, out float float2))
        {
            PerformOperation(operation, float1, float2);
        }
        else if (double.TryParse(input1, out double double1) && double.TryParse(input2, out double double2))
        {
            PerformOperation(operation, double1, double2);
        }
        else
        {
            Console.WriteLine("Invalid input numbers.");
        }
    }

    static void PerformOperation(string operation, int a, int b)
    {
        switch (operation)
        {
            case "add":
                Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                break;
            case "subtract":
                Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                break;
            case "multiply":
                Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                break;
            default:
                Console.WriteLine("Unknown operation.");
                break;
        }
    }

    static void PerformOperation(string operation, float a, float b)
    {
        switch (operation)
        {
            case "add":
                Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                break;
            case "subtract":
                Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                break;
            case "multiply":
                Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                break;
            default:
                Console.WriteLine("Unknown operation.");
                break;
        }
    }

    static void PerformOperation(string operation, double a, double b)
    {
        switch (operation)
        {
            case "add":
                Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                break;
            case "subtract":
                Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                break;
            case "multiply":
                Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                break;
            default:
                Console.WriteLine("Unknown operation.");
                break;
        }
    }
}*/