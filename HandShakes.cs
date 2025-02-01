using System;

class HandshakeCalculator
{
    static int CalculateHandshakes(int n) // Method to calculate the number of handshakes using the combination formula
    {
        return (n * (n - 1)) / 2;
    }

    static void Main()
    {
        
        Console.Write("Enter the number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int handshakes = CalculateHandshakes(n); // Calculate the maximum number of handshakes
        Console.WriteLine("The maximum number of handshakes among " + n + " students is: " + handshakes);
    }
}
