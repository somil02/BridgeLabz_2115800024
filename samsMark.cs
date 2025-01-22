using System;

class SamsMark{
	static void Main(string[] args){
		double mathMarks=94;
		double physicsMarks=95;
		double chemistryMarks=96;
		double total=mathMarks+physicsMarks+chemistryMarks;
		double avgMarks= total/3;
		Console.Write("Sam’s average mark in PCM is " + avgMarks);
	}
}