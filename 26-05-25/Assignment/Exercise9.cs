using System;
using System.Threading.Tasks;

/*namespace ParallelTaskErrors
{
    class Program
    {
        static async Task Main()
        {
            var tasks = new[]
            {
                Task.Run(() => Console.WriteLine("Task 1 completed")),
                Task.Run(() => throw new Exception("Task 2 failed")),
                Task.Run(() => Console.WriteLine("Task 3 completed")),
                Task.Run(() => throw new Exception("Task 4 failed")),
                Task.Run(() => Console.WriteLine("Task 5 completed"))
            };

            try
            {
                await Task.WhenAll(tasks);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Some tasks failed:");
                foreach (var e in ex.InnerExceptions)
                    Console.WriteLine($" - {e.Message}");
            }

            Console.WriteLine("All tasks attempted.");
        }
    }
}*/