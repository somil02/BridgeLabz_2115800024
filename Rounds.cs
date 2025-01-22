using System;

class Rounds{
	static void Main(string[] args){
		Console.Write("Enter the value of side1 : ");
		int side1 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter the value of side2 : ");
		int side2 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter the value of side3 : ");
		int side3 = Int32.Parse(Console.ReadLine());
		int distance=5;
		
		int perimeter = side1+side2+side3;
		
		double rounds = distance / perimeter;
		
		Console.Write("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
	}
}