using System;

class HeightConverter
{
    static void Main(string[] args)
    {
        
        double heightInCm = double.Parse(Console.ReadLine());

        double inchesInCm = 2.54;
        int inchesInFoot = 12;

        double heightInInches = heightInCm / inchesInCm;
		double heightInfeet = heightInInches / 12;

        Console.WriteLine("Your height in cm is "+heightInCm+ " while in feet is "+heightInfeet+ " feet and inches is " +heightInInches);
    }
}
