using System;

class FrequencyOfDigits
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));  // Take absolute value to avoid issues with negative numbers

        
        int[] frequency = new int[10]; // Define an array to store the frequency of each digit (0-9)

        
        while (num > 0) // Extract digits from the number and calculate frequency
        {
            int digit = num % 10;  // Get the last digit of the number
            frequency[digit]++;    // Increment the frequency of that digit
            num /= 10;             // Remove the last digit from the number
        }
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + " appears " + frequency[i] + " time(s).");
            }
        }
    }
}
