using System;
using System.Threading.Tasks;
using System.Diagnostics;

/*class Program
{
    static async Task Main()
    {
        Console.WriteLine("Fetching weather for 3 cities...\n");

        Stopwatch sw = Stopwatch.StartNew(); 

       
        Task<string> city1 = FetchWeatherAsync("Hyderabad", 2000);  
        Task<string> city2 = FetchWeatherAsync("Delhi", 3000);      
        Task<string> city3 = FetchWeatherAsync("Mumbai", 2500);     

        
        string[] results = await Task.WhenAll(city1, city2, city3);

        sw.Stop(); 

        
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine($"\nTotal time taken: {sw.ElapsedMilliseconds} ms");
    }

    static async Task<string> FetchWeatherAsync(string city, int delay)
    {
        await Task.Delay(delay); 
        return $"{city}: 32°C, Sunny (Fetched in {delay} ms)";
    }
}
*/