using System;

class VowelConsonant
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter string: ");
		string input = Console.ReadLine();
		int vow=0;
		int cons=0;
		for(int i=0;i<input.Length;i++)
		{
			char ch = char.ToLower(input[i]);
			if(char.IsLetter(ch))
			{
				if("aeiou".Contains(ch))
				{
					vow++;
				}
				else{
					cons++;
				}
			}
		}
		Console.WriteLine("Number of Vowels : " +vow);
		Console.WriteLine("Number of Consonant : " +cons);
	}
}
