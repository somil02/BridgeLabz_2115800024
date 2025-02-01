using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the sentence:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Enter the word to replace:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter the new word:");
        string newWord = Console.ReadLine();

        string result = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Modified sentence: " + result);
    }
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        char[] sentenceArray = sentence.ToCharArray();
        char[] resultArray = new char[sentence.Length * 2];  // Allocate extra space for longer words
        int resultIndex = 0;
        int oldWordLength = oldWord.Length;
        for (int i = 0; i < sentenceArray.Length;)
        {
            bool isMatch = true;
            for (int j = 0; j < oldWordLength; j++)
            {
                if (i + j >= sentenceArray.Length || sentenceArray[i + j] != oldWord[j])
                {
                    isMatch = false;
                    break;
                }
            }
            if (isMatch)
            {
                foreach (char c in newWord)
                {
                    resultArray[resultIndex++] = c;
                }
                i += oldWordLength; // Move past the replaced word
            }
            else
            {
                resultArray[resultIndex++] = sentenceArray[i++]; // Copy current character to result
            }
        }
        return new string(resultArray, 0, resultIndex);
    }
}
