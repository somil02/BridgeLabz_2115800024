using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number for the Fibonacci sequence: ");
        int n =int.Parse(Console.ReadLine());
        Console.WriteLine("Fibonacci Sequence:");
        GenerateFibonacciSequence(n);
    }
    public static void GenerateFibonacciSequence(int n)
    {
        int first = 0, second = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(first + " ");
            int next = first + second;
            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}
