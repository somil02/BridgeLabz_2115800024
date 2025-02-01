using System;

class Program
{
    static int RecursiveSum(int n) // Recursive method to calculate sum of n natural numbers
    {
        if (n == 1) return 1;
        return n + RecursiveSum(n - 1);
    }
    static int FormulaSum(int n) // Formula-based method to calculate sum of n natural numbers
    {
        return n * (n + 1) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        bool isValid = int.TryParse(Console.ReadLine(), out int number);
        if (!isValid || number <= 0)
        {
            Console.WriteLine("Please enter a valid natural number greater than zero.");
            return;
        }
        int recursiveResult = RecursiveSum(number); // Compute results using recursion and formula
        int formulaResult = FormulaSum(number);
        Console.WriteLine("Sum using recursion " +recursiveResult);
        Console.WriteLine("Sum using formula " +formulaResult);
        if (recursiveResult == formulaResult)
        {
            Console.WriteLine("Both computations match");
        }
        else
        {
            Console.WriteLine("The results do not match.");
        }
    }
}
