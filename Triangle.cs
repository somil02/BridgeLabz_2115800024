using System;

class AthleteRunCalculator
{
    static double CalculatePerimeter(double side1, double side2, double side3) // Method to calculate the perimeter of the triangle
    {
        return side1 + side2 + side3;
    }
    static int CalculateRounds(double perimeter) // Method to calculate the number of rounds to complete 5 km (5000 meters)
    {
        double totalDistance = 5000; // 5 km in meters
        return (int)(totalDistance / perimeter);
    }

    static void Main()
    {
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());
        double perimeter = CalculatePerimeter(side1, side2, side3);
        int rounds = CalculateRounds(perimeter);  // Calculate the number of rounds required to complete 5 km
        Console.WriteLine("The athlete needs to complete " + rounds + " rounds to run 5 kilometers.");
    }
}
