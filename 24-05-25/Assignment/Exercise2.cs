using System.Xml.Linq;

using System.Threading;

/*class Program
{
    static void Task(string name, int delay)
    {
        Console.WriteLine($"{name} started...");
        Thread.Sleep(delay);
        Console.WriteLine($"{name} completed.");
    }
    
    static void Main()
    {
        Thread t1 = new Thread(() => Task("Printer", 1000));
        Thread t2 = new Thread(() => Task("Calculator", 1500));
        Thread t3 = new Thread(() => Task("Waiter", 2000));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("All tasks done.");
    }
}*/