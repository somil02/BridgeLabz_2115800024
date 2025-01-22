using System;

class Swap{
	static void Main(string[] args){
		Console.WriteLine("Enter the number1:");
        int number1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number2:");
        int number2 = Int32.Parse(Console.ReadLine());
		
		number1 = number1 + number2;
		number2 = number1 - number2;
		number1 = number1 - number2;
		
		Console.WriteLine("The Swapped numbers are " + number1 + " and " + number2 );
	}
}