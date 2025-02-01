using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the string:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the character to remove:");
        char characterToRemove = Console.ReadLine()[0]; 

        string result = RemoveCharacter(input, characterToRemove);

        Console.WriteLine("String after removal: " + result);
    }
    static string RemoveCharacter(string str, char charToRemove)
    {
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != charToRemove)
            {
                result += str[i];
            }
        }

        return result;
    }
}
