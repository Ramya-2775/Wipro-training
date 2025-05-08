using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        Stack<string> books = new Stack<string>();

        // pushing elements to the stack
        books.Push("c# programming");
        books.Push("Data structures");
        books.Push("Machine learning");



        Console.WriteLine("Books in the stack");
        foreach (var book in books)
        {

            Console.WriteLine(book);
        }
        //POPPING AN ELEMENT
        Console.WriteLine("\n popped:" + books.Pop());

        //peeping an element
        Console.WriteLine("\n next on the stack:" + books.Peek());
 

    }


