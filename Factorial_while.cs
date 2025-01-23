using System;

class Factorial
{
    static void Main(string[] args)
    {
        // Read an integer input from the user
        int n = Convert.ToInt32(Console.ReadLine());

        // Initialize the factorial to 1
        long Factorial = 1;
        int i = 1;

        // Calculate the factorial using a while loop
        while (i <= n)
        {
            Factorial *= i; // Multiply Factorial by i at each step
            i++; // Increment the counter
        }
        Console.WriteLine("The factorial of " + n + " is: " + Factorial);
    }
}
