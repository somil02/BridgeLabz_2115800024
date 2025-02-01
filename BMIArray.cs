// using System;

// class Bmi
// {
    // static void Main(string[] args)
    // {
        // Console.WriteLine("Enter a number: "); // take input for the number of employees
        // int n = Convert.ToInt32(Console.ReadLine());

        // if (n < 0) // check if number is greater than 0
        // {
            // Console.WriteLine("You entered an invalid number");
            // Environment.Exit(0);
        // }

        // double[] weight = new double[n]; // declared a weight array of size n
        // double[] height = new double[n]; // declared a height array of size n
        // double[] bmi = new double[n]; // declared a bmi array of size n
        // string[] status = new string[n]; // declared a status array of size n

        // for (int i = 0; i < weight.Length; i++)
        // {
            // Console.WriteLine("Employee " + (i + 1) + ": ");
            // Console.WriteLine("Enter weight (in Kg): "); // take input for weight
            // weight[i] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter height (in m): "); // take input for height
            // height[i] = Convert.ToDouble(Console.ReadLine());

            // if (weight[i] <= 0 || height[i] <= 0) // check if weight and height are valid
            // {
                // Console.WriteLine("You entered an invalid value");
                // Environment.Exit(0);
            // }
        // }

        // for (int i = 0; i < weight.Length; i++)
        // {
            // bmi[i] = weight[i] / (Math.Pow(height[i], 2));  // calculate bmi for each employee

            // if (bmi[i] <= 18.4) status[i] = "Underweight"; // store the status
            // else if (bmi[i] <= 24.9) status[i] = "Normal";
            // else if (bmi[i] <= 39.9) status[i] = "Overweight";
            // else status[i] = "Obese";
        // }

        // Console.WriteLine();

        // for (int i = 0; i < weight.Length; i++) // display result
        // {
            // Console.WriteLine("Employee " + (i + 1) + ": ");
            // Console.WriteLine("Height: " + height[i] + "\tWeight: " + weight[i] + "\tBMI: " + bmi[i].ToString("F2") + "\tStatus: " + status[i]);
        // }
    // }
// }
