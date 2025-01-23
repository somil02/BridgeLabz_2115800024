using System;

class Salary
{
    static void Main(string[] args)
    {
        // Read the salary and years of service from the user
        double salary = Convert.ToDouble(Console.ReadLine());
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        // Check if the years of service are greater than 5
        if (yearsOfService > 5)
        {
            // Calculate the bonus (5% of salary)
            double bonus = salary * 0.05;
            Console.WriteLine("The bonus amount is: " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus");
        }
    }
}
