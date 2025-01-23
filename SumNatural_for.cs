using System;
class Sum{
	static void Main(string[] args){
		int n = Convert.ToInt32(Console.ReadLine());
		if(n>0){
			int sumForLoop = 0;
			 // Calculate the sum using a for loop
			for(int i = 1; i<=n;i++){
				sumForLoop +=i;
			}
			
			int sumFormula = n * (n + 1) / 2; // Calculate the sum using the formula n * (n + 1) / 2
			Console.WriteLine("Sum of first natural numbers using For loop " +sumForLoop);
            Console.WriteLine($"Sum of first natural numbers using formula " +sumFormula);
			// Check if both results are equal
			if (sumForLoop == sumFormula){
				Console.WriteLine("Both results are correct!");
			}
			else{
				Console.WriteLine("Both results are not correct!");
			}
        
		}
		else{
			Console.WriteLine("enter a number greater than 0.");
		}
	}
}