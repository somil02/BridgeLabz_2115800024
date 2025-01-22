using System;
	class VolumeOfCylinder{
		static void Main(string[] args){
			Console.Write("enter radius: ");
			double radius = Convert.ToDouble(Console.ReadLine());
			Console.Write("enter height: ");
			double height = Convert.ToDouble(Console.ReadLine());
			double volume = Math.PI * Math.Pow(radius,2) * height;
			Console.WriteLine(volume);
		}
	}
