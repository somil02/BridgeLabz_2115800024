using System;

public static class UnitConverter
{
    public static double ConvertKmToMiles(double km)
    {
        return km * 0.621371; // Method to convert kilometers to miles
    }

    public static double ConvertMilesToKm(double miles)
    {
        return miles * 1.60934; // Method to convert miles to kilometers
    }

    public static double ConvertMetersToFeet(double meters)
    {
        return meters * 3.28084; // Method to convert meters to feet
    }

    public static double ConvertFeetToMeters(double feet)
    {
        return feet * 0.3048; // Method to convert feet to meters
    }
    static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in kilometers:");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine(km + " km = " + ConvertKmToMiles(km) + " miles");

            Console.WriteLine("Enter distance in miles:");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine(miles + " miles = " + ConvertMilesToKm(miles) + " km");

            Console.WriteLine("Enter distance in meters:");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine(meters + " meters = " + ConvertMetersToFeet(meters) + " feet");

            Console.WriteLine("Enter distance in feet:");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine(feet + " feet = " + ConvertFeetToMeters(feet) + " meters");
        }
}
