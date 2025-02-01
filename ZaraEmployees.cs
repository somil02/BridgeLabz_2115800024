// using System;

// class Program
// {
    // static void Main()
    // {
        // const int numberOfEmployees = 10;
        // double[] salaries = new double[numberOfEmployees]; // Array to store the salaries
        // double[] yearsOfService = new double[numberOfEmployees]; // Array to store the years of service
        // double[] bonuses = new double[numberOfEmployees]; // Array to store the bonus amounts
        // double[] newSalaries = new double[numberOfEmployees]; // Array to store the new salaries

        // double totalBonus = 0; // Variable to store the total bonus
        // double totalOldSalary = 0; // Variable to store the total old salary
        // double totalNewSalary = 0; // Variable to store the total new salary

        // Console.WriteLine("Enter the salary and years of service for 10 employees:");

        // for (int i = 0; i < numberOfEmployees; i++)
        // {
            // while (true)
            // {
                // Console.Write("Enter salary for employee " + (i + 1) + ": ");
                // if (double.TryParse(Console.ReadLine(), out double salary) && salary > 0)
                // {
                    // salaries[i] = salary;
                    // break;
                // }
                // else
                // {
                    // Console.WriteLine("Invalid salary. Please enter a positive number.");
                // }
            // }
            // while (true)
            // {
                // Console.Write("Enter years of service for employee " + (i + 1) + ": ");
                // if (double.TryParse(Console.ReadLine(), out double years) && years >= 0)
                // {
                    // yearsOfService[i] = years;
                    // break;
                // }
                // else
                // {
                    // Console.WriteLine("Invalid years of service. Please enter a non-negative number.");
                // }
            // }
        // }
        // for (int i = 0; i < numberOfEmployees; i++)// Calculating bonus, new salaries, and total payouts
        // {
            // double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02; // 5% for > 5 years, 2% otherwise
            // bonuses[i] = salaries[i] * bonusPercentage; // Calculate bonus
            // newSalaries[i] = salaries[i] + bonuses[i]; // Calculate new salary

            // totalBonus += bonuses[i];
            // totalOldSalary += salaries[i];
            // totalNewSalary += newSalaries[i];
        // }
        // Console.WriteLine("\nEmployee-wise Details:");// Printing results using concatenation
        // for (int i = 0; i < numberOfEmployees; i++)
        // {
            // Console.WriteLine("Employee " + (i + 1) +
                              // ": Old Salary = " + salaries[i].ToString("C") +
                              // ", Bonus = " + bonuses[i].ToString("C") +
                              // ", New Salary = " + newSalaries[i].ToString("C"));
        // }
        // Console.WriteLine("Total Old Salary: " + totalOldSalary.ToString("C"));
        // Console.WriteLine("Total Bonus Payout: " + totalBonus.ToString("C"));
        // Console.WriteLine("Total New Salary: " + totalNewSalary.ToString("C"));
    // }
// }
