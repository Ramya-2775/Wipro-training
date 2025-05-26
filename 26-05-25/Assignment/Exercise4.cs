using System;
using System.Collections.Generic;
using System.Threading;

/*namespace ThreadQueueExample
{
    class Program
    {
        static Queue<string> workQueue = new();
        static object lockObj = new();
        static bool done = false;

        static void Worker()
        {
            while (!done || workQueue.Count > 0)
            {
                string task = null;
                lock (lockObj)
                {
                    if (workQueue.Count > 0)
                        task = workQueue.Dequeue();
                }

                if (task != null)
                {
                    Console.WriteLine($"Processing: {task}");
                    Thread.Sleep(500);
                }
            }
        }

        static void Main()
        {
            var thread = new Thread(Worker);
            thread.Start();

            for (int i = 1; i <= 5; i++)
            {
                lock (lockObj)
                    workQueue.Enqueue($"Task {i}");
                Thread.Sleep(100);
            }

            done = true;
            thread.Join();
        }
    }
}*/