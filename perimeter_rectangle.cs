using System;

class Perimeter{
	static void Main(string[] args){
		Console.Write("enter Length: ");
		int Length = Convert.ToInt32(Console.ReadLine());
		Console.Write("enter Width : ");
		int Width = Convert.ToInt32(Console.ReadLine());
		
		int perimeter= 2 * (Length + Width); 
		Console.Write(perimeter);
		
	}
}
