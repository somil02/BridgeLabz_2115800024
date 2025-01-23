using System;
class Table{
	static void Main(string[] args){
		int number = Convert.ToInt32(Console.ReadLine());
		// Loop through numbers from 6 to 9 to display the multiplication table for the given number
		for(int i=6;i<=9;i++){
			Console.WriteLine(number+ " * " +i+ " = " +number*i);
		}
	}
}