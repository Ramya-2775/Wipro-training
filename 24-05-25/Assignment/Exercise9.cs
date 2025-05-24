using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"Working {i + 1}...");
            await Task.Delay(500);
        }
    }

    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var task = DoWorkAsync(cts.Token);

        Task.Run(() =>
        {
            Thread.Sleep(2000);
            cts.Cancel();
            Console.WriteLine("Cancellation requested!");
        });

        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Task was canceled.");
        }
    }
}