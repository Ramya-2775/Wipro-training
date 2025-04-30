using System;
class Program 
{
    static void printArray(int[] arr)
    {
        for(int i = arr.Length-1;i>=0;--i)
        {
            Console.WriteLine($"Element{i+1}: {arr[i]}");
        }
    }

    static void Main()
    {
        int[] numbers = {10, 20, 29, 40, 90};
        printArray(numbers);
    }
}
