using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) //check divisiblity of both 3 and 5
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) //check divisiblity of 3 
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0) //check divisiblity of 5
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
