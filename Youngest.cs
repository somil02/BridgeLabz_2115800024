// using System;

// class Program
// {
    // static void Main()
    // {
        // string[] friends = { "Amar", "Akbar", "Anthony" }; // Names of the friends
        // int[] ages = new int[3]; // Array to store the ages
        // double[] heights = new double[3]; // Array to store the heights

        // Console.WriteLine("Enter the age and height");

        // for (int i = 0; i < friends.Length; i++)
        // {
            // while (true)
            // {
                // Console.Write("Enter the age ");
                // if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
                // {
                    // ages[i] = age;
                    // break;
                // }
                // else
                // {
                    // Console.WriteLine("Invalid input. Please enter a positive integer for age.");
                // }
            // }
            // while (true)
            // {
                // Console.Write("Enter the height ");
                // if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                // {
                    // heights[i] = height;
                    // break;
                // }
                // else
                // {
                    // Console.WriteLine("Invalid input. Please enter a positive number for height.");
                // }
            // }
        // }
        // int youngestIndex = 0; // Start with the first friend
        // for (int i = 1; i < ages.Length; i++)
        // {
            // if (ages[i] < ages[youngestIndex])
            // {
                // youngestIndex = i; // Update index of youngest friend
            // }
        // }
        // int tallestIndex = 0; // Start with the first friend
        // for (int i = 1; i < heights.Length; i++)
        // {
            // if (heights[i] > heights[tallestIndex])
            // {
                // tallestIndex = i; // Update index of tallest friend
            // }
        // }
        // Console.WriteLine("\nThe youngest friend is " + friends[youngestIndex] + 
                          // " with age " + ages[youngestIndex] + " years.");
        // Console.WriteLine("The tallest friend is " + friends[tallestIndex] + 
                          // " with height " + heights[tallestIndex] + " cm.");
    // }
// }
