using System;
class Power
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks in maths (from 100): ");
        int maths = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks in physics (from 100)");
        int physics = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks in chemistry (from 100)");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        double marks = ((maths + physics + chemistry) / 300.0) * 100; // Calculate the percentage of total marks
		// Determine grade and remarks based on percentage
        if(marks >= 80){
			Console.Write("The average marks " +marks+ " with grade A and remarks are(Level 4, above agency-normalized standards)" );
		}
		else if(marks>=70 && marks<=79){
			Console.Write("The average marks " +marks+ " with grade B and remarks are(Level 3, at agency-normalized standards)" );
		}
		else if(marks>=60 && marks<=69){
			Console.Write("The average marks " +marks+ " with grade C and remarks are(Level 2, but approaching agency-normalized standards)" );
		}
		else if(marks>=50 && marks<=59){
			Console.Write("The average marks " +marks+ " with grade D and remarks are(Level 3, well below agency-normalized standards)" );
		}
		else if(marks>=40 && marks<=49){
			Console.Write("The average marks " +marks+ " with grade E and remarks are(Level 3, too below agency-normalized standards)" );
		}
		else{
			Console.Write("Remedial Standards");
		}
	}
}
