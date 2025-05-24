using System;
using System.Threading;
class Program
{
    static async Task RiskyTaskAsync(string name)
    {
        await Task.Delay(1000);
        if (name == "BadTask")
            throw new Exception($"{name} failed!");
        Console.WriteLine($"{name} succeeded.");
    }

    static async Task Main()
    {
        var tasks = new[]
        {
            RiskyTaskAsync("Task1"),
            RiskyTaskAsync("BadTask"),
            RiskyTaskAsync("Task3")
        };

        try
        {
            await Task.WhenAll(tasks);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}
