using System;

class DistenceConverter{
	static void Main(string[] args){
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        double distanceInYards = distanceInFeet / 3;

        double distanceInMiles = distanceInFeet / 5280;

        Console.WriteLine("Your distance in yards is " + distanceInYards + " yards while in miles is " + distanceInMiles + "miles");
	}
}