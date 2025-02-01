// using System;

// class Grades
// {
    // static void Main(string[] args)
    // {
        // Console.WriteLine("Enter the number of students: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        
        // if (n < 0) // Check if the number of students is greater than 0
        // {
            // Console.WriteLine("You entered an invalid number");
            // Environment.Exit(0);
        // }
        // double[,] marks = new double[n, 3]; // n students, 3 subjects
        // double[] percentage = new double[n]; // Array to store percentages for each student
        // string[] grade = new string[n]; // Array to store grades for each student
        // for (int i = 0; i < n; i++)
        // {
            // Console.WriteLine("Student " + (i + 1) + ": ");
            // Console.Write("\nEnter Maths Marks: ");
            // marks[i, 0] = double.Parse(Console.ReadLine());
            // Console.Write("\nEnter Physics Marks: ");
            // marks[i, 1] = double.Parse(Console.ReadLine());
            // Console.Write("\nEnter Chemistry Marks: ");
            // marks[i, 2] = double.Parse(Console.ReadLine());
            // if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0 || marks[i, 0] > 100 || marks[i, 1] > 100 || marks[i, 2] > 100)
            // {
                // Console.WriteLine("You entered an invalid value, please re-enter valid marks");
                // i--; // Decrease index to re-enter the details for the current student
                // continue; // Skip this iteration and go back to the next loop
            // }
        // }
        // for (int i = 0; i < n; i++)
        // {
            // double sum = marks[i, 0] + marks[i, 1] + marks[i, 2];
            // percentage[i] = (sum / 300) * 100; // Calculate percentage
            // if (percentage[i] >= 80)
            // {
                // grade[i] = "A";
            // }
            // else if (percentage[i] >= 70)
            // {
                // grade[i] = "B";
            // }
            // else if (percentage[i] >= 60)
            // {
                // grade[i] = "C";
            // }
            // else if (percentage[i] >= 50)
            // {
                // grade[i] = "D";
            // }
            // else if (percentage[i] >= 40)
            // {
                // grade[i] = "E";
            // }
            // else
            // {
                // grade[i] = "R";
            // }
        // }
        // Console.WriteLine();
        // for (int i = 0; i < n; i++)
        // {
            // Console.WriteLine("Student " + (i + 1) + ": ");
            // Console.WriteLine("Maths: " + marks[i, 0] + "\tPhysics: " + marks[i, 1] + "\tChemistry: " + marks[i, 2] + "\tPercentage: " + percentage[i].ToString("F2") + "\tGrade: " + grade[i]);
        // }
    // }
// }
