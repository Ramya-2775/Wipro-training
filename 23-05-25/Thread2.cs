using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void Main()
    {
        int a = 5;
        int b = 9;

        Thread thread = new Thread(() =>
        {
            Console.WriteLine($"Sum:{a + b}");

        });
        thread.Start();
    }
}
