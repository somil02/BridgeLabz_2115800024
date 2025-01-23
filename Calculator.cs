using System;

class Calculator
{
    static void Main()
    {
        // Input first number
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());

        // Input second number
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());

        // Input operator
        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Perform operation based on the operator
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;

            case "/":
                // Check if second number is not zero to avoid division by zero
                if (second != 0)
                {
                    Console.WriteLine("Result: " + (first / second));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
