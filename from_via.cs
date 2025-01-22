using System;

class TravelComputation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the name of the person traveling:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the starting city (fromCity):");
        string fromCity = Console.ReadLine();

        Console.WriteLine("Enter the city via which the person travels (viaCity):");
        string viaCity = Console.ReadLine();

        Console.WriteLine("Enter the final destination city (toCity):");
        string toCity = Console.ReadLine();

        Console.WriteLine("Enter the distance from " + fromCity + " to " +viaCity);
        double fromToViaKm = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the distance " + viaCity + " to " +toCity);
        double viaToFinalCityKm = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the timetaken from " + fromCity + " to " +viaCity);
        int timeFromToVia = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the timetaken " + viaCity + " to " +toCity);
        int timeViaToFinalCity = int.Parse(Console.ReadLine());

        double totalDistanceKm = fromToViaKm + viaToFinalCityKm;

        int totalTimeMinutes = timeFromToVia + timeViaToFinalCity;

        Console.WriteLine("The results of the trip are:");
        Console.WriteLine("Name " +name);
        Console.WriteLine("Total Distance traveled from " +fromCity+ " to " +toCity+ " via " +viaCity+ " " +totalDistanceKm+ "km");
        Console.WriteLine("Total Time taken " +totalTimeMinutes+ "minutes");
    }
}
