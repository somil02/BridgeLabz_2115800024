using System;
class Conversion
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double farh = Convert.ToDouble(Console.ReadLine());

        double celc =  ((farh-32) * 5 ) / 9;

        Console.WriteLine("The " + farh + " Fahrenheit is " + celc + " Celsius" );
    }
}
