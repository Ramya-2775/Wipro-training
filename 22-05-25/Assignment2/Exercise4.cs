using System;
using System.Collections.Generic;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        List<Book> result = new List<Book>();
        foreach (Book book in books)
        {
            if (book.Author.ToLower().Contains(author.ToLower()))
            {
                result.Add(book);
            }
        }
        return result;
    }

    public List<Book> SearchByTitle(string title)
    {
        List<Book> result = new List<Book>();
        foreach (Book book in books)
        {
            if (book.Title.ToLower().Contains(title.ToLower()))
            {
                result.Add(book);
            }
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        Book book1 = new Book();
        book1.Id = 1;
        book1.Title = "C# Basics";
        book1.Author = "John Doe";
        book1.IsAvailable = true;

        Book book2 = new Book();
        book2.Id = 2;
        book2.Title = "Advanced C#";
        book2.Author = "Jane Smith";
        book2.IsAvailable = true;

        library.AddBook(book1);
        library.AddBook(book2);

        Console.WriteLine("Search by Author 'Jane':");
        List<Book> authorResults = library.SearchByAuthor("Jane");
        foreach (Book b in authorResults)
        {
            Console.WriteLine(b.Title);
        }

        Console.WriteLine();

        Console.WriteLine("Search by Title 'Basics':");
        List<Book> titleResults = library.SearchByTitle("Basics");
        foreach (Book b in titleResults)
        {
            Console.WriteLine(b.Title);
        }
    }
}
