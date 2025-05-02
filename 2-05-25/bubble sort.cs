using System;

class Program
{
    // Method to sort the array using Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Separate method to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Before sorting:");
        PrintArray(numbers);

        BubbleSort(numbers);

        Console.WriteLine("After sorting:");
        PrintArray(numbers);
    }
}
