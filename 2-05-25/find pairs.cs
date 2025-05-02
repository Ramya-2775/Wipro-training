using System;

class PairSumExample
{
    static void FindPairsWithSum(int[] array, int target)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == target)
                {
                    Console.WriteLine($"{array[i]} + {array[j]} = {target}");
                }
            }
        }
    }

    static void Main()
    {
        int[] numbers = { 1,2,3,4,5,6,7,8,9,0 };
        int targetSum = 15;
        FindPairsWithSum(numbers, targetSum);
    }
}
