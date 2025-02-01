using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);

        Console.WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }

    public static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }

    public static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}
