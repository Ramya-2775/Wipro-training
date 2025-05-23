using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static bool pause = false;
    static bool stop = false;

    static void DoWork()
    {
        while(!stop)
        {
            if(pause)
            {
                Console.WriteLine("Thread paused...");
                Thread.Sleep(500);
                continue;
            }
            Console.WriteLine("Thread is working...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Thread has stopped");
    }

    static void Main()
    {
        Thread worker = new Thread(DoWork);

        Console.WriteLine("Initial thread state:" + worker.ThreadState);
        worker.Start();

        Thread.Sleep(300);
        pause = true;
        Console.WriteLine("Paused thread state: " + worker.ThreadState);

        Thread.Sleep(300);
        pause = false;
        Console.WriteLine("Resuming work");

        Thread.Sleep(300);
        stop = true;
        Console.WriteLine("Stopping thread");

        worker.Join();
        Console.WriteLine("Final thread state: " + worker.ThreadState);

    }
}