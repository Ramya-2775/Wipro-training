using System;

class shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");


    }
}
class circle : shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
class program
{
    static void Main()
    {
        shape shape = new shape();
        shape.Draw();

        circle circle = new circle();
        circle.Draw();

        shape polyshape = new shape();
        polyshape.Draw();

    }
}