using System;

class SpringSeason{
	static void Main(string[]args){
		int month = Convert.ToInt32(Console.ReadLine());
        int day = Convert.ToInt32(Console.ReadLine());
		// Check if the date falls within the Spring season (March 20 to June 20)
		if((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20)){
			Console.WriteLine("It's a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}