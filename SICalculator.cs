using System;

class SimpleInterestCalculator
{
    static double CalculateSimpleInterest(double principal, double rate, double time) // Method to calculate Simple Interest
    {
        return (principal * rate * time) / 100;
    }

    static void Main()
    {
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        
        double simpleInterest = CalculateSimpleInterest(principal, rate, time); // Calculate Simple Interest

        
        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + ", and Time " + time + ".");
    }
}
