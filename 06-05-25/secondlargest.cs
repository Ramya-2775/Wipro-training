using System;
using System.Security.Cryptography.X509Certificates;
class program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int secondlargest = FindSecondLargest(numbers);
        Console.WriteLine("second largest element is : " + secondlargest);
    }
    static int FindSecondLargest(int[] arr)
    {
        if (arr.Length < 2)
        {
            Console.WriteLine("Array must contain atleast two elements");
            return int.MaxValue;
        }
        int first = int.MinValue;
        int second = int.MinValue;
        foreach (int num in arr)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num > second && num != first)
            {
                second = num;
            }
        }
        if (second == int.MinValue)
        {
            Console.WriteLine("No second largest element found");
            return int.MaxValue;

        }
        return second;
    }
}


