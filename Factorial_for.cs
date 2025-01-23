using System;

class Factorial
{
    static void Main(string[] args)
    {
        // Read an integer input from the user
        int n = Convert.ToInt32(Console.ReadLine());

        // Initialize the factorial to 1
        long factorial = 1;

        // Loop to calculate the factorial
        for (int i = 1; i <= n; i++)
        {
            factorial *= i; // Multiply factorial by i at each step
        }

        // Output the result
        Console.WriteLine("The factorial of " + n + " is: " + factorial);
    }
}
