using System;

class GreatestFactor{
	static void Main(string[] args){
		int number = Convert.ToInt32(Console.ReadLine());
		int factor=1;
		// Find the greatest factor of the number (excluding itself)
		for(int i=number-1 ; i>0 ; i--){
			if(number % i == 0){ // Check if 'i' is a factor
				factor = i;
				break;
			}
		}
		Console.Write("The greatest factor of " + number + " besides itself is: " +factor);
	}
}