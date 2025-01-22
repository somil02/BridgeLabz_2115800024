using System;

class KmtoMiles{
	static void Main(string[] args){
		double distance_Km = double.Parse(Console.ReadLine());
		double distance_Miles= distance_Km * 1.6;
		Console.Write("The total miles is " +distance_Miles + " mile for the given " + distance_Km+ " km");
	}
}