using System;

class Quotient_Remainder{
	static void Main(string[] args){
		Console.Write("Enter number1: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter number2: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		int quotient = number1/number2;
		int remainder = number1%number2;
		
		Console.Write("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
	}
}