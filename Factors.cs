using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());
        int maxFactor = 10; // Initialize variables for factors
        int[] factors = new int[maxFactor];
        int index = 0;
        for (int i = 1; i <= number; i++)// Find factors and store them in the array
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {  
                    maxFactor *= 2;  // Resize the array if needed
                    int[] temp = new int[maxFactor];
                    for (int j = 0; j < factors.Length; j++)
                    {
                        temp[j] = factors[j];
                    }
                    factors = temp;
                }

                factors[index++] = i;
            }
        }
        Console.WriteLine("Factors of " + number + ":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }

        Console.WriteLine();
    }
}
