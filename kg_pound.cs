using System;

class WeightConversion
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the weight in pounds:");
        double weightInPounds = double.Parse(Console.ReadLine());

        double weightInKg = weightInPounds * 2.2;

        Console.WriteLine("The weight of the person in pounds is " + weightInPounds + " and in kg is " +weightInKg);
    }
}
