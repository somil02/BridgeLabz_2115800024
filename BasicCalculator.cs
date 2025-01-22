using System;

class BasicCalculator {
    static void Main(string[] args) {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        int addition = number1 + number2;
        int subtraction = number1 - number2;
        int multiplication = number1 * number2;
        double division = number2 != 0 ? (double)number1 / number2 : double.NaN;

        Console.Write("The addition, subtraction, multiplication and division values of 2 numbers " 
                      + number1 + " and " + number2 + " are " 
                      + addition + " , " + subtraction + " , " + multiplication + " , and " + division);
    }
}
