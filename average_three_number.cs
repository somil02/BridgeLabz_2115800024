using System;
class Power
{
    static void Main(string[] args)
    {
        Console.Write("Enter number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        double average = (number1+number2+number3)/3;
        Console.WriteLine(average);
    }
}
