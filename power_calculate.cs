using System;
class power{
	static void Main(string[] args){
		Console.Write("enter number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		Console.Write("enter exponent: ");
		int exponent = Convert.ToInt32(Console.ReadLine());
		double power_calculate= Math.Pow(number,exponent);
		Console.Write(power_calculate);	
	}
}
