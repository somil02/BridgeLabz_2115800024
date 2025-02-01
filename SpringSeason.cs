using System;

class SpringSeason
{
    public bool Season(int month, int day) // Method to check if the given date falls in the spring season
    {
        if ((month == 3 && day >= 20) ||   
            (month > 3 && month < 6) ||   
            (month == 6 && day <= 20))    
        {
            return true; // It's spring season
        }
        else
        {
            return false; // Not spring season
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the month (1-12):");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the day (1-31):");
        int day = Convert.ToInt32(Console.ReadLine());
        SpringSeason check = new SpringSeason();
        bool result = check.Season(month, day);
        if (result)
            Console.WriteLine("It's a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }
}
