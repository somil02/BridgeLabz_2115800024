using System;

class SumOfNumbers{
	static void Main(string[] args){
		double total = 0.0;
		double number;
		// Continuously read numbers until a non-positive number is entered
		while(true){
			number = Convert.ToDouble(Console.ReadLine());
			if(number<=0) break; // Exit the loop if the number is less than or equal to 0
			total += number;
		}
		Console.WriteLine("The total sum is: " + total);
	}
}