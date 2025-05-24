using System;
using System.Threading;

class Program
{
    static bool pause = false;
    static bool stop = false;

    static void PrintNumbers()
    {
        for (int i = 1; i <= 100; i++)
        {
            while (pause) Thread.Sleep(100);
            if (stop) break;
            Console.WriteLine(i);
            Thread.Sleep(100); // Simulate work
        }
        Console.WriteLine("Thread exiting...");
    }

    static void Main()
    {
        Thread thread = new Thread(PrintNumbers);
        thread.Start();
        Console.WriteLine("Thread started...");

        Thread.Sleep(2000);
        pause = true;
        Console.WriteLine("Thread paused...");

        Thread.Sleep(2000);
        pause = false;
        Console.WriteLine("Thread resumed...");

        Thread.Sleep(2000);
        stop = true;
        Console.WriteLine("Thread stop requested...");

        thread.Join();
        Console.WriteLine("Main finished.");
    }
}
