using System;

class CountDigit{
	static void Main(string[] args){
		int number = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		int n = number;
		//count number of digits
		while(n!=0){
			n = n / 10;
			count++;
		}
		Console.WriteLine("Number of digits is : "+count);
	}
}