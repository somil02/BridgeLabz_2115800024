using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
        int[] table = new int[4];
        
        for (int i = 6; i < 10; i++) // Generate the multiplication table
        {
            table[i - 6] = n * i;
        }
       
        for (int i = 0; i <4; i++)  // Display the multiplication table
        {
            Console.WriteLine(n + " * " + (i + 6) + " = " + table[i]);
        }
    }
}
