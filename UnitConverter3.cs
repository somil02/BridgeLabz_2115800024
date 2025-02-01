using System;

public static class UnitConverter
{
    public static double farhenheit2celsius(double farhenheit)
    {
        return (farhenheit - 32) * 5 / 9; 
    }

    public static double celsius2farhenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32; 
    }

    public static double pounds2kilograms(double pounds)
    {
        return pounds *  0.453592;
    }

    public static double kilograms2pounds(double kilograms)
    {
        return kilograms * 2.20462; 
    }
	public static double gallons2liters(double gallons)
    {
        return gallons *  3.78541; 
    }
	public static double liters2gallons(double liters)
    {
        return liters *  0.264172; 
    }
    static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine(fahrenheit + "°F = " + farhenheit2celsius(fahrenheit) + "°C");

            Console.WriteLine("Enter temperature in Celsius:");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine(celsius + "°C = " + celsius2farhenheit(celsius) + "°F");

            Console.WriteLine("Enter weight in pounds:");
            double pounds = double.Parse(Console.ReadLine());
            Console.WriteLine(pounds + " pounds = " + pounds2kilograms(pounds) + " kilograms");

            Console.WriteLine("Enter weight in kilograms:");
            double kilograms = double.Parse(Console.ReadLine());
            Console.WriteLine(kilograms + " kilograms = " + kilograms2pounds(kilograms) + " pounds");

            Console.WriteLine("Enter volume in gallons:");
            double gallons = double.Parse(Console.ReadLine());
            Console.WriteLine(gallons + " gallons = " + gallons2liters(gallons) + " liters");

            Console.WriteLine("Enter volume in liters:");
            double liters = double.Parse(Console.ReadLine());
            Console.WriteLine(liters + " liters = " + liters2gallons(liters) + " gallons");
        }
}
