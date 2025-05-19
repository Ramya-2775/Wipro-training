using System;

class Book
{
    public string Title;
    public string Author;

    public override string ToString()
    {
        return $"{Title} by {Author}";
    }
}

class Program
{
    static void Main()
    {
        //queue for borrowed books
        Queue<Book> borrowedBooks = new Queue<Book>();

        //5 borrowed books
        borrowedBooks.Enqueue(new Book { Title = "ABC", Author = "Ramya" });
        borrowedBooks.Enqueue(new Book { Title = "HII", Author = "Ane Ramya" });
        borrowedBooks.Enqueue(new Book { Title = "GOODBYE", Author = "Vara" });
        borrowedBooks.Enqueue(new Book { Title = "SEE YOU", Author = "Reddy" });
        borrowedBooks.Enqueue(new Book { Title = "HELLO", Author = "Sowmya" });

        //next book(peek)
        Console.WriteLine("Next book to return:");
        Console.WriteLine(borrowedBooks.Peek());

        // Remove the returned book
        borrowedBooks.Dequeue();

        //stack for newly purchased books
        Stack<Book> newBooks = new Stack<Book>();

        //Add 3 new books to the stack
        newBooks.Push(new Book { Title = "Silence", Author = "Charlee" });
        newBooks.Push(new Book { Title = "violence", Author = "Darla" });
        newBooks.Push(new Book { Title = "Drama", Author = "Mantri" });

        //last purchased book (peek)
        Console.WriteLine("\nLast book purchased:");
        Console.WriteLine(newBooks.Peek());

        // Remove the top book(pop)
        newBooks.Pop();

        //remaining books
        Console.WriteLine("\nRemaining Borrowed Books:");
        foreach (var book in borrowedBooks)
        {
            Console.WriteLine(book);
        }

        //remaining books in the new stack
        Console.WriteLine("\nRemaining New Books:");
        foreach (var book in newBooks)
        {
            Console.WriteLine(book);
        }
    }
}
