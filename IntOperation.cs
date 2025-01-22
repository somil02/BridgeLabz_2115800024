using System;

class Operations{
	static void Main(string[] args){
		Console.Write("enter value of a");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("enter value of b");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.Write("enter value of c");
		int c = Convert.ToInt32(Console.ReadLine());
		
		int operation1 = a + b * c;
		int operation2 = a * b + c;
		int operation3 = c + a / b;
		int operation4 = a % b + c;
		
		Console.Write("The results of Int Operations are " + operation1 + " , " + operation2 + " , " + operation3 + " , and " + operation4 );
	}
}