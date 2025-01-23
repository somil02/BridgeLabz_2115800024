using System;

class Youngest{
	static void Main(string[] args){
		Console.WriteLine("Enter the age of Amar:");
        int ageAmar = Convert.ToInt32(Console.ReadLine());
		
        Console.WriteLine("Enter the height of Amar (in cm):");
        int heightAmar = Convert.ToInt32(Console.ReadLine());
		
        Console.WriteLine("Enter the age of Akbar:");
        int ageAkbar = Convert.ToInt32(Console.ReadLine());
		
        Console.WriteLine("Enter the height of Akbar (in cm):");
        int heightAkbar = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the age of Anthony:");
        int ageAnthony = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the height of Anthony (in cm):");
        int heightAnthony = Convert.ToInt32(Console.ReadLine());
		// Find the youngest friend
		int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        string youngestFriend = (youngestAge == ageAmar) ? "Amar" : (youngestAge == ageAkbar) ? "Akbar" : "Anthony";

        Console.WriteLine("The youngest friend is "+youngestFriend);
        // Find the tallest friend
        int tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
        string tallestFriend = (tallestHeight == heightAmar) ? "Amar" : (tallestHeight == heightAkbar) ? "Akbar" : "Anthony";

        Console.WriteLine("The tallest friend is "+tallestFriend);
	}
}