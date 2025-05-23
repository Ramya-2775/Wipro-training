using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void PrintMessage(object Message)
    {
        string msg = (string)Message;
        Console.WriteLine("Message: " + msg);
    }

    static void Main()
    {
        Thread thread = new Thread (new ParameterizedThreadStart (PrintMessage));
        thread.Start ("Hello,from the thread");
    }
}