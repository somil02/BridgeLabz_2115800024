using System;

class Program
{
    static void Main()
    {
        int[] ages = new int[10];

        Console.WriteLine("Enter the ages of 10 students:");

        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < ages.Length; i++)
        {
			if(age<0){
				Console.WriteLine("Invalid age");
			}
			else if (ages[i] >= 18)
            {
                Console.WriteLine("The student with the age " +ages[i]+ " can vote.");
            }
            else
            {
                Console.WriteLine("The student with the age "+ages[i]+ "cannot vote.");
            }
        }
    }
}
