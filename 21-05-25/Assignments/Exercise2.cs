using System;
using System.Collections.Generic;
class program
{
    static void Main(string[] args)
    {
        int amount = 600;
        List<int> denominations = new List<int> { 100, 300, 40, 90, 60, 9 };
        List<int> coinsused = new List<int>();

        foreach (int coin in denominations)
        {
            while (amount >=  coin)
            {
                amount -= coin;
                coinsused.Add(coin);
            }
        }

        Console.WriteLine("coins used:" + string.Join(", ", coinsused));
        Console.WriteLine("Total coins:" + coinsused.Count);


    }


}
    
