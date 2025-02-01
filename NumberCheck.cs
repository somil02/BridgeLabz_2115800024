using System;

class NumberCheck
{
    static int CheckNumber(int number) // Method to check if the number is positive, negative, or zero
    {
        if (number > 0)
        {
            return 1;  // Positive number
        }
        else if (number < 0)
        {
            return -1; // Negative number
        }
        else
        {
            return 0;  // Zero
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = CheckNumber(number);   // Call the method to check the number and store the result
        if (result == 1) // Output the result based on the method's return value
        {
            Console.WriteLine("The number is positive.");
        }
        else if (result == -1)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
