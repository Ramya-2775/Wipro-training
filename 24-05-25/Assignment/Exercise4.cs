using System.Diagnostics;
using System.Threading;

class Program
{
    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"{fileName} download started...");
        await Task.Delay(delay);
        Console.WriteLine($"{fileName} downloaded.");
    }

    static async Task Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        Task t1 = DownloadFileAsync("File1", 2000);
        Task t2 = DownloadFileAsync("File2", 3000);
        Task t3 = DownloadFileAsync("File3", 1000);

        await Task.WhenAll(t1, t2, t3);

        sw.Stop();
        Console.WriteLine($"All downloads completed in {sw.ElapsedMilliseconds} ms");
    }
}