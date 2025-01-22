using System;

class TotalIncome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the salary (INR):");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the bonus (INR):");
        double bonus = double.Parse(Console.ReadLine());

        double totalIncome = salary + bonus;

        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }
}
