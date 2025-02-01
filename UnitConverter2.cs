using System;

public static class UnitConverter
{
    public static double Convertyardstofeet(double yards)
    {
        return yards * 3; // Method to convert yards to feet
    }

    public static double Convertfeettoyards(double feet)
    {
        return feet * 0.33; // Method to convert feet to yards
    }

    public static double Convertmetertoinches(double meters)
    {
        return meters * 39.3701; // Method to convert meters to inches
    }

    public static double Convertinchestometer(double inches)
    {
        return inches * 0.0254; // Method to convert inches to meter
    }
	public static double Convertinchestocm(double inches)
    {
        return inches * 2.54; // Method to convert inches to cm
    }
    static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in yards:");
            double yards = double.Parse(Console.ReadLine());
            Console.WriteLine(yards + " yards = " + Convertyardstofeet(yards) + "feet");

            Console.WriteLine("Enter distance in feet:");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine(feet + " feet  = " + Convertfeettoyards(feet) + "yards");

            Console.WriteLine("Enter distance in meters:");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine(meters + " meters = " + Convertmetertoinches(meters) + " inches");

            Console.WriteLine("Enter distance in inches:");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch + " inches = " + Convertinchestometer(inch) + " meters");
			
			Console.WriteLine("Enter distance in inches:");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine(inches + " inches = " + Convertinchestocm(inches) + " centimeters");
        }
}
