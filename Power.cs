using System;

class Power
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());
        
        int result = 1;

        // Calculate the power using a loop
        for (int i = 1; i <= power; i++) 
        {
            result *= number; 
        }

        Console.WriteLine(result);
    }
}
