using System;
/*namespace BatchImageProcessing
{
    class Program
    {
        static async Task Main()
        {
            var images = new List<string>();
            for (int i = 1; i <= 20; i++)
                images.Add($"Image_{i}.jpg");

            int total = images.Count;
            int processed = 0;
            object lockObj = new();

            await Parallel.ForEachAsync(images, async (img, token) =>
            {
                await Task.Delay(200); // Simulate processing
                lock (lockObj)
                {
                    processed++;
                    Console.WriteLine($"Processed {img} - {processed * 100 / total}% complete");
                }
            });
        }
    }
}*/