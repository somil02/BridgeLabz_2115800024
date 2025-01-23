using System;

class Multiples
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiples of " + number + " below 100 are:");
         // Loop to find multiples of the number below 100
        for (int i = 100; i >= 1; i--)
        {
            if (number % i == 0) // Check if 'i' is a multiple of 'number'
            {
                Console.WriteLine(i); 
            }
        }
    }
}
