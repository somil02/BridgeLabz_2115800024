using System;

class ChocolateDistribution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of chocolates:");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of children:");
        int numberOfChildren = int.Parse(Console.ReadLine());

        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + "  and the number of remaining chocolates is " + remainingChocolates);
    }
}
