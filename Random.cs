using System;
using System.Linq;

class RandomValuesStatistics
{
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000); // Generates a 4-digit number
        }

        return numbers;
    }
    public static double[] FindAverageMinMax(int[] numbers) // Find average, min, and max value of an array
    {
        double average = numbers.Average();
        int minValue = numbers.Min();
        int maxValue = numbers.Max();

        return new double[] { average, minValue, maxValue };
    }

    static void Main(string[] args)
    {
        int size = 5;
        int[] randomNumbers = Generate4DigitRandomArray(size);
        Console.WriteLine("Generated 4-digit random numbers:"); // Display the generated random numbers
        foreach (int number in randomNumbers)
        {
            Console.WriteLine(number);
        }
        double[] results = FindAverageMinMax(randomNumbers); // Calculate average, min, and max values
        Console.WriteLine("\nStatistics:");
        Console.WriteLine("Average: " + results[0]);
        Console.WriteLine("Minimum: " + results[1]);
        Console.WriteLine("Maximum: " + results[2]);
    }
}
