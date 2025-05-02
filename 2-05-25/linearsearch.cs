using System;

class Program
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static void Main()
    {
        int[] numbers = { 30, 50, 60, 89, 22 };
        int target = 89;
        int result = LinearSearch(numbers, target);

        if (result != -1)
            Console.WriteLine($"Element {target} found at index {result}");
        else
            Console.WriteLine($"Element {target} not found");
    }
}
