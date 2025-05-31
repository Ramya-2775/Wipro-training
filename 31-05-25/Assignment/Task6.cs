using System;
using System.Collections.Generic;

class Book
{
    public int Id;
    public string Title;
    public bool IsBorrowed = false;
    public Student BorrowedBy = null;
    public DateTime? DueDate = null;

    public Book(int id, string title)
    {
        Id = id;
        Title = title;
    }
}

class Student
{
    public int Id;
    public string Name;

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Library
{
    public List<Book> Books = new List<Book>();
    public List<Student> Students = new List<Student>();

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added.");
    }

    public void DeleteBook(int bookId)
    {
        Book book = Books.Find(b => b.Id == bookId);
        if (book != null)
        {
            Books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' deleted.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"Student '{student.Name}' added.");
    }

    public void BorrowBook(int bookId, int studentId)
    {
        Book book = Books.Find(b => b.Id == bookId);
        Student student = Students.Find(s => s.Id == studentId);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }
        if (book.IsBorrowed)
        {
            Console.WriteLine($"Sorry, '{book.Title}' is already borrowed.");
            return;
        }

        book.IsBorrowed = true;
        book.BorrowedBy = student;
        book.DueDate = DateTime.Now.AddDays(14); 

        Console.WriteLine($"'{book.Title}' borrowed by {student.Name}. Due on {book.DueDate.Value.ToShortDateString()}.");
    }

    public void ShowBooks()
    {
        Console.WriteLine("\nBooks in Library:");
        foreach (var b in Books)
        {
            string status = b.IsBorrowed ? $"Borrowed by {b.BorrowedBy.Name}, Due: {b.DueDate?.ToShortDateString()}" : "Available";
            Console.WriteLine($"ID: {b.Id}, Title: {b.Title}, Status: {status}");
        }
    }
}

/*class Program
{
    static void Main()
    {
        Library lib = new Library();

        lib.AddStudent(new Student(1, "Ramya"));
        lib.AddStudent(new Student(2, "Sowmya"));

        
        lib.AddBook(new Book(101, "C# Basics"));
        lib.AddBook(new Book(102, "Learn LINQ"));
        lib.AddBook(new Book(103, "Data Structures"));

        lib.ShowBooks();


        lib.BorrowBook(102, 1);  

        lib.ShowBooks();

        lib.BorrowBook(102, 2);  

        
        lib.DeleteBook(103);

        lib.ShowBooks();
    }
}*/