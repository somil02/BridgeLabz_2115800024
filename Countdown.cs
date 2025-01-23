using System;

class Countdown
{
    static void Main(string[] args)
    {
        int count = Convert.ToInt32(Console.ReadLine());

        // Loop to print numbers from count down to 1
        while (count >= 1)
        {
            Console.WriteLine(count); 
            count--; // Decrement the count
        }
    }
}
