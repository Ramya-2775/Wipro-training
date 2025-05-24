using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*class Program
{
    static async Task<string> TaskWithDelay(string name, int delay)
    {
        await Task.Delay(delay);
        return name;
    }

    static async Task Main()
    {
        Task<string> t1 = TaskWithDelay("Task1", 3000);
        Task<string> t2 = TaskWithDelay("Task2", 1000);
        Task<string> t3 = TaskWithDelay("Task3", 2000);

        Task<string> firstFinished = await Task.WhenAny(t1, t2, t3);
        Console.WriteLine($"First finished: {firstFinished.Result}");
    }
}
*/