using System;

class Quadratic
{
    public static double[] FindRoots(double a, double b, double c) // Method to find roots of the quadratic equation
    {
        double delta = Math.Pow(b, 2) - (4 * a * c); // Calculate delta

        if (delta > 0) // Two distinct roots
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0) // One repeated root
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else // Delta is negative, no real roots
        {
            return new double[0];
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the coefficients a, b, and c for the quadratic equation ax^2 + bx + c:");

        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("The equation has one root: x = " + roots[0]);
        }
        else
        {
            Console.WriteLine("The equation has two roots: x1 = " + roots[0] + ", x2 = " + roots[1]);
        }
    }
}
