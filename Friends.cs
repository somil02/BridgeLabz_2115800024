using System;

class Friends
{
    public static string FindYoungest(int[] ages, string[] names)
    {
        int minAge = ages[0];
        string youngest = names[0];

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                youngest = names[i];
            }
        }
        return youngest;
    }
    public static string FindTallest(int[] heights, string[] names)
    {
        int maxHeight = heights[0];
        string tallest = names[0];

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                tallest = names[i];
            }
        }
        return tallest;
    }

    static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        int[] heights = new int[3];
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write(names[i] +"'s age: ");
			ages[i] = int.Parse(Console.ReadLine());
            Console.Write(names[i]+ "'s height (in cm): ");
			heights[i] = int.Parse(Console.ReadLine());
        }
        string youngest = FindYoungest(ages, names);
        Console.WriteLine("The youngest friend is : " +youngest);
        string tallest = FindTallest(heights, names);
        Console.WriteLine("The tallest friend is: " +tallest);
    }
}
