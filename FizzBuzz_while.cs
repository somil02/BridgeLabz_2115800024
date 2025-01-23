using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            int i = 1; // counter start from 1
            //while loop runs till i is not equal to number
            while (i <= number)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++; 
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
