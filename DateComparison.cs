using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first date (yyyy-MM-dd): ");  // Prompt user to enter the first date
        string firstDateInput = Console.ReadLine();

        Console.Write("Enter the second date (yyyy-MM-dd): "); // Prompt user to enter the second date
        string secondDateInput = Console.ReadLine();

        if (DateTime.TryParse(firstDateInput, out DateTime firstDate) &&
            DateTime.TryParse(secondDateInput, out DateTime secondDate))
        {
            int comparisonResult = DateTime.Compare(firstDate, secondDate);  // Compare dates using DateTime.Compare()

            if (comparisonResult < 0)
            {
                Console.WriteLine($"The first date ({firstDate:yyyy-MM-dd}) is before the second date ({secondDate:yyyy-MM-dd}).");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine($"The first date ({firstDate:yyyy-MM-dd}) is after the second date ({secondDate:yyyy-MM-dd}).");
            }
            else
            {
                Console.WriteLine($"The first date ({firstDate:yyyy-MM-dd}) is the same as the second date ({secondDate:yyyy-MM-dd}).");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use the yyyy-MM-dd format.");
        }
    }
}
