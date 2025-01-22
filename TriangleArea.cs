using System;

class TriangleArea{
	static void Main(string[] args){
		double baseTriangle= Convert.ToDouble(Console.ReadLine());
		double height= Convert.ToDouble(Console.ReadLine());
		double area = 0.5 * baseTriangle * height ;
		double area_inches = area * Math.Pow(0.393,2);
		Console.Write("Area of triangle in square cm is " + area + " and in square inches is " + area_inches);
	}
}