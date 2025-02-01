using System;

class Palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        bool isPalindrome = CheckPalindrome(input);
        Console.WriteLine(isPalindrome ? "The string is a palindrome." : "The string is not a palindrome.");
    }
    static bool CheckPalindrome(string input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false; // Return false if characters don't match
            }
            left++;
            right--;
        }
        return true; // Return true if all characters match
    }
}
