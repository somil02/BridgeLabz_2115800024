using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string toggledString = ToggleCase(input);
        Console.WriteLine("String after toggling case: " + toggledString);
    }
    static string ToggleCase(string str)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c >= 'A' && c <= 'Z') // If uppercase, convert to lowercase
            {
                result += (char)(c + 32);
            }
            else if (c >= 'a' && c <= 'z') // If lowercase, convert to uppercase
            {
                result += (char)(c - 32);
            }
            else
            {
                result += c; // Keep non-alphabetic characters as they are
            }
        }

        return result;
    }
}
