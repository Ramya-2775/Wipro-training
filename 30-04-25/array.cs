using System;
class program 
{
    static void printArray(int[]arr)
    {
        for(int i = 0; i< arr.Length; i++)
        {
            Console.WriteLine($"Element{i+1}:{arr[i]}");
        }
    }
    static void Main()
    {
        int[]numbers = {10,20,29,40,90};
        printArray(numbers);
    }
}
