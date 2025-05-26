using System;
using System.Threading.Tasks;

/*namespace FastestServerSimulation
{
    class Program
    {
        static async Task<string> SimulateServer(string name, CancellationToken token)
        {
            int delay = new Random().Next(500, 2000);
            await Task.Delay(delay, token);
            return $"{name} responded in {delay}ms";
        }

        static async Task Main()
        {
            var cts = new CancellationTokenSource();
            var tasks = new[]
            {
                SimulateServer("Server1", cts.Token),
                SimulateServer("Server2", cts.Token),
                SimulateServer("Server3", cts.Token)
            };

            var fastest = await Task.WhenAny(tasks);
            cts.Cancel();

            Console.WriteLine(await fastest);
        }
    }
}*/