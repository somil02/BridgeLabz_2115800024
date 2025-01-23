using System;

class LeapYear
{
    static void Main(string[] args)
    {
        // Read the year input from the user
        int year = Convert.ToInt32(Console.ReadLine());

        // Check if the year is before the Gregorian calendar
        if (year < 1582)
        {
            Console.WriteLine("The Leap Year program only works for years >= 1582.");
        }
        else
        {
            // Check if the year is divisible by 4
            if (year % 4 == 0)
            {
                // Check if the year is divisible by 100
                if (year % 100 == 0)
                {
                    // Check if the year is divisible by 400
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a leap Year");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a leap Year");
                    }
                }
                else
                {
                    Console.WriteLine(year + " is a leap Year");
                }
            }
            else
            {
                Console.WriteLine(year + " is not a leap Year");
            }
        }
    }
}
