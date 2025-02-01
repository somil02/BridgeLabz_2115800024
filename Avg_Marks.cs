// using System;

// class Grades
// {
    // static void Main(string[] args)
    // {
        // Console.WriteLine("Enter a number: "); // Take input for the number of students
        // int n = Convert.ToInt32(Console.ReadLine());
        
        // if (n < 0) // Check if the number of students is greater than 0
        // {
            // Console.WriteLine("You entered an invalid number");
            // Environment.Exit(0);
        // }
        
        // double[] maths = new double[n]; // Declared a maths array of size n
        // double[] phy = new double[n];   // Declared a physics array of size n
        // double[] chem = new double[n];  // Declared a chemistry array of size n
        // double[] percentage = new double[n]; // Declared a percentage array of size n
        // string[] grade = new string[n]; // Declared a grade array of size n
        
        // for (int i = 0; i < n; i++)
        // {
            // Console.WriteLine("Student " + (i + 1) + ": "); // Take input for marks from the user
            // Console.Write("\nEnter Maths Marks: ");
            // double m = double.Parse(Console.ReadLine());
            // Console.Write("\nEnter Physics Marks: ");
            // double p = double.Parse(Console.ReadLine());
            // Console.Write("\nEnter Chemistry Marks: ");
            // double c = double.Parse(Console.ReadLine());
            
            // if (m < 0 || p < 0 || c < 0 || m > 100 || p > 100 || c > 100) // Invalid value check
            // {
                // Console.WriteLine("You entered an invalid value, please re-enter valid marks");
                // i--; // Decrease index to re-enter the details for the current student
                // continue; // Skip this iteration and go back to the next loop
            // }
            
            // maths[i] = m;
            // chem[i] = c;
            // phy[i] = p;
        // }
        
        // Console.WriteLine();
        
        // for (int i = 0; i < n; i++)
        // {
            // double sum = maths[i] + phy[i] + chem[i];
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
        
        // for (int i = 0; i < maths.Length; i++) // Display results
        // {
            // Console.WriteLine("Student " + (i + 1) + ": ");
            // Console.WriteLine("Maths: " + maths[i] + "\tPhysics: " + phy[i] + "\tChemistry: " + chem[i] + "\tPercentage: " + percentage[i].ToString("F2") + "\tGrade: " + grade[i]);
        // }
    // }
// }
