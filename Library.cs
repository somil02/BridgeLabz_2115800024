using System;
using System.Collections.Generic;

// Book class
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor to initialize book details
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}

// Library class
class Library
{
    public string Name { get; set; }
    private List<Book> books;

    public Library(string name)
    {
        Name = name;
        books = new List<Book>();
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Added '{book.Title}' by {book.Author} to {Name} Library.");
    }

    // Display books in the library
    public void DisplayBooks()
    {
        Console.WriteLine($"\nBooks in {Name} Library:");
        foreach (var book in books)
        {
            book.DisplayInfo();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create independent Book objects
        Book book1 = new Book("1984", "George Orwell");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");

        // Create Library objects
        Library cityLibrary = new Library("City Library");
        Library universityLibrary = new Library("University Library");

        // Add books to libraries (aggregation)
        cityLibrary.AddBook(book1);
        cityLibrary.AddBook(book2);

        universityLibrary.AddBook(book2); // Same book can be added to a different library
        universityLibrary.AddBook(book3);

        // Display books in libraries
        cityLibrary.DisplayBooks();
        universityLibrary.DisplayBooks();
    }
}
