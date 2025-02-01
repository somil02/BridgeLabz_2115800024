using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());
        int[] evenNumbers = new int[number / 2 + 1];
        int[] oddNumbers = new int[number / 2 + 1];

        int evenIndex = 0, oddIndex = 0;
        for (int i = 1; i <= number; i++) // Populate the arrays
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex++] = i;
            }
            else
            {
                oddNumbers[oddIndex++] = i;
            }
        }
        Console.WriteLine("Odd Numbers: "); // Print odd numbers
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
		Console.WriteLine();
        Console.WriteLine("Even Numbers: "); // Print even numbers
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
