using System;

class Countdown
{
    static void Main(string[] args)
    {
        int count = Convert.ToInt32(Console.ReadLine());

        // Loop to print numbers from count down to 1
        for (int i = count; i >= 1; i--)
        {
            Console.WriteLine(i); // Print the current number
        }
    }
}
