using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void ProcessItem(object item)
    {
        Console.WriteLine($"Processing {item}...");
        Thread.Sleep(1000);
        Console.WriteLine($"{item} done.");
    }

    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            ThreadPool.QueueUserWorkItem(ProcessItem, $"Item {i}");
        }

        Console.ReadLine(); 
    }
}

