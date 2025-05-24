using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started...");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed.");
    }

    static async Task Main()
    {
        Stopwatch sw = Stopwatch.StartNew();
        await SimulateWorkAsync("Job1", 1000);
        await SimulateWorkAsync("Job2", 1000);
        await SimulateWorkAsync("Job3", 1000);
        sw.Stop();
        Console.WriteLine($"Sequential time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        Task t1 = SimulateWorkAsync("Job1", 1000);
        Task t2 = SimulateWorkAsync("Job2", 1000);
        Task t3 = SimulateWorkAsync("Job3", 1000);
        await Task.WhenAll(t1, t2, t3);
        sw.Stop();
        Console.WriteLine($"Sequential time: {sw.ElapsedMilliseconds} ms");
    }
}