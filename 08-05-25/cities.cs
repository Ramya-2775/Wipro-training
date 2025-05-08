using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string>
        {
            { "Mumbai", "Maharastra" },
            { "Banglore" , "Karnataka" },
            { "Chennai", "Tamilnadu" }
        };

        Console.WriteLine("Indian cities and their states:");
        foreach (var city in cities)
        {
            Console.WriteLine($"ID:{city.Key}, Name: {city.Value}");
        }

        //check if specific city exists
        if (cities.ContainsKey("chennai"))
        {
            Console.WriteLine("chennai is present in the dictionary");
        }
    }
}
