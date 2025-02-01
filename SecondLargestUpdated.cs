using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        int maxDigit = 10; // Initial maximum size of the array
        int[] digits = new int[maxDigit]; // Array to store digits
        int index = 0; // To track the current index in the array
        while (number != 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10; // Increase the size by 10
                int[] temp = new int[maxDigit]; // Create a temporary array with new size
                for (int i = 0; i < digits.Length; i++)
                {
                    temp[i] = digits[i];
                }

                digits = temp; // Assign the new array back to digits
            }

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
        for (int i = 0; i < index; i++)
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
