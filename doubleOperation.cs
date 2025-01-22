using System;

class Operations{
	static void Main(string[] args){
		Console.Write("enter value of a");
		double a = Convert.ToDouble(Console.ReadLine());
		Console.Write("enter value of b");
		double b = Convert.ToDouble(Console.ReadLine());
		Console.Write("enter value of c");
		double c = Convert.ToDouble(Console.ReadLine());
		
		double operation1 = a + b * c;
		double operation2 = a * b + c;
		double operation3 = c + a / b;
		double operation4 = a % b + c;
		
		Console.Write("The results of double Operations are " + operation1 + " , " + operation2 + " , " + operation3 + " , and " + operation4 );
	}
}