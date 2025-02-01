using System;

class DateArithmetic
{
    static void Main(string[] args)
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime inputDate))
        {
            DateTime updatedDate = inputDate.AddDays(7)   // Add 7 days, 1 month, and 2 years
                                             .AddMonths(1)
                                             .AddYears(2);

            DateTime finalDate = updatedDate.AddDays(-21); // Subtract 3 weeks (21 days)

            Console.WriteLine("Original Date: " + inputDate.ToString("yyyy-MM-dd"));  
            Console.WriteLine("Final Date after operations: " + finalDate.ToString("yyyy-MM-dd")); // Display the final result
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a valid date in yyyy-MM-dd format.");
        }
    }
}
 