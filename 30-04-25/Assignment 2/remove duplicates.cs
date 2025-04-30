using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 1 };
        int n = arr.Length;

        Console.Write("Array without duplicates: ");

        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
