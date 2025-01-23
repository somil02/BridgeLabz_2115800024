using System;

class LeapYear{
	static void Main(string[] args){
		int year = Convert.ToInt32(Console.ReadLine());
		//checking all conditions of leap year
		if(((year % 4==0 && year%100 !=0) || (year%400 == 0)) && year>1582 ){
			Console.WriteLine(year+" is a leap Year");
		}
		else{
			Console.WriteLine(year+" is not a leap Year");
		}
	}
}