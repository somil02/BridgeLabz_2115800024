using System;

class DuplicateRemoval
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < result.Length; j++) // Check if the character already exists in the result string
            {
                if (input[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)  // Add character to result if it's not a duplicate
            {
                result += input[i];
            }
        }
        Console.WriteLine("String after duplicate removal: " + result);
    }
}
