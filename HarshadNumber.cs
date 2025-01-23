using System;

class HarshadNumber{
	static void Main(string[] args){
		int number = Convert.ToInt32(Console.ReadLine());
		int temp = number;
		double sum =0;
		//calculate sum of all digits in number
		while(temp!=0){
			int num = temp%10;
			sum += num;
			temp = temp /10;
		}
		//check divisiblity of number by their sum
		if(number % sum == 0){
			Console.WriteLine(" Harshad Number.");
		}
		else{
			Console.WriteLine("Not a Harshad Number.");
		}
	}
}