using System;
	class convert{
		static void Main(string[] args){
			Console.Write("enter distance in Km: ");
			double dist= Convert.ToDouble(Console.ReadLine());
			
			double Miles= dist * 0.621371;
			Console.Write(Miles);
		}
	}
