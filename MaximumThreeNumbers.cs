using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int maxNumber = FindMaximum(num1, num2, num3);
        Console.WriteLine("The maximum of the three numbers is: " + maxNumber);
    }

    public static int FindMaximum(int a, int b, int c)
    {
        int max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        return max;
    }
}
