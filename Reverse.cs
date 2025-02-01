using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int temp = number;
        int digitCount = 0;
        while (temp != 0)
        {
            temp /= 10;
            digitCount++;
        }
        int[] digits = new int[digitCount];  // Create an array to store the digits
        int index = 0;
        while (number != 0)  //Store the digits in the array
        {
            digits[index] = number % 10;
            number /= 10;
            index++;
        }
        Console.Write("Reversed number: "); //Display the digits in reverse order (since they are already in reverse order)
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}
