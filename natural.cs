using System;

class Natural
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            // Calculate the sum of first 'number' natural numbers using the formula
            int sum = (number * (number + 1)) / 2;
            Console.WriteLine("The sum of " + number + " natural numbers is " + sum);
        }
        else
        {
            // Output if the number is not a natural number
            Console.WriteLine("The number " + number + " is not a natural number");
        }
    }
}
