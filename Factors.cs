using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));
        int sumOfFactors = CalculateSum(factors);
        Console.WriteLine("Sum of factors: " + sumOfFactors);
        int sumOfSquares = CalculateSumOfSquares(factors);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
        long productOfFactors = CalculateProduct(factors);
        Console.WriteLine("Product of factors: " + productOfFactors);
    }
    static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++) // First loop to count the number of factors
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        int[] factors = new int[count]; // Initialize the array with the count of factors
        int index = 0;
        for (int i = 1; i <= number; i++) // Second loop to store factors in the array
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }
    static int CalculateSum(int[] factors) // Method to calculate the sum of factors
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }
    static int CalculateSumOfSquares(int[] factors) // Method to calculate the sum of squares of factors
    {
        int sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += (int)Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
    static long CalculateProduct(int[] factors) // Method to calculate the product of factors
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }
}
