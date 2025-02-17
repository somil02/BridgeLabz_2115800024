using System;
using System.Diagnostics;
using System.Collections.Generic;

class FibonacciComparison
{
    // Recursive Fibonacci with Memoization (O(N))
    static Dictionary<long, long> memo = new Dictionary<long, long>();
    static long RecursiveFibonacci(long n)
    {
        if (n <= 1)
            return n;
        if (memo.ContainsKey(n))
            return memo[n];

        long result = RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        memo[n] = result; // Store result in dictionary
        return result;
    }

    // Iterative Fibonacci (O(N))
    static long IterativeFibonacci(long n)
    {
        if (n <= 1)
            return n;

        long a = 0, b = 1, c = 0;
        for (long i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }

    static void Main(string[] args)
    {
        long[] testValues = { 10, 30, 50 }; // Example values

        Console.WriteLine("Recursive Fibonacci (with Memoization):");
        Stopwatch stopwatch = new Stopwatch();

        foreach (long n in testValues)
        {
            memo.Clear(); // Reset memoization for each test
            stopwatch.Restart();
            long result = RecursiveFibonacci(n);
            stopwatch.Stop();
            Console.WriteLine($"Fib({n}) = {result}");
            Console.WriteLine($"Recursive Fibonacci Time: {stopwatch.ElapsedMilliseconds} ms\n");
        }

        Console.WriteLine("Iterative Fibonacci:");
        foreach (long n in testValues)
        {
            stopwatch.Restart();
            long result = IterativeFibonacci(n);
            stopwatch.Stop();
            Console.WriteLine($"Fib({n}) = {result}");
            Console.WriteLine($"Iterative Fibonacci Time: {stopwatch.ElapsedMilliseconds} ms\n");
        }
    }
}
