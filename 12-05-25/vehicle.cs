abstract class vehicle
{
    public string brand;
    public int year;

    //concrete method
    public void displyinfo()
    {
        Console.WriteLine($"brand:{brand} year:{year}");
    }

    public abstract void start();
}

class car : vehicle
{
    public override void start()
    {
        Console.WriteLine("car is starting with key");

    }
}
class bike : vehicle
{
    public override void start()
    {
        Console.WriteLine("bike is starting with kick");

    }
}
class program
{
    static void Main()
    {
        car mycar = new car();
        mycar.start();
        Console.WriteLine();


        bike mybike= new bike();   
        mybike.start();
        Console.WriteLine();    
    }
}
