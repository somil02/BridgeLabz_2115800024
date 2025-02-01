using System;

class Program
{
    static void Main()
    {
        DateTimeOffset utcTime = DateTimeOffset.UtcNow; // Get the current UTC time
        Console.WriteLine("Current UTC Time: " + utcTime);

        Console.WriteLine("Current GMT Time: " + utcTime);   // Display time in GMT (UTC is equivalent to GMT)

        TimeZoneInfo istTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"); // Display time in IST (Indian Standard Time, UTC +5:30)
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istTimeZone);
        Console.WriteLine("Current IST Time: " + istTime);

        TimeZoneInfo pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");  // Display time in PST (Pacific Standard Time, UTC -8:00)
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstTimeZone);
        Console.WriteLine("Current PST Time: " + pstTime);

        Console.ReadLine();
    }
}
