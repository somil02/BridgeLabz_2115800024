//using System;

//public class Book
//{
//    // Static variable shared across all books
//    public static string LibraryName = "Central Library";

//    // Readonly variable for the ISBN
//    public readonly string ISBN;

//    // Properties for book details
//    public string Title { get; private set; }
//    public string Author { get; private set; }

//    // Static method to display the library name
//    public static void DisplayLibraryName()
//    {
//        Console.WriteLine("Library Name: " + LibraryName);
//    }

//    // Constructor to initialize book details using 'this'
//    public Book(string title, string author, string isbn)
//    {
//        this.Title = title;
//        this.Author = author;
//        this.ISBN = isbn;
//    }

//    // Method to display book details
//    public void DisplayBookDetails()
//    {
//        if (this is Book)
//        {
//            Console.WriteLine("Library Name: " + LibraryName);
//            Console.WriteLine("Title: " + Title);
//            Console.WriteLine("Author: " + Author);
//            Console.WriteLine("ISBN: " + ISBN);
//        }
//        else
//        {
//            Console.WriteLine("This is not a valid Book object.");
//        }
//    }
//}

//class Program
//{
//    public static void Main(string[] args) // Fixed method name capitalization
//    {
//        // Corrected string types for ISBN values
//        Book book1 = new Book("C# Programming", "John Doe", "123456");
//        Book book2 = new Book("Java Programming", "Jane Doe", "654321");
//        Nice book3 = new Nice("Python Programming", "James Doe", "987654");

//        // Display book details
//        Console.WriteLine("\nBook 1 Details:");
//        book1.DisplayBookDetails();

//        Console.WriteLine("\nBook 2 Details:");
//        book2.DisplayBookDetails();
//    }
//}
