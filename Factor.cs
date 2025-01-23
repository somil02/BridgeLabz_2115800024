using System;

class Factors
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Factors of " + number + " are:");
        // Iterate from 1 to the number to find its factors
        for (int i = 1; i <= number; i++) 
        {
            if (number % i == 0) 
            {
                Console.WriteLine(i); 
            }
        }
    }
}
