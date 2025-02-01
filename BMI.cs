using System;

class BMICalculator
{
    const int TeamSize = 10;
    public static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < TeamSize; i++)
        {
            double weight = data[i, 0];
            double heightInCm = data[i, 1];
            double heightInMeters = heightInCm / 100;
            double bmi = weight / (heightInMeters * heightInMeters); // BMI calculation: weight (kg) / (height (m) * height (m))
            data[i, 2] = Math.Round(bmi, 2); // Store the BMI in the third column
        }
    }
    public static string GetBMIStatus(double bmi) // Method to determine BMI status
    {
        if (bmi < 18.5)
        {
            return "Underweight";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            return "Normal weight";
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            return "Overweight";
        }
        else
        {
            return "Obesity";
        }
    }

    static void Main(string[] args)
    {
        double[,] data = new double[TeamSize, 3]; // 2D array for weight, height, and BMI
        Console.WriteLine("Enter the weight (in kg) and height (in cm) for " + TeamSize + " team members:");

        for (int i = 0; i < TeamSize; i++)
        {
            Console.Write("Person " + (i + 1) + " - Weight (kg): ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.Write("Person " + (i + 1) + " - Height (cm): ");
            data[i, 1] = double.Parse(Console.ReadLine());
        }

        CalculateBMI(data);
        Console.WriteLine("\nTeam BMI Report:");
        Console.WriteLine("Person\tWeight(kg)\tHeight(cm)\tBMI\t\tStatus");
        for (int i = 0; i < TeamSize; i++)
        {
            double weight = data[i, 0];
            double height = data[i, 1];
            double bmi = data[i, 2];
            string status = GetBMIStatus(bmi);

            Console.WriteLine((i + 1) + "\t" + weight + "\t\t" + height + "\t\t" + bmi + "\t\t" + status);
        }
    }
}
