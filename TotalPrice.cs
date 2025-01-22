using System;

class TotalPrice{
	static void Main(string[] args){
		double UnitPrice = Convert.ToDouble(Console.ReadLine());
		int quantity = Convert.ToInt32(Console.ReadLine());
		double TotalPrice = UnitPrice * quantity ;
		Console.Write("The total purchase price is INR " +TotalPrice+ " if the quantity " +quantity+ " and unit price is INR " +UnitPrice);
	}
}