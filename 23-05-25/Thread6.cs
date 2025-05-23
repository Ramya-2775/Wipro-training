using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Work started");

        await DoAsyncWork();

        Console.WriteLine("Work completed.");
    }
    static async Task DoAsyncWork()
    {
        Console.WriteLine("Working asynchronously..");
        await Task.Delay(1000);
        Console.WriteLine("Async work done");

    }
}