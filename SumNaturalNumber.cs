using System;
class Sum{
	static void Main(string[] args){
		int n = Convert.ToInt32(Console.ReadLine());
		if(n>0){
			//sum using while loop 
			int sumWhileLoop = 0;
			int i = 1;
			while (i <= n)
			{
				sumWhileLoop += i;
				i++; 
			}
			int sumFormula = n * (n + 1) / 2; //sum using formula 
			Console.WriteLine("Sum of first natural numbers using while loop " +sumWhileLoop);
            Console.WriteLine($"Sum of first natural numbers using formula " +sumFormula);

			if (sumWhileLoop == sumFormula){
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