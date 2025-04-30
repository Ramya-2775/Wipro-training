using System;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 5, 7, 8, 2, 9, 10 };
        int target = 7;
        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                Console.WriteLine(i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Not found");
        }
    }
}
