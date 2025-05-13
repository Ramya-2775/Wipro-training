using System;
using System.Reflection.Metadata;
interface itransport
{
    void start();
    void stop();
}

class bus : itransport
{
    public void start()
    {
        Console.WriteLine("bus is starting");
    }
    public void stop()
    {
        Console.WriteLine("bus is stopping");
    }
}
class train : itransport
{
    public void start()
    {
        Console.WriteLine("train is starting");
    }
    public void stop()
    {
        Console.WriteLine("train is stopping");
    }
}
class program
{
    static void Main(string[] args)
    {
        itransport bus = new bus();
        itransport train = new train();

        bus.stop();
        bus.start();

        train.start();
        train.stop();
    }
}




