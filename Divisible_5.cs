using System;

class Divisible
{
    static void Main(string[] args)
    {
        // Read an integer input from the user
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is divisible by 5
        if (number % 5 == 0)
        {
            Console.Write("YES, the number is divisible by 5");
        }
        else
        {
            Console.Write("NO, the number is not divisible by 5");
        }
    }
}
