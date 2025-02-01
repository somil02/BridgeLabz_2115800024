using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
        int[] table = new int[10];
        
        for (int i = 1; i <= 10; i++) // Generate the multiplication table
        {
            table[i - 1] = n * i;
        }
       
        for (int i = 0; i < 10; i++)  // Display the multiplication table
        {
            Console.WriteLine(n + " * " + (i + 1) + " = " + table[i]);
        }
    }
}
