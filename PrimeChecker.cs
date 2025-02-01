using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to check if it is prime: ");
        int number=int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);
        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
