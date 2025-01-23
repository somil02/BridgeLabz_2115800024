using System;
class Armstrong{
	static void Main(string[] args){
		int number = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		int n = number;
		int temp = number;
		//count number of digits
		while(n!=0){
			n = n / 10;
			count++;
		}
		double sum =0;
		 // Sum of digits raised to the power of count
		while(temp!=0){
			int num = temp%10;
			sum += Math.Pow(num,count);
			temp = temp /10;
		}
		if(sum == number){
			Console.WriteLine("Number is Armstrong number");
		}
		else{
			Console.WriteLine("Number is not a Armstrong number");
		}
	}
}