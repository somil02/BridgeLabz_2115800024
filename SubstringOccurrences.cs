using System;

class OccuranceSubstring{
	static void Main(string[] args){
		string input = Console.ReadLine();
		Console.Write("Enter Substring: ");
		string sub =Console.ReadLine();
		int count = CountSubstringOccurance(input,sub);
		Console.WriteLine(count);
	}
	static int CountSubstringOccurance(string input,string sub){
		int count=0;
		int sublength = sub.Length;
		for(int i=0;i<input.Length - sub.Length;i++){
			int j;
			for(j=0;j<sublength;j++){
				if(input[i+j] != sub[j]){
					break;
				}
			}
			if(j==sublength){
				count++;
			}
		}
		return count;
	}
}