using System;
	class Area{
		static void Main(string[] args){
			Console.Write("Enter radius of circle: ");
			double radius = Convert.ToDouble(Console.ReadLine());
			
			 double Area = Math.PI * Math.Pow(radius,2);
			
			Console.WriteLine(Area);
		}
	}
