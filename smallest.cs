using System;

class Smallest
{
    static void Main(string[] args)
    {
        // Read three integer inputs
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        // Check if the first number is the smallest
        bool isSmallest = (a < b) && (a < c);
        Console.WriteLine("Is the first number the smallest? " + isSmallest);
    }
}
