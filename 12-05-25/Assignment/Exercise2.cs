interface ianimalactions
{
    void eat();
    void sleep();
}
class lion : ianimalactions
{
    public void eat()
    {
        Console.WriteLine("lion is eating");
    }
    public void sleep()
    {
        Console.WriteLine("lion is sleeping");
    }
}
class elephant : ianimalactions
{
    public void eat()
    {
        Console.WriteLine("elephant is eating");
    }
    public void sleep()
    {
        Console.WriteLine("elephant is sleeping");
    }
}
class program
{
    static void Main()
    {
        ianimalactions lion = new lion();
        ianimalactions elephant = new elephant();

        lion.eat();
        lion.sleep();

        elephant.eat();
        elephant.sleep();


    }
}
