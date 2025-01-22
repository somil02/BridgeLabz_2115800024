using System;

class UniFee
{
    static void Main(string[] args)
    {
        double fee = double.Parse(Console.ReadLine());
        double discountPercent = double.Parse(Console.ReadLine());

        double discountAmount = (fee * discountPercent) / 100;

        double finalFee = fee - discountAmount;

        Console.WriteLine("The discount amount is INR " +discountAmount+ " and final discounted fee is INR "+finalFee);
    }
}
