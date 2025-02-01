using System;

class Longestword
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        string longestWord = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)  // Compare length, not a string directly
            {
                longestWord = words[i];
            }
        }
        Console.WriteLine("The longest word is: " + longestWord);
    }
}
