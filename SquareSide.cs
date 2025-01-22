using System;

class SquareSide{
	static void Main(string[] args){
		double Perimeter = Convert.ToDouble(Console.ReadLine());
		double side = Perimeter / 4;
		Console.Write(" The length of the side is " +side+ " whose perimeter is " +Perimeter);
	}
}