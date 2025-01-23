using System;

class Prime{
	static void Main(string[] args){
		int number= Convert.ToInt32(Console.ReadLine());
		bool isPrime=true;
		// Check divisors only up to the square root of the number for efficiency
		for(int i=2;i<Math.Sqrt(number);i++){
			if(number % i == 0){
				isPrime=false;
			}
		}
		Console.Write(isPrime);
	}
}