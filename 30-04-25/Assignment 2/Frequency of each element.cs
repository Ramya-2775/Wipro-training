using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 1, 3, 2, 1 };
        int n = arr.Length;

        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++)
        {
            if (visited[i] == true)
                continue;

            int count = 1;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true;
                }
            }

            Console.WriteLine(arr[i] + " occurs " + count + " time(s)");
        }
    }
}
