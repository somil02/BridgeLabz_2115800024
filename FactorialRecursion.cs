using System;

class Program
{
    static void Main()
    {
		Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());;

        long factorial = CalculateFactorial(number);

        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }

    public static long CalculateFactorial(int num)
    {
        if (num == 0 || num == 1)  // Base case
            return 1;
        return num * CalculateFactorial(num - 1);  // Recursive case
    }
}
