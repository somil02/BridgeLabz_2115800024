using System;

class OddEvenNumbers
{
    static void Main(string[] args)
    {
        // Read an integer input from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a positive natural number
        if (number <= 0)
        {
            Console.WriteLine("Enter a natural number greater than 0.");
            return; // Exit the program if input is not valid
        }

        // Loop through numbers from 1 to the input number
        for (int i = 1; i <= number; i++)
        {
            // Check if the number is even or odd
            if (i % 2 == 0) 
            {
                Console.WriteLine(i + " is an even number.");
            }
            else 
            {
                Console.WriteLine(i + " is an odd number.");
            }
        }
    }
}
