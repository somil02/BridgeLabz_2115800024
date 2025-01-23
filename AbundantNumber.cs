using System;

class AbundantNumber
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
         // Calculate the sum of divisors of the number (excluding the number itself)
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        if (sum > number) // Check if the sum of divisors is greater than the number
        {
            Console.WriteLine("Abundant Number");
        }
        else
        {
            Console.WriteLine("Not an Abundant Number");
        }
    }
}
