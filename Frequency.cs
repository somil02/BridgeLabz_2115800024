using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        char mostFrequentChar = FindMostFrequentCharacter(input);
        Console.WriteLine("The most frequent character is: " + mostFrequentChar);
    } 
    static char FindMostFrequentCharacter(string str)
    {
        int[] frequency = new int[256]; 
        int maxFrequency = 0;
        char mostFrequentChar = '\0';

        for (int i = 0; i < str.Length; i++)
        {
            frequency[str[i]]++;
            if (frequency[str[i]] > maxFrequency)
            {
                maxFrequency = frequency[str[i]];
                mostFrequentChar = str[i];
            }
        }
        return mostFrequentChar;
    }
}
