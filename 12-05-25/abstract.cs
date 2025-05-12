abstract class shape
{
    public abstract void draw();
    public void display()
    {
        Console.WriteLine("this is a shape");
    }

}
class circle : shape
{
    public override void draw()
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