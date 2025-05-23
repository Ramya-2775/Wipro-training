using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void DoWork(object state)
    {
        Console.WriteLine($"Threadpool Task Started - {state}");
        Thread.Sleep(1000);
        Console.WriteLine($"Threadpool Task Finished- {state}");
    }

    static void Main()
    {
        for(int i = 1; i < 5; i++)
        {
            ThreadPool.QueueUserWorkItem(DoWork, $"Task {i}");
        }
        Console.WriteLine("Main thread continues..");
        Thread.Sleep(3000);
        Console.WriteLine("Main thread ends");
    }
}