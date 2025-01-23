using System;

class BMI{
	static void Main(string[] args){
		Console.WriteLine("Enter weight in kg:");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height in cm:");
        double heightCm = Convert.ToDouble(Console.ReadLine());
		double heightM = heightCm / 100;
		double bmi = weight / (heightM * heightM);  // Calculate BMI
        // Determine BMI category
		if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Normal weight");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obesity");
        }
		
	}
}