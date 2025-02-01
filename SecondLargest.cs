using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }
        const int maxDigit = 10; // Maximum size of the array to store digits
        int[] digits = new int[maxDigit]; // Array to store digits
        int index = 0; // To track the current index in the array
        while (number != 0 && index < maxDigit)
        {
            digits[index] = number % 10; // Extract the last digit
            number /= 10; // Remove the last digit from the number
            index++;
        }
        if (index == 0)
        {
            Console.WriteLine("No digits to process.");
            return;
        }
        int largest = 0; // To store the largest digit
        int secondLargest = 0; // To store the second-largest digit        
        for (int i = 0; i < index; i++) // Loop through the array to find the largest and second largest digits
        {
            if (digits[i] > largest)
            {
                secondLargest = largest; // Update second largest
                largest = digits[i]; // Update largest
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i]; // Update second largest if it's smaller than largest
            }
        }
        Console.WriteLine("The largest digit is: " + largest);

        if (secondLargest > 0)
        {
            Console.WriteLine("The second largest digit is: " + secondLargest);
        }
        else
        {
            Console.WriteLine("There is no second largest digit.");
        }
    }
}