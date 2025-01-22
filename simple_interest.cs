using System;
class interest{
	static void Main(string[] args){
		Console.Write("enter principal amount: ");
		int principal = Convert.ToInt32(Console.ReadLine());
		Console.Write("enter rate: ");
		int rate = Convert.ToInt32(Console.ReadLine());
		Console.Write("enter time: ");
		int time = Convert.ToInt32(Console.ReadLine());
		double simple_interest=(principal * rate * time) / 100;
		Console.Write(simple_interest);		
	}
}
