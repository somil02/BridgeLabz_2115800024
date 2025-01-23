using System;

class SumOfNumbers{
	static void Main(string[] args){
		double total = 0.0;
		double number;
		// Continuously read numbers until 0 is entered
		while(true){
			number = Convert.ToDouble(Console.ReadLine());
			if(number==0) break; //break if number is 0
			total += number;
		}
		Console.WriteLine("The total sum is: " + total);
	}
}