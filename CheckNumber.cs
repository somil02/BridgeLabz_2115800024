using System;

class CheckNumber
{
    static void Main(string[] args)
    {
        // Read an integer input from the user
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            // If the number is positive
            Console.WriteLine("Positive");
        }
        else if (number < 0)
        {
            // If the number is negative
            Console.WriteLine("Negative");
        }
        else
        {
            // If the number is zero
            Console.WriteLine("Zero");
        }
    }
}
