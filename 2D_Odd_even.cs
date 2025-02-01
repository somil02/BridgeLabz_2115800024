using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, columns]; // Create a 2D array (matrix)

        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i}, {j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int[] array = new int[rows * columns]; // Create a 1D array to copy the elements
        int index = 0;
        for (int i = 0; i < rows; i++) // Copy elements from the 2D array to the 1D array
        {
            for (int j = 0; j < columns; j++)
            {
                array[index++] = matrix[i, j];
            }
        }
        Console.WriteLine("The 1D array is:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}
