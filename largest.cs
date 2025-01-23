using System;

class Largest
{
    static void Main(string[] args)
    {
        // Read three integer inputs
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        // Check if the first number is the largest
        bool isFirstLargest = (a > b) && (a > c);

        // Check if the second number is the largest
        bool isSecondLargest = (b > a) && (b > c);

        // Check if the third number is the largest
        bool isThirdLargest = (c > b) && (c > a);

        // Output results
        Console.WriteLine("Is the first number the largest? " + isFirstLargest);
        Console.WriteLine("Is the second number the largest? " + isSecondLargest);
        Console.WriteLine("Is the third number the largest? " + isThirdLargest);
    }
}
