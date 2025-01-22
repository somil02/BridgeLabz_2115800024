using System;
class Conversion
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celc = Convert.ToDouble(Console.ReadLine());

        double farh = (celc * 9 / 5) + 32;

        Console.WriteLine("The temperature in Fahrenheit is: " + farh);
    }
}
