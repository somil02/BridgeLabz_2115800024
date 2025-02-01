using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        bool isPalindrome = CheckPalindrome(input);

        if(isPalindrome){
			Console.WriteLine(input + " is Palindrome"); 
		}
		else{
			Console.WriteLine(input + " is not Palindrome"); 
		}
    }

    public static bool CheckPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
