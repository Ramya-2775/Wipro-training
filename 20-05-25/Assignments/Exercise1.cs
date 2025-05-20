using System.Diagnostics;

class SortingAlgorithms
{
    // Bubble Sort
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Selection Sort
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Swap
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    // Insertion Sort
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    static void Main()
    {
        Random rand = new Random();

        // Generate list of 20 random integers between 1 and 100
        int[] originalArray = new int[20];
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Original Array:");
        PrintArray(originalArray);
        Console.WriteLine();

        // Measure time and execute sort
        void TestSort(string sortName, Action<int[]> sortMethod)
        {
            int[] arrCopy = (int[])originalArray.Clone();

            Stopwatch stopwatch = Stopwatch.StartNew();
            sortMethod(arrCopy);
            stopwatch.Stop();

            Console.WriteLine($"{sortName} Result:");
            PrintArray(arrCopy);
            Console.WriteLine($"Time taken: {stopwatch.ElapsedTicks} ticks ({stopwatch.ElapsedMilliseconds} ms)");
            Console.WriteLine();
        }

        TestSort("Bubble Sort", BubbleSort);
        TestSort("Selection Sort", SelectionSort);
        TestSort("Insertion Sort", InsertionSort);
    }
}

