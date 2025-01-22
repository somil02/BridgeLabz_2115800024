using System;
class interest{
	static void Main(string[] args){
		Console.Write("enter principal amount: ");
		int principal = int.Parse(Console.ReadLine());
		Console.Write("enter rate: ");
		int rate = int.Parse(Console.ReadLine());
		Console.Write("enter time: ");
		int time = int.Parse(Console.ReadLine());
		double simple_interest=(principal * rate * time) / 100;
		Console.Write(simple_interest);		
	}
}
