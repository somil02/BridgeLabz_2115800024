using System;

class Program
{
	static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nthPrime = GetNthPrime(n);
        Console.WriteLine(nthPrime);
    }
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    static int GetNthPrime(int n)
    {
        static int count = 0;
        int num = 2;
        while (true)
        {
            if (IsPrime(num))
            {
                count++;
                if (count == n)
                    return num;
            }
            num++;
        }
    }
}
