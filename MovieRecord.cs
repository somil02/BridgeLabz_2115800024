using System;

public class Movie
{
    public string title;
    public string director;
    public int rating;
    public int year;
    public Movie next;
    public Movie prev;
    public Movie()
    {
        this.title = "";
        this.director = "";
        this.rating = 0;
        this.year = 0;
        this.next = null;
        this.prev = null;
    }
    public Movie(string title, string director, int rating, int year)
    {
        this.title = title;
        this.director = director;
        this.rating = rating;
        this.year = year;
        this.next = null;
        this.prev = null;
    }
}
public class MovieList
{
    public Movie head;
    public Movie tail;
    public void AddMovieAtBeginning(Movie newMovie)
    {
        if (head == null)
        {
            head = newMovie;
            tail = newMovie;
        }
        else
        {
            newMovie.next = head;
            head = newMovie;
        }
        Console.WriteLine($"Movie '{newMovie.title}' added at the beginning successfully");
    }
    public void AddMovieAtEnd(Movie newMovie)
    {
        if (head == null)
        {
            head = newMovie;
            tail = newMovie;
        }
        else
        {
            tail.next = newMovie;
            tail = newMovie;
        }
        Console.WriteLine($"Movie '{newMovie.title}' added at the end successfully");
    }
    public void AddMovieAtPosition(Movie newMovie, int position)
    {
        if (position == 0)
        {
            AddMovieAtBeginning(newMovie);
        }
        else
        {
            Movie temp = head;
            for (int i = 0; i < position - 1; i++)
            {
                if (temp == null)
                {
                    Console.WriteLine("Invalid position");
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            newMovie.next = temp.next;
            temp.next = newMovie;
        }
        Console.WriteLine($"Movie '{newMovie.title}' added at position {position} successfully");

    }
    public void DeleteMovieByTitle(string title)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }
        else if (head.title == title)
        {
            head = head.next;
            Console.WriteLine($"Movie '{title}' deleted successfully");
            return;
        }
        else
        {
            Movie temp = head;
            while (temp.next != null && temp.next.title != title)
            {
                temp = temp.next;
            }
            if (temp.next == null)
            {
                Console.WriteLine($"Movie '{title}' not found");
            }
            else
            {
                temp.next = temp.next.next;
                Console.WriteLine($"Movie '{title}' deleted successfully");
            }
        }
    }
    public void SearchMovieByDirector(string director)
    {
        Movie temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.director == director)
            {
                Console.WriteLine($"Title: {temp.title}, Rating: {temp.rating}, Year: {temp.year}");
                found = true;
            }
            temp = temp.next;
        }
        if (!found)
        {
            Console.WriteLine($"No movies found for director '{director}'");
        }
    }
    public void SearchMovieByRating(int rating)
    {
        Movie temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.rating == rating)
            {
                Console.WriteLine($"Title: {temp.title}, Director: {temp.director}, Year: {temp.year}");
                found = true;
            }
            temp = temp.next;
        }
        if (!found)
        {
            Console.WriteLine($"No movies found with rating {rating}");
        }
    }
    public void DisplayForward()
    {
        Console.WriteLine("\nMovies in Forward Order:");
        Movie temp = head;
        if (temp == null)
        {
            Console.WriteLine("No movies to display.");
        }
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.title}, Director: {temp.director}, Rating: {temp.rating}, Year: {temp.year}");
            temp = temp.next;
        }
    }
    public void DisplayBackward()
    {
        Console.WriteLine("\nMovies in Reverse Order:");
        Movie temp = tail;
        if (temp == null)
        {
            Console.WriteLine("No movies to display.");
        }
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.title}, Director: {temp.director}, Rating: {temp.rating}, Year: {temp.year}");
            temp = temp.prev;
        }
    }
    public void UpdateRatingByTitle(string title, int rating)
    {
        Movie temp = head;
        while (temp != null && temp.title != title)
        {
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine($"Movie '{title}' not found");
        }
        else
        {
            temp.rating = rating;
            Console.WriteLine($"Rating for '{title}' updated successfully to {rating}");
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        MovieList movieList = new MovieList();
        Movie movie1 = new Movie("The Shawshank Redemption", "Frank Darabont", 9, 1994);
        Movie movie2 = new Movie("The Godfather", "Francis Ford Coppola", 9, 1972);
        Movie movie3 = new Movie("The Dark Knight", "Christopher Nolan", 9, 2008);
        Movie movie4 = new Movie("The Lord of the Rings: The Return of the King", "Peter Jackson", 9, 2003);
        Movie movie5 = new Movie("Pulp Fiction", "Quentin Tarantino", 8, 1994);
        movieList.AddMovieAtEnd(movie1);
        movieList.AddMovieAtEnd(movie2);
        movieList.AddMovieAtEnd(movie3);
        movieList.AddMovieAtEnd(movie4);
        movieList.AddMovieAtEnd(movie5);
        movieList.DisplayForward();
        Console.WriteLine("\nDeleting 'The Dark Knight':");
        movieList.DeleteMovieByTitle("The Dark Knight");
        movieList.DisplayForward();
        Console.WriteLine("\nSearching for movies by director 'Francis Ford Coppola':");
        movieList.SearchMovieByDirector("Francis Ford Coppola");
        Console.WriteLine("\nSearching for movies with rating 9:");
        movieList.SearchMovieByRating(9);
        Console.WriteLine("\nUpdating rating for 'The Godfather':");
        movieList.UpdateRatingByTitle("The Godfather", 10);
        movieList.DisplayForward();
        movieList.DisplayBackward();
    }
}