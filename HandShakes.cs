using System;

class HandShakes{
	static void Main(string[] args){
		int numberOfStudents = Convert.ToInt32(Console.ReadLine());
		int numberOfHandShakes = ( numberOfStudents * (numberOfStudents - 1) ) / 2;
		Console.Write("The number of HandShakes " +numberOfHandShakes);
	}
}