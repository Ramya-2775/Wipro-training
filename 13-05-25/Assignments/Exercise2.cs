using System;
using System;
using System.Reflection.Metadata;
interface iorder
{
    void placeorder(string item);
    void cancelorder(string item);
}

class dineinorder : iorder
{
    public void placeorder(string item)
    {
        Console.WriteLine($"place dine-in-order for {item}");
    }
    public void cancelorder(string item)
    {

        Console.WriteLine($"cancelling dine-in-order for {item}");
    }
}


class takeawayorder : iorder
{
    public void placeorder(string item)
    {
        Console.WriteLine($"placing take away order for {item}");
    }
    public void cancelorder(string item)
    {
        Console.WriteLine($"cancelling take away order for {item}");
    }
}
class program
{
    static void Main(string[] args)
    {
        iorder dinein = new dineinorder();
        iorder takeaway = new takeawayorder();

        dinein.placeorder("coffee");
        dinein.cancelorder("coffee");

        takeaway.placeorder("biryani");
        takeaway.cancelorder("biryani");


    }
}





