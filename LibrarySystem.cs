using System;

class Book
{
	public string ISBN;
	protected string title;
	private string author;
	public string GetAuthor()
    {
        return author;
    }
	public void SetAuthor(string author)
    {
        this.author = author;
    }
	public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        SetAuthor(author);
    }
	public void DisplayBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + GetAuthor());
    }
}
class EBook:Book
{
	public int price;
	public EBook(string ISBN, string title, string author,int price)
        : base(ISBN, title, author)
    {
		this.price =price;
    }

	  public void DisplayEBookDetails()
    {
        Console.WriteLine();
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);  
		Console.WriteLine("Price: "+price);
        Console.WriteLine("Author: " + GetAuthor());  // GetAuthor() is public, so it can be accessed here
    }
}
class program
{
	static void Main(string[] args)
	{
		Book book1 = new Book("978-3-16-148410-0", "C# Programming", "John Doe");
        book1.DisplayBookDetails(); 

        EBook eBook1 = new EBook("978-1-23-456789-0", "Learn C# in 24 Hours", "Jane Smith",500);
        eBook1.DisplayEBookDetails();  
	}
}