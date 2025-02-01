using System;

class Anagram{
	static void Main(string[] args){
		Console.WriteLine("Enter string 1: ");
		string str1 = Console.ReadLine();
		Console.WriteLine("Enter string 2: ");
		string str2 = Console.ReadLine();
		bool isAnagram = CheckAnagram(str1,str2);
		if(isAnagram){
			Console.WriteLine(" Both strings are anagram ");
		}
		else{
			Console.WriteLine(" Strings are not anagram ");
		}
	}
	static bool CheckAnagram(string str1,string str2){
		 if (str1.Length != str2.Length)
        {
            return false;
        }

		int[] freq = new int[256];
		for(int i=0;i<str1.Length;i++){
			freq[str1[i]]++;
		}
		for(int i=0;i<str2.Length;i++){
			freq[str2[i]]--;
		}
		for(int i=0;i<freq.Length;i++){
			if(freq[i]!=0){
				return false;
			}
		}
		return true;
	}
}