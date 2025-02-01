using System;

class Comparison
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        int comparisonResult = CompareStrings(str1, str2);

        if (comparisonResult < 0)
        {
            Console.WriteLine(str1+ " comes before " +str2+ " lexicographically.");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine(str1+ " comes after " +str2+ " lexicographically.");
        }
        else
        {
            Console.WriteLine(str1+" is equal to  "+str2+ " lexicographically.");
        }
    }
    static int CompareStrings(string str1, string str2)
    {
        int length = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < length; i++)
        {
            if (str1[i] < str2[i])
            {
                return -1;
            }
            else if (str1[i] > str2[i])
            {
                return 1;
            }
        }
        if (str1.Length < str2.Length)
        {
            return -1;
        }
        else if (str1.Length > str2.Length)
        {
            return 1;
        }
        return 0;
    }
}
