using System;
abstract class book
{
    public abstract void read();

    public void getinfo()
    {
        Console.WriteLine("this is a book");
    }

}

class fictionbook : book
{
    public override void read()
    {
        Console.WriteLine("Reading a fiction book");
    }
}
    
class sciencebook : book
{
    public override void read()
    {
        Console.WriteLine("Reading a science book");
    }
}

class program
{
    static void Main()
    {
        book fictionbook = new fictionbook();  
        book sciencebook = new sciencebook();

        fictionbook.getinfo();
        fictionbook.read();

        sciencebook.getinfo();
        sciencebook.read();
    }
}

