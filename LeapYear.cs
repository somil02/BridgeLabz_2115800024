using System;
class LeapYear{
	public static bool Year(int year){
		if((year % 4 == 0 && year % 100 !=0) || (year %400 ==0)) // condition to check leap year
		{
			return true;
		}
		else{
			return false;
		}
	}
	public static void Main(string[] args){
		Console.WriteLine("enter the year (>=1582): ");
		int year = int.Parse(Console.ReadLine());
		Console.WriteLine(LeapYear.Year(year)); // print true if year is leap year else print false
	}
}