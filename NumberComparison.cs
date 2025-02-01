using System;

class NumberComparison
{
    public static string IsPositive(int number) // Method to check whether the number is positive or negative
    {
        if (number > 0)
        {
            return "positive";
        }
        else if (number < 0)
        {
            return "negative";
        }
        else
        {
            return "zero";
        }
    }
    public static string IsEvenOrOdd(int number) // Method to check whether the number is even or odd
    {
        if (number % 2 == 0)
        {
            return "even";
        }
        else
        {
            return "odd";
        }
    }
    public static int Compare(int number1, int number2)  // Method to compare two numbers
    {
        if (number1 > number2)
        {
            return 1;
        }
        else if (number1 < number2)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }

    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++) // Loop through the array and check each number
        {
            string sign = IsPositive(numbers[i]);
            if (sign == "positive")
            {
                string evenOdd = IsEvenOrOdd(numbers[i]);
                Console.WriteLine("The number "+numbers[i]+ " is positive and "+evenOdd);
            }
            else if (sign == "negative")
            {
                Console.WriteLine("The number "+numbers[i]+" is negative.");
            }
            else
            {
                Console.WriteLine("The number "+numbers[i]+" is zero.");
            }
        }
        int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]); // Compare the first and last elements of the array

        if (comparisonResult == 1)
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else if (comparisonResult == -1)
        {
            Console.WriteLine("The first element is less than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is equal to the last element.");
        }
    }
}
