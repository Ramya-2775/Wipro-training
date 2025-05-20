using System;

class SearchingAlgorithms
{
    // Linear Search
    static int LinearSearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
                return i;
        }
        return -1;
    }

    // Binary Search
    static int BinarySearch(int[] arr, int key, out int comparisons)
    {
        int left = 0, right = arr.Length - 1;
        comparisons = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            comparisons++;
            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    static void Main()
    {
        Random rand = new Random();

        //sorted list
        int[] sortedArray = new int[50];
        for (int i = 0; i < sortedArray.Length; i++)
        {
            sortedArray[i] = rand.Next(1, 201);
        }
        Array.Sort(sortedArray);

        Console.WriteLine("Sorted List:");
        PrintArray(sortedArray);
        Console.WriteLine();

        int key = rand.Next(1, 201);
        Console.WriteLine($"Searching for: {key}");
        Console.WriteLine();

        // Linear Search
        int linearComparisons;
        int linearPos = LinearSearch(sortedArray, key, out linearComparisons);
        Console.WriteLine("Linear Search:");
        Console.WriteLine($"Position: {linearPos}");
        Console.WriteLine($"Comparisons: {linearComparisons}");
        Console.WriteLine();

        // Binary Search
        int binaryComparisons;
        int binaryPos = BinarySearch(sortedArray, key, out binaryComparisons);
        Console.WriteLine("Binary Search:");
        Console.WriteLine($"Position: {binaryPos}");
        Console.WriteLine($"Comparisons: {binaryComparisons}");
        Console.WriteLine();

        // Efficiency comparison note
        Console.WriteLine("Efficiency Comparison:");
        Console.WriteLine("- Linear Search compares each element one by one (up to n times).");
        Console.WriteLine("- Binary Search halves the search space each time (about log₂n comparisons).");
    }
}
