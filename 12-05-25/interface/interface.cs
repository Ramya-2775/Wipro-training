interface ishape
{
    void draw();
}

class circle: ishape
{
    public void draw()
    {
        Console.WriteLine("drawing a circle");
    }
}
class program
{
    static void Main()
    {
        circle circle = new circle();
        circle.draw();
    }
}